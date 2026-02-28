namespace Biblioteca
{
    partial class AdminFormLogin
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
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnLoginAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introdu parola:";
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(167, 99);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(147, 22);
            this.txtParola.TabIndex = 1;
            // 
            // btnLoginAdmin
            // 
            this.btnLoginAdmin.BackColor = System.Drawing.Color.Bisque;
            this.btnLoginAdmin.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginAdmin.Location = new System.Drawing.Point(319, 154);
            this.btnLoginAdmin.Name = "btnLoginAdmin";
            this.btnLoginAdmin.Size = new System.Drawing.Size(95, 41);
            this.btnLoginAdmin.TabIndex = 2;
            this.btnLoginAdmin.Text = "Log in";
            this.btnLoginAdmin.UseVisualStyleBackColor = false;
            this.btnLoginAdmin.Click += new System.EventHandler(this.btnLoginAdmin_Click);
            // 
            // AdminFormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 243);
            this.Controls.Add(this.btnLoginAdmin);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.label1);
            this.Name = "AdminFormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin login";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AdminFormLogin_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnLoginAdmin;
    }
}