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
    public partial class DodajPracownika : Form
    {
        DataClasses1DataContext baza = new DataClasses1DataContext();

        private bool edycja;

        public DodajPracownika(bool edycja) // konstruktor z parametrem sprawdzajacym czy obiekt jest tworzony czy edytowany, oraz przesłanym obiektem typu pracownik
        {
            InitializeComponent();
            this.edycja = edycja;
        }


        private void cbStanowisko_DropDown(object sender, EventArgs e)
        {
            var query3 = (from pp in baza.stanowiskos select pp.nazwa).Distinct();
            cbStanowisko.DataSource = query3;
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy napewno chcesz dokonać zmian?", "Edycja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDodPracDodaj_Click(object sender, EventArgs e)
        {

            if (edycja)//jesli jest edytowant then
            {
                pracownik query = (from x in baza.pracowniks
                                   where x.pesel == txtPracPesel.Text.ToString()
                                   select x).FirstOrDefault();

                int idStanowisko = (from x in baza.stanowiskos
                                    where x.nazwa == cbStanowisko.Text.ToString()
                                    select x.id_stanowisko).FirstOrDefault();

                pracownik p = query;

                p.imie = txtImie.Text.ToString();
                p.nazwisko = txtNazwisko.Text.ToString();
                p.pesel = txtPracPesel.Text.ToString();
                p.stanowisko = idStanowisko;
                p.lokalizacja = txtLok.Text.ToString();
                p.telefon = txtTel.Text;
                p.data_urodzenia = dateTimePickerDatUr.Value.Date;
                p.data_przyjecia = dateTimePickerDatPrzy.Value.Date;

                baza.SubmitChanges();
                MessageBox.Show("Dane zostały edytowane.");
                this.Close();
            }
            else//jesli !edycja, dodajemy pracownika
            {
                int idStanowisko = (from x in baza.stanowiskos
                                    where x.nazwa == cbStanowisko.Text.ToString()
                                    select x.id_stanowisko).FirstOrDefault();

                pracownik p = new pracownik();
                p.imie = txtImie.Text.ToString();
                p.nazwisko = txtNazwisko.Text.ToString();
                p.pesel = txtPracPesel.Text.ToString();
                p.stanowisko = idStanowisko;
                p.lokalizacja = txtLok.Text.ToString();
                p.telefon = txtTel.Text;
                p.data_urodzenia = dateTimePickerDatUr.Value.Date;
                p.data_przyjecia = dateTimePickerDatPrzy.Value.Date;

                baza.pracowniks.InsertOnSubmit(p);
                baza.SubmitChanges();
                MessageBox.Show("Dane zostały wprowadzone.");
                this.Close();
            }        
        }    
    }
}
