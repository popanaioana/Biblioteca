using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class AdminFormLogin : Form
    {
        private string Parola = "1234";
        public AdminFormLogin()
        {
            InitializeComponent();
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            string parola = txtParola.Text;
            if (parola == Parola)
            {
                AdminForm frm = new AdminForm();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Parola introdusa nu este corecta.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminFormLogin_Paint(object sender, PaintEventArgs e)
        {
            Image image = Image.FromFile("login2.jpg");
            Point point = new Point(0, 0);
            e.Graphics.DrawImage(image, point);
        }
    }
}
