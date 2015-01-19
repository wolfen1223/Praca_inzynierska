namespace projekt_do_rzezni
{
    partial class Logowanie
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda wsparcia projektanta - nie należy modyfikować
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesel = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.btnZaloguj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hasło";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login";
            // 
            // txtPesel
            // 
            this.txtPesel.Location = new System.Drawing.Point(54, 45);
            this.txtPesel.MaxLength = 11;
            this.txtPesel.Name = "txtPesel";
            this.txtPesel.PasswordChar = '*';
            this.txtPesel.Size = new System.Drawing.Size(100, 20);
            this.txtPesel.TabIndex = 7;
            this.txtPesel.TextChanged += new System.EventHandler(this.txtPesel_TextChanged);
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(54, 19);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(100, 20);
            this.txtNazwisko.TabIndex = 6;
            // 
            // btnZaloguj
            // 
            this.btnZaloguj.Location = new System.Drawing.Point(79, 88);
            this.btnZaloguj.Name = "btnZaloguj";
            this.btnZaloguj.Size = new System.Drawing.Size(75, 23);
            this.btnZaloguj.TabIndex = 5;
            this.btnZaloguj.Text = "Zaloguj";
            this.btnZaloguj.UseVisualStyleBackColor = true;
            this.btnZaloguj.Click += new System.EventHandler(this.btnZaloguj_Click);
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(160, 119);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesel);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.btnZaloguj);
            this.Name = "Logowanie";
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesel;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.Button btnZaloguj;
    }
}

