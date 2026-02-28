namespace Biblioteca
{
    partial class PersoanaFormLogiN
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
            this.txtPersoanaEmail = new System.Windows.Forms.TextBox();
            this.txtPersoanaParola = new System.Windows.Forms.TextBox();
            this.btnLoginPersoana = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introdu email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Introdu parola:";
            // 
            // txtPersoanaEmail
            // 
            this.txtPersoanaEmail.Location = new System.Drawing.Point(225, 81);
            this.txtPersoanaEmail.Name = "txtPersoanaEmail";
            this.txtPersoanaEmail.Size = new System.Drawing.Size(100, 22);
            this.txtPersoanaEmail.TabIndex = 2;
            // 
            // txtPersoanaParola
            // 
            this.txtPersoanaParola.Location = new System.Drawing.Point(225, 132);
            this.txtPersoanaParola.Name = "txtPersoanaParola";
            this.txtPersoanaParola.PasswordChar = '*';
            this.txtPersoanaParola.Size = new System.Drawing.Size(100, 22);
            this.txtPersoanaParola.TabIndex = 3;
            // 
            // btnLoginPersoana
            // 
            this.btnLoginPersoana.BackColor = System.Drawing.Color.Bisque;
            this.btnLoginPersoana.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginPersoana.Location = new System.Drawing.Point(283, 192);
            this.btnLoginPersoana.Name = "btnLoginPersoana";
            this.btnLoginPersoana.Size = new System.Drawing.Size(87, 46);
            this.btnLoginPersoana.TabIndex = 4;
            this.btnLoginPersoana.Text = "Log in";
            this.btnLoginPersoana.UseVisualStyleBackColor = false;
            this.btnLoginPersoana.Click += new System.EventHandler(this.btnLoginPersoana_Click);
            // 
            // PersoanaFormLogiN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 285);
            this.Controls.Add(this.btnLoginPersoana);
            this.Controls.Add(this.txtPersoanaParola);
            this.Controls.Add(this.txtPersoanaEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PersoanaFormLogiN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Persoana login";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PersoanaFormLogin_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersoanaEmail;
        private System.Windows.Forms.TextBox txtPersoanaParola;
        private System.Windows.Forms.Button btnLoginPersoana;
    }
}