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
    public partial class PersoanaForm : Form
    {
        private int idPersoana;
        private string email, parola;
        private DateTime dataR;
        private Timer timer;
        private string conStr = ConfigurationManager.ConnectionStrings["BibliotecaDB"].ConnectionString;
        public PersoanaForm(string email, string parola)
        {
            InitializeComponent();

            InfoPersoana(email, parola);

            idPersoana = getIdPersoana(email, parola);

            CarteImprumutata(idPersoana);

            InitializeTimer();
        }

        private void CarteImprumutata(int idPersoana)
        {
            using (var con = new SqlConnection(conStr))
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spCarteImprumutata";
                    cmd.Parameters.AddWithValue("@idPersoana", idPersoana);
                    using (var dr = cmd.ExecuteReader())
                    {
                        string titlu = "";
                        string autor = "";
                        DateTime dataimpr = new DateTime();
                        DateTime dataret = new DateTime();
                        while (dr.Read())
                        {
                            titlu = dr.GetString(dr.GetOrdinal("Titlu"));
                            autor = dr.GetString(dr.GetOrdinal("Autor"));
                            dataimpr = dr.GetDateTime(dr.GetOrdinal("DataImprumutarii"));
                            dataret = dr.GetDateTime(dr.GetOrdinal("DataReturnarii"));
                        }
                        string s = "";
                        if (!Ok(titlu, autor))
                        {
                            s = "Nu ai nici o carte imprumutata.";
                        }
                        else
                        {
                            s = "Ai imprumutat cartea " + titlu + " scrisa de " + autor + " in data de " + dataimpr.ToString() + ".\nTe rugam sa returnezi cartea in ";
                            this.dataR = dataret;
                        }
                        lblCarti.Text += s;
                    }
                }
            }
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateTimer();
        }

        private void UpdateTimer()
        {
            TimeSpan timpRamas = dataR - DateTime.Now;
            if (timpRamas.TotalSeconds > 0)
            {
                lblTimer.Text = $"{timpRamas.Days} zile, {timpRamas.Hours} ore, {timpRamas.Minutes} minute, {timpRamas.Seconds} secunde.";
            }
            else
            {
                timer.Stop();
                lblTimer.Text = "Timpul de predare a expirat.";
            }
        }

        private bool Ok(string titlu, string autor)
        {
            return (titlu != string.Empty && autor != string.Empty);
        }

        private int getIdPersoana(string email, string parola)
        {
            using (var con = new SqlConnection(conStr))
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "getIdPersoana";
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@parola", parola);
                    using (var dr = cmd.ExecuteReader())
                    {
                        int id = 0;
                        while (dr.Read())
                        {
                            id = dr.GetInt32(dr.GetOrdinal("IdPresoana"));
                        }
                        return id;
                    }
                }
            }
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            string titlu = txtVerificaTitlu.Text;
            string autor = txtVerificaAutor.Text;
            if ((titlu != string.Empty) && (autor != string.Empty))
            {
                using (var con = new SqlConnection(conStr))
                {
                    con.Open();
                    using (var cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "spVerificaDisponibilitate";
                        cmd.Parameters.AddWithValue("@titlu", titlu);
                        cmd.Parameters.AddWithValue("@autor", autor);
                        int res = cmd.ExecuteNonQuery();
                        if (res == 0)
                        {
                            MessageBox.Show("Cartea nu este disponibilia.", "Anunt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Cartea este disponibilia.", "Anunt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Datele introduse nu sunt valide.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtVerificaTitlu.Text = string.Empty;
            txtVerificaAutor.Text = string.Empty;
        }

        private void InfoPersoana(string email, string parola)
        {
            this.email = email;
            this.parola = parola;
            using (var con = new SqlConnection(conStr))
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "spInfoPersoana";
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@parola", parola);
                    using (var dr = cmd.ExecuteReader())
                    {
                        string nume = "";
                        string prenume = "";
                        while (dr.Read())
                        {
                            nume = dr.GetString(dr.GetOrdinal("Nume"));
                            prenume = dr.GetString(dr.GetOrdinal("Prenume"));
                        }
                        string s = nume + " " + prenume + "!";
                        lblBnAiVenit.Text += s;
                    }
                }
            }
        }
    }
}
