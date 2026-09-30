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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Configuration;

namespace Biblioteca
{
    public partial class AdminForm : Form
    {
        private string conStr = ConfigurationManager.ConnectionStrings["BibliotecaDB"].ConnectionString;
        public AdminForm()
        {
            InitializeComponent();
            ViewBiblioteca();
            ViewPersoane();
        }

        private void ViewBiblioteca()
        {
            using (var con = new SqlConnection(conStr))
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM Biblioteca";
                    using (var dr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        dgvBiblioteca.DataSource = dt;
                    }
                }
            }
        }

        private void ViewPersoane()
        {
            using (var con = new SqlConnection(conStr))
            {
                con.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM Persoana";

                    using (var dr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        dgvPersoane.DataSource = dt;
                    }
                }
            }
        }

        private void btnAdaugaCarte_Click(object sender, EventArgs e)
        {
            string titlu = txtAdaugaTitlu.Text;
            string autor = txtAdaugaAutor.Text;
            if ((titlu == string.Empty) || (autor == string.Empty))
            {
                MessageBox.Show("Valorile introduse nu sunt valide.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                InsertCarte(titlu, autor);
            }
            txtAdaugaTitlu.Text = string.Empty;
            txtAdaugaAutor.Text = string.Empty;
        }

        private void InsertCarte(string titlu, string autor)
        {
            using (var con = new SqlConnection(conStr))
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spInsertCarte";
                    cmd.Parameters.AddWithValue("@titlu", titlu);
                    cmd.Parameters.AddWithValue("@autor", autor);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows != 1)
                    {
                        MessageBox.Show("Adaugarea a esuat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ViewBiblioteca();
                    }
                }
            }
        }

        private void btnAdaugaPersoana_Click(object sender, EventArgs e)
        {
            string nume = txtAdaugaNume.Text;
            string prenume = txtAdaugaPrenume.Text;
            string telefon = txtAdaugaTelefon.Text;
            string email = txtAdaugaEmail.Text;
            string parola = txtAdaugaParola.Text;
            string datanasterii = dtpAdaugaDataN.Text;
            string adresa = txtAdaugaAdresa.Text;
            if (!dateIntroduseCorect(nume, prenume, telefon, email, parola, datanasterii, adresa))
            {
                MessageBox.Show("Valorile introduse nu sunt valide.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                InsertPersoana(nume, prenume, telefon, email, parola, datanasterii, adresa);
            }
            txtAdaugaNume.Text = string.Empty;
            txtAdaugaPrenume.Text = string.Empty;
            txtAdaugaTelefon.Text = string.Empty;
            txtAdaugaEmail.Text = string.Empty;
            txtAdaugaParola.Text = string.Empty;
            txtAdaugaAdresa.Text = string.Empty;
        }

        private void InsertPersoana(string nume, string prenume, string telefon, string email, string parola, string datanasterii, string adresa)
        {
            using (var con = new SqlConnection(conStr))
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spInsertPersoana";
                    cmd.Parameters.AddWithValue("@nume", nume);
                    cmd.Parameters.AddWithValue("@prenume", prenume);
                    cmd.Parameters.AddWithValue("@telefon", telefon);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@parola", parola);
                    cmd.Parameters.AddWithValue("@datanasterii", datanasterii);
                    cmd.Parameters.AddWithValue("@adresa", adresa);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows != 1)
                    {
                        MessageBox.Show("Adaugarea a esuat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Adaugarea a reusit.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private bool dateIntroduseCorect(string nume, string prenume, string telefon, string email, string parola, string datanasterii, string adresa)
        {
            return ((nume != string.Empty) && (prenume != string.Empty) &&
                    (telefon != string.Empty) && (email != string.Empty) &&
                    (parola != string.Empty) && (datanasterii != string.Empty) &&
                    (adresa != string.Empty));
        }

        private void btnImprumuta_Click(object sender, EventArgs e)
        {
            int idcarte = 0;
            int idpersoana = 0;
            bool ok1 = int.TryParse(txtImprumutaIdCarte.Text, out idcarte);
            bool ok2 = int.TryParse(txtImprumutaIdPers.Text, out idpersoana);
            if (!ok1 || !ok2)
            {
                MessageBox.Show("Valorile introduse nu sunt valide.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int disponibilitate = 0;
            DateTime dataimprumutarii = dtpImprumuta.Value;
            DateTime datareturnarii = dataimprumutarii.AddDays(14);
            Imprumuta(idcarte, idpersoana, disponibilitate, dataimprumutarii, datareturnarii);
            txtImprumutaIdCarte.Text = string.Empty;
            txtImprumutaIdPers.Text = string.Empty;
        }

        private void Imprumuta(int idcarte, int idpersoana, int disponibilitate, DateTime dataimprumutarii, DateTime datareturnarii)
        {
            using (var con = new SqlConnection(conStr))
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spImprumuta";
                    cmd.Parameters.AddWithValue("@idCarte", idcarte);
                    cmd.Parameters.AddWithValue("@disponibilitate", disponibilitate);
                    cmd.Parameters.AddWithValue("@idPersoana", idpersoana);
                    cmd.Parameters.AddWithValue("@dataImprumutarii", dataimprumutarii);
                    cmd.Parameters.AddWithValue("@dataReturnarii", datareturnarii);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows != 1)
                    {
                        MessageBox.Show("Adaugarea a esuat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ViewBiblioteca();
                    }
                }
            }
        }

        private void btnReturneaza_Click(object sender, EventArgs e)
        {
            int idcarte = 0;
            bool ok = int.TryParse(txtReturneazaIdCarte.Text, out idcarte);
            if (!ok)
            {
                MessageBox.Show("Valorile introduse nu sunt valide.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int disponibilitate = 1;
            Returneaza(idcarte, disponibilitate);
            txtReturneazaIdCarte.Text = string.Empty;
        }

        private void Returneaza(int idcarte, int disponibilitate)
        {
            using (var con = new SqlConnection(conStr))
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spReturneaza";
                    cmd.Parameters.AddWithValue("@idCarte", idcarte);
                    cmd.Parameters.AddWithValue("@disponibilitate", disponibilitate);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows != 1)
                    {
                        MessageBox.Show("Adaugarea a esuat.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ViewBiblioteca();
                    }
                }
            }
        }
    }
}
