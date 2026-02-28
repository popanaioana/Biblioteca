namespace Biblioteca
{
    partial class PersoanaForm
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
            this.lblBnAiVenit = new System.Windows.Forms.Label();
            this.lblCarti = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVerificaTitlu = new System.Windows.Forms.TextBox();
            this.txtVerificaAutor = new System.Windows.Forms.TextBox();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBnAiVenit
            // 
            this.lblBnAiVenit.AutoSize = true;
            this.lblBnAiVenit.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBnAiVenit.Location = new System.Drawing.Point(13, 13);
            this.lblBnAiVenit.Name = "lblBnAiVenit";
            this.lblBnAiVenit.Size = new System.Drawing.Size(143, 25);
            this.lblBnAiVenit.TabIndex = 0;
            this.lblBnAiVenit.Text = "Bine ai venit, ";
            // 
            // lblCarti
            // 
            this.lblCarti.AutoSize = true;
            this.lblCarti.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarti.Location = new System.Drawing.Point(17, 80);
            this.lblCarti.Name = "lblCarti";
            this.lblCarti.Size = new System.Drawing.Size(0, 22);
            this.lblCarti.TabIndex = 1;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(13, 157);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 22);
            this.lblTimer.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVerifica);
            this.groupBox1.Controls.Add(this.txtVerificaAutor);
            this.groupBox1.Controls.Add(this.txtVerificaTitlu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 145);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verifica disponibilitatea unei carti";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titlu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor:";
            // 
            // txtVerificaTitlu
            // 
            this.txtVerificaTitlu.Location = new System.Drawing.Point(86, 26);
            this.txtVerificaTitlu.Name = "txtVerificaTitlu";
            this.txtVerificaTitlu.Size = new System.Drawing.Size(100, 26);
            this.txtVerificaTitlu.TabIndex = 2;
            // 
            // txtVerificaAutor
            // 
            this.txtVerificaAutor.Location = new System.Drawing.Point(86, 59);
            this.txtVerificaAutor.Name = "txtVerificaAutor";
            this.txtVerificaAutor.Size = new System.Drawing.Size(100, 26);
            this.txtVerificaAutor.TabIndex = 3;
            // 
            // btnVerifica
            // 
            this.btnVerifica.BackColor = System.Drawing.Color.SandyBrown;
            this.btnVerifica.Location = new System.Drawing.Point(147, 100);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(106, 35);
            this.btnVerifica.TabIndex = 4;
            this.btnVerifica.Text = "Verifica";
            this.btnVerifica.UseVisualStyleBackColor = false;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // PersoanaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(852, 402);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblCarti);
            this.Controls.Add(this.lblBnAiVenit);
            this.Name = "PersoanaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Persoana";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBnAiVenit;
        private System.Windows.Forms.Label lblCarti;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.TextBox txtVerificaAutor;
        private System.Windows.Forms.TextBox txtVerificaTitlu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}