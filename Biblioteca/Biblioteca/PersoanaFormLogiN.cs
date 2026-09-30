using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Biblioteca
{
    public partial class PersoanaFormLogiN : Form
    {
        private string conStr = ConfigurationManager.ConnectionStrings["BibliotecaDB"].ConnectionString;
        public PersoanaFormLogiN()
        {
            InitializeComponent();
        }

        private void btnLoginPersoana_Click(object sender, EventArgs e)
        {
            string email = txtPersoanaEmail.Text;
            string parola = txtPersoanaParola.Text;
            if ((email == string.Empty) || (parola == string.Empty))
            {
                MessageBox.Show("Datele introduse nu sunt valide.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ExistaPersoana(email, parola);
        }

        private void ExistaPersoana(string email, string parola)
        {
            using (var con = new SqlConnection(conStr))
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spExistaPersoana";
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@parola", parola);
                    int res = (int)cmd.ExecuteScalar();
                    if (res != 1)
                    {
                        MessageBox.Show("Datele introduse nu sunt valide.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    PersoanaForm frm = new PersoanaForm(email, parola);
                    frm.ShowDialog();
                }
            }
        }

        private void PersoanaFormLogin_Paint(object sender, PaintEventArgs e)
        {
            Image image = Image.FromFile("login2.jpg");
            Point point = new Point(0, 0);
            e.Graphics.DrawImage(image, point);
        }
    }
}
