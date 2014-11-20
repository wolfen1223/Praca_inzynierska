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
    public partial class OknoGlowne : Form
    {
        DataClasses1DataContext baza = new DataClasses1DataContext();

        public OknoGlowne()
        {
            InitializeComponent();
            this.WczytajDostawy();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Magazyn.SelectedIndex == 0)
            {
                this.WczytajDostawy();
            }
            else if (Magazyn.SelectedIndex == 1)
            {
                this.WczytajZamowienia();
            }
            else if (Magazyn.SelectedIndex == 2)
            {
                this.WczytajPracownika();
            }
            else if (Magazyn.SelectedIndex == 3)
            {
                this.WczytajMagazyn();
            }
        }

        class DostawcyRekord
        {
            public string Nazwa_Zwierzyny { get; set; }
            public string Nazwa_Firmy { get; set; }
            public DateTime Data_Zakupu { get; set; }
            public decimal Waga { get; set; }
        }

        private void WczytajDostawy()
        {
            var dane = baza.GetTable<inwentarz>().Select(n => new DostawcyRekord
                {
                    Nazwa_Zwierzyny = n.zwierzyna1.nazwa,
                    Nazwa_Firmy = n.firma.nazwa_firmy,
                    Data_Zakupu = n.data_zakupu,
                    Waga = n.waga,
                });
            GridViewDos.DataSource = dane;
        }
     
        private void WczytajZamowienia()
        {
            var dane1 = (from z in baza.zamowienies
                         join ptm in baza.podzial_tuszy_miesas 
                         on z.gatunek equals ptm.id_gatunek
                         join p in baza.pracowniks
                         on z.pracownik equals p.id_pracownik
                         join f in baza.firmas
                         on z.firma equals f.id_firmy
                         select new
                         {
                             z.id_zamowienie,
                             ptm.nazwa,
                             z.ilosc,
                             p.nazwisko,
                             f.nazwa_firmy,
                             z.wartość,
                             z.data_zamówienia,
                             z.data_realizacji
                         });
            GridViewZam.DataSource = dane1;
        }

        private void WczytajPracownika()
        {
            var dane3 = (from p in baza.pracowniks 
                         join s in baza.stanowiskos
                         on p.stanowisko equals s.id_stanowisko
                         select new 
                        { 
                            p.imie, 
                            p.nazwisko, 
                            p.pesel,
                            s.nazwa, 
                            p.data_urodzenia,
                            p.telefon,
                            p.data_przyjecia,
                            p.lokalizacja
                        });
            GridViewPrac.DataSource = dane3;
        }

        private void WczytajMagazyn()
        {
            var dane4 = (from p in baza.podzial_tuszy_miesas
                         select new 
                         { 
                            p.nazwa,
                            
                         });
            GridViewMag.DataSource = dane4;
        }

        private void btnDostawyDodaj_Click(object sender, EventArgs e)
        {
            DodajDostawy dd = new DodajDostawy();
            dd.Show();
        }

        private void btnZamEdytuj_Click(object sender, EventArgs e)
        {
            zamowienie query = (from x in baza.zamowienies
                                where x.id_zamowienie == Convert.ToInt32(GridViewZam.CurrentRow.Cells[0].Value)
                                select x).FirstOrDefault();

            string gat = (from x in baza.zamowienies
                         join y in baza.podzial_tuszy_miesas on x.gatunek equals y.id_gatunek
                         where x.gatunek == query.gatunek
                         select y.nazwa).FirstOrDefault();

            string prac = (from x in baza.zamowienies
                          join y in baza.pracowniks on x.pracownik equals y.id_pracownik
                          where x.pracownik == query.pracownik
                          select y.nazwisko).FirstOrDefault();

            string firm = (from x in baza.zamowienies
                           join y in baza.firmas on x.firma equals y.id_firmy
                           where x.firma == query.firma
                           select y.nazwa_firmy).FirstOrDefault();


            zamowienie z = query;

            DodajZamowienia edycja = new DodajZamowienia(true, query.id_zamowienie);
            edycja.cbGatunek.Text = gat;
            edycja.txtIlosc.Text = z.ilosc.ToString();
            edycja.cbPracownik.Text = prac;
            edycja.cbFirma.Text = firm;
            edycja.txtWartosc.Text = z.wartość.ToString();
            edycja.DateDateTimePickerDZam.Value = z.data_zamówienia.Value;
            edycja.DateDateTimePickerDRel.Value = z.data_realizacji.Value;
            edycja.Show();
        }

        private void btnZamDodaj_Click(object sender, EventArgs e)
        {
            DodajZamowienia dz = new DodajZamowienia(false);
            dz.Show();
        }

        private void btnPracDodaj_Click(object sender, EventArgs e)
        {
           DodajPracownika dp = new DodajPracownika(false);
           dp.Show();
        }

        private void btnPracEdytuj_Click(object sender, EventArgs e)
        {

            pracownik query = (from x in baza.pracowniks
                               where x.pesel == GridViewPrac.CurrentRow.Cells[2].Value.ToString()
                               select x).FirstOrDefault();

            string st = (from x in baza.pracowniks
                      join y in baza.stanowiskos on x.stanowisko equals y.id_stanowisko
                      where x.id_pracownik == query.id_pracownik
                      select y.nazwa).FirstOrDefault();

            pracownik p = query;

            DodajPracownika edycja = new DodajPracownika(true);
            edycja.txtImie.Text = p.imie;
            edycja.txtNazwisko.Text = p.nazwisko;
            edycja.txtPracPesel.Text = p.pesel;
            edycja.cbStanowisko.Text = st;
            edycja.txtLok.Text = p.lokalizacja;
            edycja.txtTel.Text = p.telefon;
            edycja.dateTimePickerDatUr.Value = p.data_urodzenia;
            edycja.dateTimePickerDatPrzy.Value = p.data_przyjecia;
            edycja.Show();
        }

        private void btn_exit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_exit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_exit3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_exit4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
