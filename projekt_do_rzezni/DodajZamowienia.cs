using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_do_rzezni
{

    public partial class DodajZamowienia : Form
    {
        private bool edycja;
        private int id;
        private string real;

        DataClasses1DataContext baza = new DataClasses1DataContext();

        public DodajZamowienia(bool edycja, int id)
        {
            InitializeComponent();
            this.edycja = edycja;
            this.id = id;
            checkBox.Checked = false;
             DateDateTimePickerDRel.Enabled = false;
             if (edycja)
             {
                 btnDodZamDodaj.Text = "Zapisz zmiany";
             }
        }

        public DodajZamowienia(bool edycja)
        {
            InitializeComponent();
            this.edycja = edycja;

            DateDateTimePickerDRel.Enabled = false;
            checkBox.Checked = false;
        }


        private void cbGatunek_DropDown(object sender, EventArgs e)
        {
            var query1 = (from g in baza.podzial_tuszy_miesas select g.nazwa).Distinct();
            cbGatunek.DataSource = query1;
        }
        private void cbPracownik_DropDown(object sender, EventArgs e)
        {
            var query2 = (from p in baza.pracowniks select p.nazwisko).Distinct();
            cbPracownik.DataSource = query2;
        }

        private void cbFirma_DropDown(object sender, EventArgs e)
        {
            var query3 = (from f in baza.firmas select f.nazwa_firmy).Distinct();
            cbFirma.DataSource = query3;
        }

        private void btnDodZamDodaj_Click(object sender, EventArgs e)
        {
            if (!edycja)
            {
                int id_gat = (from x in baza.podzial_tuszy_miesas
                                  where x.nazwa == cbGatunek.Text.ToString()
                                  select x.id_gatunek).FirstOrDefault();

                int prac = (from p in baza.pracowniks
                            where p.nazwisko == cbPracownik.Text.ToString()
                            select p.id_pracownik).FirstOrDefault();

                int fir = (from f in baza.firmas
                           where f.nazwa_firmy == cbFirma.Text.ToString()
                           select f.id_firmy).FirstOrDefault();

                
                if(DateDateTimePickerDRel.Enabled == false)
                {
                    zamowienie zam = new zamowienie
                    {
                        id_zamowienie = id + 1,
                        gatunek = id_gat,
                        ilosc = Convert.ToDecimal(txtIlosc.Text),
                        data_zamówienia = DateTime.Parse(DateDateTimePickerDZam.Value.ToString()),
                        data_realizacji = null,
                        pracownik = prac,
                        firma = fir,
                        wartość = Convert.ToDecimal(txtWartosc.Text),
                        realizacja = real
                    };
                    baza.zamowienies.InsertOnSubmit(zam);
                }
                else
                {
                    zamowienie zam = new zamowienie
                    {
                        id_zamowienie = id + 1,
                        gatunek = id_gat,
                        ilosc = Convert.ToDecimal(txtIlosc.Text),
                        data_zamówienia = DateDateTimePickerDZam.Value,
                        data_realizacji = DateDateTimePickerDRel.Value,
                        pracownik = prac,
                        firma = fir,
                        wartość = Convert.ToDecimal(txtWartosc.Text),
                        realizacja = real
                    };
                    baza.zamowienies.InsertOnSubmit(zam);

                    magazyn mag = new magazyn
                    {
                        id_gatunek = id_gat,
                        ilość = (Convert.ToInt32(txtIlosc.Text) * -1)
                    };
                    baza.magazyns.InsertOnSubmit(mag);
                }

                baza.SubmitChanges();
                MessageBox.Show("Dane zostały wprowadzone.");
                this.Close();
            }
            else
            {
                zamowienie query = (from x in baza.zamowienies
                                    where x.id_zamowienie == id
                                    select x).FirstOrDefault();

                int idgat = (from x in baza.podzial_tuszy_miesas
                             where x.nazwa == cbGatunek.Text.ToString()
                             select x.id_gatunek).FirstOrDefault();

                int idprac = (from x in baza.pracowniks
                              where x.nazwisko == cbPracownik.Text.ToString()
                              select x.id_pracownik).FirstOrDefault();

                int idfirm = (from x in baza.firmas
                             where x.nazwa_firmy == cbFirma.Text.ToString()
                             select x.id_firmy).FirstOrDefault();


                zamowienie z = query;

                z.gatunek = idgat;
                z.ilosc = Convert.ToDecimal(txtIlosc.Text);
                z.data_zamówienia = DateDateTimePickerDZam.Value;
                if (DateDateTimePickerDRel.Enabled == false)
                {
                    z.data_realizacji = null;
                }
                else
                {
                    z.data_realizacji = DateDateTimePickerDRel.Value;
                }
                
                z.pracownik = idprac;
                z.firma = idfirm;
                z.wartość = Convert.ToDecimal(txtWartosc.Text);
                z.realizacja = real;

                magazyn mag = new magazyn
                {
                    id_gatunek = idgat,
                    ilość = (Convert.ToInt32(txtIlosc.Text) * -1)
                };
                baza.magazyns.InsertOnSubmit(mag);

                baza.SubmitChanges();
                MessageBox.Show("Dane zostały edytowane.");
                this.Close();
            }
        }

        private void btnDodZamAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                real = "tak";
                DateDateTimePickerDRel.Enabled = true;
            }
            else
            {
                real = "nie";
                DateDateTimePickerDRel.Enabled = false;
            }
        }

        private void txtIlosc_Leave(object sender, EventArgs e)
        {
            var price = (from x in baza.podzial_tuszy_miesas
                         where x.nazwa == cbGatunek.Text
                         select x.cena).First();
            var koszt = price * Convert.ToDecimal(txtIlosc.Text);
            txtWartosc.Text = koszt.ToString();
        }
    }
}
