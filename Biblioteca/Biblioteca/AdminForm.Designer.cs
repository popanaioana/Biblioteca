namespace Biblioteca
{
    partial class AdminForm
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
            this.dgvBiblioteca = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAdaugaAutor = new System.Windows.Forms.TextBox();
            this.txtAdaugaTitlu = new System.Windows.Forms.TextBox();
            this.btnAdaugaCarte = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdaugaPersoana = new System.Windows.Forms.Button();
            this.txtAdaugaAdresa = new System.Windows.Forms.TextBox();
            this.dtpAdaugaDataN = new System.Windows.Forms.DateTimePicker();
            this.txtAdaugaParola = new System.Windows.Forms.TextBox();
            this.txtAdaugaEmail = new System.Windows.Forms.TextBox();
            this.txtAdaugaTelefon = new System.Windows.Forms.TextBox();
            this.txtAdaugaPrenume = new System.Windows.Forms.TextBox();
            this.txtAdaugaNume = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnImprumuta = new System.Windows.Forms.Button();
            this.dtpImprumuta = new System.Windows.Forms.DateTimePicker();
            this.txtImprumutaIdCarte = new System.Windows.Forms.TextBox();
            this.txtImprumutaIdPers = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnReturneaza = new System.Windows.Forms.Button();
            this.txtReturneazaIdCarte = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiblioteca)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBiblioteca
            // 
            this.dgvBiblioteca.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvBiblioteca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBiblioteca.Location = new System.Drawing.Point(16, 16);
            this.dgvBiblioteca.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBiblioteca.Name = "dgvBiblioteca";
            this.dgvBiblioteca.RowHeadersWidth = 51;
            this.dgvBiblioteca.RowTemplate.Height = 24;
            this.dgvBiblioteca.Size = new System.Drawing.Size(510, 479);
            this.dgvBiblioteca.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAdaugaAutor);
            this.groupBox1.Controls.Add(this.txtAdaugaTitlu);
            this.groupBox1.Controls.Add(this.btnAdaugaCarte);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(534, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(250, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adauga o carte";
            // 
            // txtAdaugaAutor
            // 
            this.txtAdaugaAutor.Location = new System.Drawing.Point(92, 64);
            this.txtAdaugaAutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdaugaAutor.Name = "txtAdaugaAutor";
            this.txtAdaugaAutor.Size = new System.Drawing.Size(124, 26);
            this.txtAdaugaAutor.TabIndex = 4;
            // 
            // txtAdaugaTitlu
            // 
            this.txtAdaugaTitlu.Location = new System.Drawing.Point(91, 28);
            this.txtAdaugaTitlu.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdaugaTitlu.Name = "txtAdaugaTitlu";
            this.txtAdaugaTitlu.Size = new System.Drawing.Size(124, 26);
            this.txtAdaugaTitlu.TabIndex = 3;
            // 
            // btnAdaugaCarte
            // 
            this.btnAdaugaCarte.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAdaugaCarte.Location = new System.Drawing.Point(135, 100);
            this.btnAdaugaCarte.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdaugaCarte.Name = "btnAdaugaCarte";
            this.btnAdaugaCarte.Size = new System.Drawing.Size(108, 36);
            this.btnAdaugaCarte.TabIndex = 2;
            this.btnAdaugaCarte.Text = "Adauga";
            this.btnAdaugaCarte.UseVisualStyleBackColor = false;
            this.btnAdaugaCarte.Click += new System.EventHandler(this.btnAdaugaCarte_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titlu:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdaugaPersoana);
            this.groupBox2.Controls.Add(this.txtAdaugaAdresa);
            this.groupBox2.Controls.Add(this.dtpAdaugaDataN);
            this.groupBox2.Controls.Add(this.txtAdaugaParola);
            this.groupBox2.Controls.Add(this.txtAdaugaEmail);
            this.groupBox2.Controls.Add(this.txtAdaugaTelefon);
            this.groupBox2.Controls.Add(this.txtAdaugaPrenume);
            this.groupBox2.Controls.Add(this.txtAdaugaNume);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(534, 168);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(250, 338);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adauga o persoana";
            // 
            // btnAdaugaPersoana
            // 
            this.btnAdaugaPersoana.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAdaugaPersoana.Location = new System.Drawing.Point(135, 292);
            this.btnAdaugaPersoana.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdaugaPersoana.Name = "btnAdaugaPersoana";
            this.btnAdaugaPersoana.Size = new System.Drawing.Size(108, 36);
            this.btnAdaugaPersoana.TabIndex = 14;
            this.btnAdaugaPersoana.Text = "Adauga";
            this.btnAdaugaPersoana.UseVisualStyleBackColor = false;
            this.btnAdaugaPersoana.Click += new System.EventHandler(this.btnAdaugaPersoana_Click);
            // 
            // txtAdaugaAdresa
            // 
            this.txtAdaugaAdresa.Location = new System.Drawing.Point(118, 252);
            this.txtAdaugaAdresa.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdaugaAdresa.Name = "txtAdaugaAdresa";
            this.txtAdaugaAdresa.Size = new System.Drawing.Size(124, 26);
            this.txtAdaugaAdresa.TabIndex = 13;
            // 
            // dtpAdaugaDataN
            // 
            this.dtpAdaugaDataN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAdaugaDataN.Location = new System.Drawing.Point(118, 216);
            this.dtpAdaugaDataN.Margin = new System.Windows.Forms.Padding(4);
            this.dtpAdaugaDataN.Name = "dtpAdaugaDataN";
            this.dtpAdaugaDataN.Size = new System.Drawing.Size(124, 26);
            this.dtpAdaugaDataN.TabIndex = 12;
            // 
            // txtAdaugaParola
            // 
            this.txtAdaugaParola.Location = new System.Drawing.Point(119, 180);
            this.txtAdaugaParola.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdaugaParola.Name = "txtAdaugaParola";
            this.txtAdaugaParola.Size = new System.Drawing.Size(124, 26);
            this.txtAdaugaParola.TabIndex = 11;
            // 
            // txtAdaugaEmail
            // 
            this.txtAdaugaEmail.Location = new System.Drawing.Point(119, 141);
            this.txtAdaugaEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdaugaEmail.Name = "txtAdaugaEmail";
            this.txtAdaugaEmail.Size = new System.Drawing.Size(124, 26);
            this.txtAdaugaEmail.TabIndex = 10;
            // 
            // txtAdaugaTelefon
            // 
            this.txtAdaugaTelefon.Location = new System.Drawing.Point(118, 104);
            this.txtAdaugaTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdaugaTelefon.Name = "txtAdaugaTelefon";
            this.txtAdaugaTelefon.Size = new System.Drawing.Size(124, 26);
            this.txtAdaugaTelefon.TabIndex = 9;
            // 
            // txtAdaugaPrenume
            // 
            this.txtAdaugaPrenume.Location = new System.Drawing.Point(118, 66);
            this.txtAdaugaPrenume.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdaugaPrenume.Name = "txtAdaugaPrenume";
            this.txtAdaugaPrenume.Size = new System.Drawing.Size(124, 26);
            this.txtAdaugaPrenume.TabIndex = 8;
            // 
            // txtAdaugaNume
            // 
            this.txtAdaugaNume.Location = new System.Drawing.Point(118, 29);
            this.txtAdaugaNume.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdaugaNume.Name = "txtAdaugaNume";
            this.txtAdaugaNume.Size = new System.Drawing.Size(124, 26);
            this.txtAdaugaNume.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 254);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Adresa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-4, 220);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Data nasterii:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 182);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Parola:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Prenume:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nume:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnImprumuta);
            this.groupBox3.Controls.Add(this.dtpImprumuta);
            this.groupBox3.Controls.Add(this.txtImprumutaIdCarte);
            this.groupBox3.Controls.Add(this.txtImprumutaIdPers);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(792, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(257, 167);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Imprumuta o carte";
            // 
            // btnImprumuta
            // 
            this.btnImprumuta.BackColor = System.Drawing.Color.SandyBrown;
            this.btnImprumuta.Location = new System.Drawing.Point(144, 125);
            this.btnImprumuta.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprumuta.Name = "btnImprumuta";
            this.btnImprumuta.Size = new System.Drawing.Size(108, 36);
            this.btnImprumuta.TabIndex = 7;
            this.btnImprumuta.Text = "Adauga";
            this.btnImprumuta.UseVisualStyleBackColor = false;
            this.btnImprumuta.Click += new System.EventHandler(this.btnImprumuta_Click);
            // 
            // dtpImprumuta
            // 
            this.dtpImprumuta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpImprumuta.Location = new System.Drawing.Point(150, 91);
            this.dtpImprumuta.Name = "dtpImprumuta";
            this.dtpImprumuta.Size = new System.Drawing.Size(100, 26);
            this.dtpImprumuta.TabIndex = 6;
            // 
            // txtImprumutaIdCarte
            // 
            this.txtImprumutaIdCarte.Location = new System.Drawing.Point(150, 29);
            this.txtImprumutaIdCarte.Name = "txtImprumutaIdCarte";
            this.txtImprumutaIdCarte.Size = new System.Drawing.Size(100, 26);
            this.txtImprumutaIdCarte.TabIndex = 5;
            // 
            // txtImprumutaIdPers
            // 
            this.txtImprumutaIdPers.Location = new System.Drawing.Point(150, 60);
            this.txtImprumutaIdPers.Name = "txtImprumutaIdPers";
            this.txtImprumutaIdPers.Size = new System.Drawing.Size(100, 26);
            this.txtImprumutaIdPers.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Data imprumutarii:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Id-ul persoanei:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Id-ul cartii:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnReturneaza);
            this.groupBox4.Controls.Add(this.txtReturneazaIdCarte);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(792, 197);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(264, 114);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Returneaza o carte";
            // 
            // btnReturneaza
            // 
            this.btnReturneaza.BackColor = System.Drawing.Color.SandyBrown;
            this.btnReturneaza.Location = new System.Drawing.Point(149, 70);
            this.btnReturneaza.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturneaza.Name = "btnReturneaza";
            this.btnReturneaza.Size = new System.Drawing.Size(108, 36);
            this.btnReturneaza.TabIndex = 7;
            this.btnReturneaza.Text = "Adauga";
            this.btnReturneaza.UseVisualStyleBackColor = false;
            this.btnReturneaza.Click += new System.EventHandler(this.btnReturneaza_Click);
            // 
            // txtReturneazaIdCarte
            // 
            this.txtReturneazaIdCarte.Location = new System.Drawing.Point(150, 29);
            this.txtReturneazaIdCarte.Name = "txtReturneazaIdCarte";
            this.txtReturneazaIdCarte.Size = new System.Drawing.Size(100, 26);
            this.txtReturneazaIdCarte.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Id-ul cartii:";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1065, 505);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBiblioteca);
            this.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiblioteca)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBiblioteca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAdaugaAutor;
        private System.Windows.Forms.TextBox txtAdaugaTitlu;
        private System.Windows.Forms.Button btnAdaugaCarte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdaugaPersoana;
        private System.Windows.Forms.TextBox txtAdaugaAdresa;
        private System.Windows.Forms.DateTimePicker dtpAdaugaDataN;
        private System.Windows.Forms.TextBox txtAdaugaParola;
        private System.Windows.Forms.TextBox txtAdaugaEmail;
        private System.Windows.Forms.TextBox txtAdaugaTelefon;
        private System.Windows.Forms.TextBox txtAdaugaPrenume;
        private System.Windows.Forms.TextBox txtAdaugaNume;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnImprumuta;
        private System.Windows.Forms.DateTimePicker dtpImprumuta;
        private System.Windows.Forms.TextBox txtImprumutaIdCarte;
        private System.Windows.Forms.TextBox txtImprumutaIdPers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnReturneaza;
        private System.Windows.Forms.TextBox txtReturneazaIdCarte;
        private System.Windows.Forms.Label label15;
    }
}