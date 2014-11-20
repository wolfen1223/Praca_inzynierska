namespace projekt_do_rzezni
{
    partial class DodajPracownika
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnDodPracDodaj = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbStanowisko = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerDatPrzy = new System.Windows.Forms.DateTimePicker();
            this.txtLok = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtPracPesel = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.dateTimePickerDatUr = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "PESEL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stanowisko";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data urodzenia";
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(28, 293);
            this.btnAnuluj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(100, 28);
            this.btnAnuluj.TabIndex = 5;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnDodPracDodaj
            // 
            this.btnDodPracDodaj.Location = new System.Drawing.Point(271, 293);
            this.btnDodPracDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodPracDodaj.Name = "btnDodPracDodaj";
            this.btnDodPracDodaj.Size = new System.Drawing.Size(100, 28);
            this.btnDodPracDodaj.TabIndex = 6;
            this.btnDodPracDodaj.Text = "Zapisz";
            this.btnDodPracDodaj.UseVisualStyleBackColor = true;
            this.btnDodPracDodaj.Click += new System.EventHandler(this.btnDodPracDodaj_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Lokalizacja";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 182);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Telefon";
            // 
            // cbStanowisko
            // 
            this.cbStanowisko.FormattingEnabled = true;
            this.cbStanowisko.Location = new System.Drawing.Point(146, 116);
            this.cbStanowisko.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbStanowisko.Name = "cbStanowisko";
            this.cbStanowisko.Size = new System.Drawing.Size(224, 24);
            this.cbStanowisko.TabIndex = 14;
            this.cbStanowisko.DropDown += new System.EventHandler(this.cbStanowisko_DropDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 247);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Data przyjęcia";
            // 
            // dateTimePickerDatPrzy
            // 
            this.dateTimePickerDatPrzy.Location = new System.Drawing.Point(146, 245);
            this.dateTimePickerDatPrzy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerDatPrzy.Name = "dateTimePickerDatPrzy";
            this.dateTimePickerDatPrzy.Size = new System.Drawing.Size(224, 22);
            this.dateTimePickerDatPrzy.TabIndex = 18;
            // 
            // txtLok
            // 
            this.txtLok.Location = new System.Drawing.Point(147, 148);
            this.txtLok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLok.Name = "txtLok";
            this.txtLok.Size = new System.Drawing.Size(224, 22);
            this.txtLok.TabIndex = 20;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(147, 180);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTel.MaxLength = 11;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(224, 22);
            this.txtTel.TabIndex = 21;
            // 
            // txtPracPesel
            // 
            this.txtPracPesel.Location = new System.Drawing.Point(146, 84);
            this.txtPracPesel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPracPesel.MaxLength = 11;
            this.txtPracPesel.Name = "txtPracPesel";
            this.txtPracPesel.Size = new System.Drawing.Size(224, 22);
            this.txtPracPesel.TabIndex = 22;
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(146, 52);
            this.txtNazwisko.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(224, 22);
            this.txtNazwisko.TabIndex = 23;
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(146, 20);
            this.txtImie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(224, 22);
            this.txtImie.TabIndex = 24;
            // 
            // dateTimePickerDatUr
            // 
            this.dateTimePickerDatUr.Location = new System.Drawing.Point(147, 212);
            this.dateTimePickerDatUr.Name = "dateTimePickerDatUr";
            this.dateTimePickerDatUr.Size = new System.Drawing.Size(224, 22);
            this.dateTimePickerDatUr.TabIndex = 25;
            // 
            // DodajPracownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 334);
            this.Controls.Add(this.dateTimePickerDatUr);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.txtPracPesel);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtLok);
            this.Controls.Add(this.dateTimePickerDatPrzy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbStanowisko);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDodPracDodaj);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DodajPracownika";
            this.Text = "DodajPracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnDodPracDodaj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cbStanowisko;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DateTimePicker dateTimePickerDatPrzy;
        public System.Windows.Forms.TextBox txtLok;
        public System.Windows.Forms.TextBox txtTel;
        public System.Windows.Forms.TextBox txtPracPesel;
        public System.Windows.Forms.TextBox txtNazwisko;
        public System.Windows.Forms.TextBox txtImie;
        public System.Windows.Forms.DateTimePicker dateTimePickerDatUr;
    }
}