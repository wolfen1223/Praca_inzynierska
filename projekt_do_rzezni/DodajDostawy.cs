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
    public partial class DodajDostawy : Form
    {

        DataClasses1DataContext baza = new DataClasses1DataContext();

        public DodajDostawy()
        {
            InitializeComponent();
        }

        private void cbZwierzyna_DropDown(object sender, EventArgs e)
        {
            var query = (from x in baza.zwierzynas select x.nazwa).Distinct();
            cbZwierzyna.DataSource = query;
        }

        private void cbDostawca_DropDown(object sender, EventArgs e)
        {
            var query1 = (from d in baza.firmas select d.nazwa_firmy).Distinct();
            cbDostawca.DataSource = query1;
        }

        private void btnDodDosDodaj_Click(object sender, EventArgs e)
        {

            int idInwentarz = (from x in baza.inwentarzs
                               select x.id_inwentarz).Max();

            int zwierz = (from q in baza.zwierzynas
                         where q.nazwa == cbZwierzyna.Text.ToString()
                         select q.id_zwierzyna).FirstOrDefault();

            int dost = (from q in baza.firmas
                          where q.nazwa_firmy == cbDostawca.Text.ToString()
                          select q.id_firmy).FirstOrDefault();

            inwentarz inw = new inwentarz
            {
                id_inwentarz = idInwentarz + 1,
                zwierzyna = zwierz,
                dostawca = dost,
                data_zakupu = productionDateDateTimePicker.Value,
                waga = Convert.ToInt32(txtWaga.Text),
            };

            baza.inwentarzs.InsertOnSubmit(inw);
            baza.SubmitChanges();
            MessageBox.Show("Dane zostały wprowadzone.");
            this.Close();
        }

        private void btnDodDosAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
