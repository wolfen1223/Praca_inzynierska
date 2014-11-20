namespace projekt_do_rzezni
{
    partial class OknoGlowne
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
            this.Magazyn = new System.Windows.Forms.TabControl();
            this.tabDostawy = new System.Windows.Forms.TabPage();
            this.btn_exit1 = new System.Windows.Forms.Button();
            this.GridViewDos = new System.Windows.Forms.DataGridView();
            this.btnDostawyDodaj = new System.Windows.Forms.Button();
            this.tabZamowienia = new System.Windows.Forms.TabPage();
            this.btn_exit2 = new System.Windows.Forms.Button();
            this.GridViewZam = new System.Windows.Forms.DataGridView();
            this.btnZamEdytuj = new System.Windows.Forms.Button();
            this.btnZamDodaj = new System.Windows.Forms.Button();
            this.tabPracownicy = new System.Windows.Forms.TabPage();
            this.btn_exit3 = new System.Windows.Forms.Button();
            this.btnPracEdytuj = new System.Windows.Forms.Button();
            this.btnDodPrac = new System.Windows.Forms.Button();
            this.GridViewPrac = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_exit4 = new System.Windows.Forms.Button();
            this.GridViewMag = new System.Windows.Forms.DataGridView();
            this.Magazyn.SuspendLayout();
            this.tabDostawy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDos)).BeginInit();
            this.tabZamowienia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewZam)).BeginInit();
            this.tabPracownicy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPrac)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMag)).BeginInit();
            this.SuspendLayout();
            // 
            // Magazyn
            // 
            this.Magazyn.Controls.Add(this.tabDostawy);
            this.Magazyn.Controls.Add(this.tabZamowienia);
            this.Magazyn.Controls.Add(this.tabPracownicy);
            this.Magazyn.Controls.Add(this.tabPage1);
            this.Magazyn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Magazyn.Location = new System.Drawing.Point(0, 0);
            this.Magazyn.Name = "Magazyn";
            this.Magazyn.SelectedIndex = 0;
            this.Magazyn.Size = new System.Drawing.Size(684, 375);
            this.Magazyn.TabIndex = 3;
            this.Magazyn.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabDostawy
            // 
            this.tabDostawy.Controls.Add(this.btn_exit1);
            this.tabDostawy.Controls.Add(this.GridViewDos);
            this.tabDostawy.Controls.Add(this.btnDostawyDodaj);
            this.tabDostawy.Location = new System.Drawing.Point(4, 22);
            this.tabDostawy.Name = "tabDostawy";
            this.tabDostawy.Padding = new System.Windows.Forms.Padding(3);
            this.tabDostawy.Size = new System.Drawing.Size(676, 349);
            this.tabDostawy.TabIndex = 0;
            this.tabDostawy.Text = "Dostawy";
            this.tabDostawy.UseVisualStyleBackColor = true;
            // 
            // btn_exit1
            // 
            this.btn_exit1.Location = new System.Drawing.Point(5, 319);
            this.btn_exit1.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exit1.Name = "btn_exit1";
            this.btn_exit1.Size = new System.Drawing.Size(81, 23);
            this.btn_exit1.TabIndex = 9;
            this.btn_exit1.Text = "exit";
            this.btn_exit1.UseVisualStyleBackColor = true;
            this.btn_exit1.Click += new System.EventHandler(this.btn_exit2_Click);
            // 
            // GridViewDos
            // 
            this.GridViewDos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDos.Location = new System.Drawing.Point(6, 6);
            this.GridViewDos.Name = "GridViewDos";
            this.GridViewDos.ReadOnly = true;
            this.GridViewDos.Size = new System.Drawing.Size(662, 307);
            this.GridViewDos.TabIndex = 1;
            // 
            // btnDostawyDodaj
            // 
            this.btnDostawyDodaj.Location = new System.Drawing.Point(596, 319);
            this.btnDostawyDodaj.Name = "btnDostawyDodaj";
            this.btnDostawyDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDostawyDodaj.TabIndex = 4;
            this.btnDostawyDodaj.Text = "Dodaj";
            this.btnDostawyDodaj.UseVisualStyleBackColor = true;
            this.btnDostawyDodaj.Click += new System.EventHandler(this.btnDostawyDodaj_Click);
            // 
            // tabZamowienia
            // 
            this.tabZamowienia.Controls.Add(this.btn_exit2);
            this.tabZamowienia.Controls.Add(this.GridViewZam);
            this.tabZamowienia.Controls.Add(this.btnZamEdytuj);
            this.tabZamowienia.Controls.Add(this.btnZamDodaj);
            this.tabZamowienia.Location = new System.Drawing.Point(4, 22);
            this.tabZamowienia.Name = "tabZamowienia";
            this.tabZamowienia.Padding = new System.Windows.Forms.Padding(3);
            this.tabZamowienia.Size = new System.Drawing.Size(676, 349);
            this.tabZamowienia.TabIndex = 1;
            this.tabZamowienia.Text = "Zamówienia";
            this.tabZamowienia.UseVisualStyleBackColor = true;
            // 
            // btn_exit2
            // 
            this.btn_exit2.Location = new System.Drawing.Point(3, 319);
            this.btn_exit2.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exit2.Name = "btn_exit2";
            this.btn_exit2.Size = new System.Drawing.Size(81, 23);
            this.btn_exit2.TabIndex = 8;
            this.btn_exit2.Text = "exit";
            this.btn_exit2.UseVisualStyleBackColor = true;
            this.btn_exit2.Click += new System.EventHandler(this.btn_exit1_Click);
            // 
            // GridViewZam
            // 
            this.GridViewZam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewZam.Location = new System.Drawing.Point(3, 6);
            this.GridViewZam.Name = "GridViewZam";
            this.GridViewZam.Size = new System.Drawing.Size(668, 307);
            this.GridViewZam.TabIndex = 2;
            // 
            // btnZamEdytuj
            // 
            this.btnZamEdytuj.Location = new System.Drawing.Point(515, 319);
            this.btnZamEdytuj.Name = "btnZamEdytuj";
            this.btnZamEdytuj.Size = new System.Drawing.Size(75, 23);
            this.btnZamEdytuj.TabIndex = 7;
            this.btnZamEdytuj.Text = "Edytuj";
            this.btnZamEdytuj.UseVisualStyleBackColor = true;
            this.btnZamEdytuj.Click += new System.EventHandler(this.btnZamEdytuj_Click);
            // 
            // btnZamDodaj
            // 
            this.btnZamDodaj.Location = new System.Drawing.Point(596, 319);
            this.btnZamDodaj.Name = "btnZamDodaj";
            this.btnZamDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnZamDodaj.TabIndex = 5;
            this.btnZamDodaj.Text = "Dodaj";
            this.btnZamDodaj.UseVisualStyleBackColor = true;
            this.btnZamDodaj.Click += new System.EventHandler(this.btnZamDodaj_Click);
            // 
            // tabPracownicy
            // 
            this.tabPracownicy.Controls.Add(this.btn_exit3);
            this.tabPracownicy.Controls.Add(this.btnPracEdytuj);
            this.tabPracownicy.Controls.Add(this.btnDodPrac);
            this.tabPracownicy.Controls.Add(this.GridViewPrac);
            this.tabPracownicy.Location = new System.Drawing.Point(4, 22);
            this.tabPracownicy.Name = "tabPracownicy";
            this.tabPracownicy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPracownicy.Size = new System.Drawing.Size(676, 349);
            this.tabPracownicy.TabIndex = 3;
            this.tabPracownicy.Text = "Pracownicy";
            this.tabPracownicy.UseVisualStyleBackColor = true;
            // 
            // btn_exit3
            // 
            this.btn_exit3.Location = new System.Drawing.Point(6, 320);
            this.btn_exit3.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exit3.Name = "btn_exit3";
            this.btn_exit3.Size = new System.Drawing.Size(81, 23);
            this.btn_exit3.TabIndex = 9;
            this.btn_exit3.Text = "exit";
            this.btn_exit3.UseVisualStyleBackColor = true;
            this.btn_exit3.Click += new System.EventHandler(this.btn_exit3_Click);
            // 
            // btnPracEdytuj
            // 
            this.btnPracEdytuj.Location = new System.Drawing.Point(515, 320);
            this.btnPracEdytuj.Name = "btnPracEdytuj";
            this.btnPracEdytuj.Size = new System.Drawing.Size(75, 23);
            this.btnPracEdytuj.TabIndex = 8;
            this.btnPracEdytuj.Text = "Edytuj";
            this.btnPracEdytuj.UseVisualStyleBackColor = true;
            this.btnPracEdytuj.Click += new System.EventHandler(this.btnPracEdytuj_Click);
            // 
            // btnDodPrac
            // 
            this.btnDodPrac.Location = new System.Drawing.Point(596, 320);
            this.btnDodPrac.Name = "btnDodPrac";
            this.btnDodPrac.Size = new System.Drawing.Size(75, 23);
            this.btnDodPrac.TabIndex = 6;
            this.btnDodPrac.Text = "Dodaj";
            this.btnDodPrac.UseVisualStyleBackColor = true;
            this.btnDodPrac.Click += new System.EventHandler(this.btnPracDodaj_Click);
            // 
            // GridViewPrac
            // 
            this.GridViewPrac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewPrac.Location = new System.Drawing.Point(6, 6);
            this.GridViewPrac.Name = "GridViewPrac";
            this.GridViewPrac.Size = new System.Drawing.Size(665, 308);
            this.GridViewPrac.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_exit4);
            this.tabPage1.Controls.Add(this.GridViewMag);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(676, 349);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Magazyn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_exit4
            // 
            this.btn_exit4.Location = new System.Drawing.Point(5, 319);
            this.btn_exit4.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exit4.Name = "btn_exit4";
            this.btn_exit4.Size = new System.Drawing.Size(81, 23);
            this.btn_exit4.TabIndex = 10;
            this.btn_exit4.Text = "exit";
            this.btn_exit4.UseVisualStyleBackColor = true;
            this.btn_exit4.Click += new System.EventHandler(this.btn_exit4_Click);
            // 
            // GridViewMag
            // 
            this.GridViewMag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewMag.Location = new System.Drawing.Point(6, 6);
            this.GridViewMag.Name = "GridViewMag";
            this.GridViewMag.Size = new System.Drawing.Size(662, 307);
            this.GridViewMag.TabIndex = 0;
            // 
            // OknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 375);
            this.Controls.Add(this.Magazyn);
            this.Name = "OknoGlowne";
            this.Text = "Okno główne";
            this.Magazyn.ResumeLayout(false);
            this.tabDostawy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDos)).EndInit();
            this.tabZamowienia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewZam)).EndInit();
            this.tabPracownicy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPrac)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Magazyn;
        private System.Windows.Forms.TabPage tabDostawy;
        private System.Windows.Forms.TabPage tabZamowienia;
        private System.Windows.Forms.Button btnDostawyDodaj;
        private System.Windows.Forms.Button btnZamEdytuj;
        private System.Windows.Forms.Button btnZamDodaj;
        public System.Windows.Forms.DataGridView GridViewDos;
        public System.Windows.Forms.DataGridView GridViewZam;
        private System.Windows.Forms.TabPage tabPracownicy;
        private System.Windows.Forms.Button btnDodPrac;
        public System.Windows.Forms.DataGridView GridViewPrac;
        private System.Windows.Forms.Button btnPracEdytuj;
        private System.Windows.Forms.Button btn_exit2;
        private System.Windows.Forms.Button btn_exit1;
        private System.Windows.Forms.Button btn_exit3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_exit4;
        private System.Windows.Forms.DataGridView GridViewMag;
    }
}