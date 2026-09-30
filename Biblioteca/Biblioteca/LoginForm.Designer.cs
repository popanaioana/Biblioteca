namespace Biblioteca
{
    partial class LoginForm
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
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnPersoana = new System.Windows.Forms.Button();
            this.btnPers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logheaza-te";
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Bisque;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(141, 188);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(90, 45);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnPersoana
            // 
            this.btnPersoana.BackColor = System.Drawing.Color.Bisque;
            this.btnPersoana.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersoana.Location = new System.Drawing.Point(368, 187);
            this.btnPersoana.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPersoana.Name = "btnPersoana";
            this.btnPersoana.Size = new System.Drawing.Size(74, 46);
            this.btnPersoana.TabIndex = 2;
            this.btnPersoana.Text = "Persoana";
            this.btnPersoana.UseVisualStyleBackColor = false;
            // 
            // btnPers
            // 
            this.btnPers.BackColor = System.Drawing.Color.Bisque;
            this.btnPers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPers.Location = new System.Drawing.Point(352, 187);
            this.btnPers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPers.Name = "btnPers";
            this.btnPers.Size = new System.Drawing.Size(90, 46);
            this.btnPers.TabIndex = 3;
            this.btnPers.Text = "Persoana";
            this.btnPers.UseVisualStyleBackColor = false;
            this.btnPers.Click += new System.EventHandler(this.btnPers_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 349);
            this.Controls.Add(this.btnPers);
            this.Controls.Add(this.btnPersoana);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnPersoana;
        private System.Windows.Forms.Button btnPers;
    }
}

