namespace projekt_do_rzezni
{
    partial class DodajDostawy
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
            this.productionDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cbDostawca = new System.Windows.Forms.ComboBox();
            this.cbZwierzyna = new System.Windows.Forms.ComboBox();
            this.btnDodDosDodaj = new System.Windows.Forms.Button();
            this.btnDodDosAnuluj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWaga = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // productionDateDateTimePicker
            // 
            this.productionDateDateTimePicker.Location = new System.Drawing.Point(95, 74);
            this.productionDateDateTimePicker.Name = "productionDateDateTimePicker";
            this.productionDateDateTimePicker.Size = new System.Drawing.Size(169, 20);
            this.productionDateDateTimePicker.TabIndex = 24;
            // 
            // cbDostawca
            // 
            this.cbDostawca.FormattingEnabled = true;
            this.cbDostawca.Location = new System.Drawing.Point(95, 45);
            this.cbDostawca.Name = "cbDostawca";
            this.cbDostawca.Size = new System.Drawing.Size(168, 21);
            this.cbDostawca.TabIndex = 20;
            this.cbDostawca.DropDown += new System.EventHandler(this.cbDostawca_DropDown);
            // 
            // cbZwierzyna
            // 
            this.cbZwierzyna.FormattingEnabled = true;
            this.cbZwierzyna.Location = new System.Drawing.Point(95, 18);
            this.cbZwierzyna.Name = "cbZwierzyna";
            this.cbZwierzyna.Size = new System.Drawing.Size(168, 21);
            this.cbZwierzyna.TabIndex = 19;
            this.cbZwierzyna.DropDown += new System.EventHandler(this.cbZwierzyna_DropDown);
            // 
            // btnDodDosDodaj
            // 
            this.btnDodDosDodaj.Location = new System.Drawing.Point(169, 126);
            this.btnDodDosDodaj.Name = "btnDodDosDodaj";
            this.btnDodDosDodaj.Size = new System.Drawing.Size(95, 23);
            this.btnDodDosDodaj.TabIndex = 18;
            this.btnDodDosDodaj.Text = "Dodaj";
            this.btnDodDosDodaj.UseVisualStyleBackColor = true;
            this.btnDodDosDodaj.Click += new System.EventHandler(this.btnDodDosDodaj_Click);
            // 
            // btnDodDosAnuluj
            // 
            this.btnDodDosAnuluj.Location = new System.Drawing.Point(12, 126);
            this.btnDodDosAnuluj.Name = "btnDodDosAnuluj";
            this.btnDodDosAnuluj.Size = new System.Drawing.Size(95, 23);
            this.btnDodDosAnuluj.TabIndex = 17;
            this.btnDodDosAnuluj.Text = "Anuluj";
            this.btnDodDosAnuluj.UseVisualStyleBackColor = true;
            this.btnDodDosAnuluj.Click += new System.EventHandler(this.btnDodDosAnuluj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Waga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Data zakupu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Dostawca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Zwierzyna";
            // 
            // txtWaga
            // 
            this.txtWaga.Location = new System.Drawing.Point(95, 100);
            this.txtWaga.Name = "txtWaga";
            this.txtWaga.Size = new System.Drawing.Size(168, 20);
            this.txtWaga.TabIndex = 25;
            // 
            // DodajDostawy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 159);
            this.Controls.Add(this.txtWaga);
            this.Controls.Add(this.productionDateDateTimePicker);
            this.Controls.Add(this.cbDostawca);
            this.Controls.Add(this.cbZwierzyna);
            this.Controls.Add(this.btnDodDosDodaj);
            this.Controls.Add(this.btnDodDosAnuluj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodajDostawy";
            this.Text = "DodajDostawy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker productionDateDateTimePicker;
        public System.Windows.Forms.ComboBox cbDostawca;
        public System.Windows.Forms.ComboBox cbZwierzyna;
        private System.Windows.Forms.Button btnDodDosDodaj;
        private System.Windows.Forms.Button btnDodDosAnuluj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtWaga;
    }
}