using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_do_rzezni
{
    public partial class Logowanie : Form
    {

      
        DataClasses1DataContext baza = new DataClasses1DataContext();


        public Logowanie()
        {
            InitializeComponent();
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {

            var query = from n in baza.pracowniks where n.nazwisko == txtNazwisko.Text.ToString() && n.pesel == txtPesel.Text.ToString() && n.stanowisko == 1 | n.stanowisko == 12 | n.stanowisko == 13 select n;
            
            if (query.Count() != 0)
            {
                    MessageBox.Show("Zalogowano ");
                    OknoGlowne og = new OknoGlowne();
                    og.Show();
                    this.Hide();
            }
            else
            {
                MessageBox.Show("Nie posiadasz uprawnień lub podałeś złe dane! Proszę spróbować ponownie.");
                this.txtNazwisko.Clear();
                this.txtPesel.Clear();
            }     
        }

        private void txtPesel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

