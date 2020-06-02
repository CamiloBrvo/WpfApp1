using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ecolemusique
{
    public partial class AfficheInscriptionsetEleves : Form
    {
        public AfficheInscriptionsetEleves()
        {
            InitializeComponent();
            functionRechargerTabEleves();
        }
        private void btnPagePrincipale_Click(object sender, EventArgs e)//btnBack
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void dgvInscriptions_CellContentClick(object sender, DataGridViewCellEventArgs e)//dgvInscriptions
        {

        }
        private void btnRechargerTabInscriptions_Click(object sender, EventArgs e)//btnRechargerTabInscriptions
        {

        }

        private void dgvEleves_CellContentClick(object sender, DataGridViewCellEventArgs e)//dgvEleves
        {

        }

        private void btnRechargerTabEleves_Click(object sender, EventArgs e)//btnRechargerTabEleves
        {
            functionRechargerTabEleves();
        }

        private void functionRechargerTabEleves()
        {
            try
            {
                dgvEleves.Rows.Clear();//clear le dgv

                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "localhost";
                builder.IntegratedSecurity = true;
                builder.InitialCatalog = "ecoledemusique";
                Console.WriteLine("Connexion info created : " + builder.ConnectionString);

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT * FROM eleves");

                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        Console.WriteLine("\nQuery :" + sql + " should be executed");
                        connection.Open();
                        Console.WriteLine("Connexion opened to database");

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            Console.WriteLine("\nExecute Query :" + sql);
                            while (reader.Read())
                            {
                                string nomEleve = reader.GetString(1);
                                string prenomEleve = reader.GetString(2);
                                string Eleve = "" + prenomEleve + " " + nomEleve + "";
                                Console.WriteLine(Eleve);
                                dgvEleves.Rows.Add(Eleve);
                            }
                        }

                        connection.Close();
                        Console.WriteLine("Connexion closed to database");
                    }
                }
            }
            catch (SqlException E)
            {
                Console.WriteLine(E.ToString());
                Console.WriteLine("ERROR Connexion");
            }
        }
        private void functionRechargerTabInscriptions()
        {
            try
            {
                dgvInscriptions.Rows.Clear();//clear le dgv

                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "localhost";
                builder.IntegratedSecurity = true;
                builder.InitialCatalog = "ecoledemusique";
                Console.WriteLine("Connexion info created : " + builder.ConnectionString);

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT * FROM inscriptions");

                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        Console.WriteLine("\nQuery :" + sql + " should be executed");
                        connection.Open();
                        Console.WriteLine("Connexion opened to database");

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            Console.WriteLine("\nExecute Query :" + sql);
                            while (reader.Read())
                            {
                                string nomEleve = reader.GetString(1);
                                string prenomEleve = reader.GetString(2);
                                string Eleve = "" + prenomEleve + " " + nomEleve + "";
                                Console.WriteLine(Eleve);
                                dgvEleves.Rows.Add(Eleve);
                            }
                        }

                        connection.Close();
                        Console.WriteLine("Connexion closed to database");
                    }
                }
            }
            catch (SqlException E)
            {
                Console.WriteLine(E.ToString());
                Console.WriteLine("ERROR Connexion");
            }
        }
    }
}
