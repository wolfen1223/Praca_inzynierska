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

            if (DateDateTimePickerDRel.Value == null)
            {
                DateDateTimePickerDRel.Enabled = false;
            }
            else
            {
                checkBox.Checked = true;
            }
        }

        public DodajZamowienia(bool edycja)
        {
            InitializeComponent();
            this.edycja = edycja;

            if (DateDateTimePickerDRel.Value == null)
            {
                DateDateTimePickerDRel.Enabled = false;
                checkBox.Checked = true;
            }
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

                zamowienie zam = new zamowienie
                {
                    id_partia = 1,
                    id_zamowienie = id + 1,
                    gatunek = id_gat,
                    ilosc = Convert.ToInt32(txtIlosc.Text),
                    data_zamówienia = DateDateTimePickerDZam.Value,
                    data_realizacji = DateDateTimePickerDZam.Value,
                    pracownik = prac,
                    firma = fir,
                    wartość = Convert.ToInt32(txtWartosc.Text),
                    realizacja = real
                };

                baza.zamowienies.InsertOnSubmit(zam);
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
                z.data_realizacji = DateDateTimePickerDZam.Value;
                z.pracownik = idprac;
                z.firma = idfirm;
                z.wartość = Convert.ToDecimal(txtWartosc.Text);
                z.realizacja = real;

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
                real = "nie";
                DateDateTimePickerDRel.Enabled = true;
            }
            else
            {
                real = "nie";
                DateDateTimePickerDRel.Enabled = false;
            }
        }
    }
}
