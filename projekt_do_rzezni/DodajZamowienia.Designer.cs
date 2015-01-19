namespace projekt_do_rzezni
{
    partial class DodajZamowienia
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
            this.btnDodZamDodaj = new System.Windows.Forms.Button();
            this.btnDodZamAnuluj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbGatunek = new System.Windows.Forms.ComboBox();
            this.cbPracownik = new System.Windows.Forms.ComboBox();
            this.cbFirma = new System.Windows.Forms.ComboBox();
            this.DateDateTimePickerDZam = new System.Windows.Forms.DateTimePicker();
            this.txtIlosc = new System.Windows.Forms.TextBox();
            this.txtWartosc = new System.Windows.Forms.TextBox();
            this.DateDateTimePickerDRel = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnDodZamDodaj
            // 
            this.btnDodZamDodaj.Location = new System.Drawing.Point(219, 225);
            this.btnDodZamDodaj.Name = "btnDodZamDodaj";
            this.btnDodZamDodaj.Size = new System.Drawing.Size(95, 23);
            this.btnDodZamDodaj.TabIndex = 20;
            this.btnDodZamDodaj.Text = "Dodaj";
            this.btnDodZamDodaj.UseVisualStyleBackColor = true;
            this.btnDodZamDodaj.Click += new System.EventHandler(this.btnDodZamDodaj_Click);
            // 
            // btnDodZamAnuluj
            // 
            this.btnDodZamAnuluj.Location = new System.Drawing.Point(10, 225);
            this.btnDodZamAnuluj.Name = "btnDodZamAnuluj";
            this.btnDodZamAnuluj.Size = new System.Drawing.Size(95, 23);
            this.btnDodZamAnuluj.TabIndex = 19;
            this.btnDodZamAnuluj.Text = "Anuluj";
            this.btnDodZamAnuluj.UseVisualStyleBackColor = true;
            this.btnDodZamAnuluj.Click += new System.EventHandler(this.btnDodZamAnuluj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Gatunek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ilość";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Pracownik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Firma";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Wartość";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Data zamówienia";
            // 
            // cbGatunek
            // 
            this.cbGatunek.DisplayMember = "cena";
            this.cbGatunek.FormattingEnabled = true;
            this.cbGatunek.Location = new System.Drawing.Point(127, 25);
            this.cbGatunek.Name = "cbGatunek";
            this.cbGatunek.Size = new System.Drawing.Size(189, 21);
            this.cbGatunek.TabIndex = 30;
            this.cbGatunek.DropDown += new System.EventHandler(this.cbGatunek_DropDown);
            this.cbGatunek.ValueMemberChanged += new System.EventHandler(this.cbGatunek_DropDown);
            // 
            // cbPracownik
            // 
            this.cbPracownik.FormattingEnabled = true;
            this.cbPracownik.Location = new System.Drawing.Point(126, 79);
            this.cbPracownik.Name = "cbPracownik";
            this.cbPracownik.Size = new System.Drawing.Size(189, 21);
            this.cbPracownik.TabIndex = 32;
            this.cbPracownik.DropDown += new System.EventHandler(this.cbPracownik_DropDown);
            // 
            // cbFirma
            // 
            this.cbFirma.FormattingEnabled = true;
            this.cbFirma.Location = new System.Drawing.Point(126, 106);
            this.cbFirma.Name = "cbFirma";
            this.cbFirma.Size = new System.Drawing.Size(189, 21);
            this.cbFirma.TabIndex = 34;
            this.cbFirma.DropDown += new System.EventHandler(this.cbFirma_DropDown);
            // 
            // DateDateTimePickerDZam
            // 
            this.DateDateTimePickerDZam.Location = new System.Drawing.Point(126, 159);
            this.DateDateTimePickerDZam.Name = "DateDateTimePickerDZam";
            this.DateDateTimePickerDZam.Size = new System.Drawing.Size(190, 20);
            this.DateDateTimePickerDZam.TabIndex = 36;
            // 
            // txtIlosc
            // 
            this.txtIlosc.Location = new System.Drawing.Point(127, 52);
            this.txtIlosc.Name = "txtIlosc";
            this.txtIlosc.Size = new System.Drawing.Size(189, 20);
            this.txtIlosc.TabIndex = 33;
            this.txtIlosc.Leave += new System.EventHandler(this.txtIlosc_Leave);
            // 
            // txtWartosc
            // 
            this.txtWartosc.Enabled = false;
            this.txtWartosc.Location = new System.Drawing.Point(126, 133);
            this.txtWartosc.Name = "txtWartosc";
            this.txtWartosc.Size = new System.Drawing.Size(189, 20);
            this.txtWartosc.TabIndex = 35;
            // 
            // DateDateTimePickerDRel
            // 
            this.DateDateTimePickerDRel.Enabled = false;
            this.DateDateTimePickerDRel.Location = new System.Drawing.Point(126, 185);
            this.DateDateTimePickerDRel.Name = "DateDateTimePickerDRel";
            this.DateDateTimePickerDRel.Size = new System.Drawing.Size(190, 20);
            this.DateDateTimePickerDRel.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Data realizacji";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(94, 186);
            this.checkBox.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(15, 14);
            this.checkBox.TabIndex = 41;
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // DodajZamowienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 275);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.DateDateTimePickerDRel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DateDateTimePickerDZam);
            this.Controls.Add(this.txtWartosc);
            this.Controls.Add(this.cbFirma);
            this.Controls.Add(this.txtIlosc);
            this.Controls.Add(this.cbPracownik);
            this.Controls.Add(this.cbGatunek);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDodZamDodaj);
            this.Controls.Add(this.btnDodZamAnuluj);
            this.Name = "DodajZamowienia";
            this.Text = "DodajZamowienia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodZamDodaj;
        private System.Windows.Forms.Button btnDodZamAnuluj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cbGatunek;
        public System.Windows.Forms.ComboBox cbPracownik;
        public System.Windows.Forms.ComboBox cbFirma;
        public System.Windows.Forms.DateTimePicker DateDateTimePickerDZam;
        public System.Windows.Forms.TextBox txtIlosc;
        public System.Windows.Forms.TextBox txtWartosc;
        public System.Windows.Forms.DateTimePicker DateDateTimePickerDRel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox;
    }
}