using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {
            Image image = Image.FromFile("login.jpg");
            Point point = new Point(0, 0);
            e.Graphics.DrawImage(image, point);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminFormLogin frm = new AdminFormLogin();
            frm.ShowDialog();
        }

        private void btnPersoana_Click(object sender, EventArgs e)
        {
            PersoanaFormLogiN frm = new PersoanaFormLogiN();
            frm.ShowDialog();
        }

        private void btnPers_Click(object sender, EventArgs e)
        {
            PersoanaFormLogiN frm = new PersoanaFormLogiN();
            frm.ShowDialog();
        }
    }
}
