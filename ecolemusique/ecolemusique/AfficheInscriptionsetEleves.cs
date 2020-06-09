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
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace ecolemusique
{
    public partial class AfficheInscriptionsetEleves : Form
    {
        public AfficheInscriptionsetEleves()
        {
            InitializeComponent();
            functionRechargerTabEleves();
            functionRechargerTabInscriptions();
            functionCbCours();
            functionDgResponsables();
            functionDgResponsables2();
        }
        private void btnPagePrincipale_Click(object sender, EventArgs e)//btnBack
        {
            Home form2 = new Home();
            form2.Show();
            this.Hide();
        }

        private void dgvInscriptions_CellContentClick(object sender, DataGridViewCellEventArgs e)//dgvInscriptions
        {

        }
        private void btnRechargerTabInscriptions_Click(object sender, EventArgs e)//btnRechargerTabInscriptions
        {
            functionRechargerTabInscriptions();
        }

        private void dgvEleves_CellContentClick(object sender, DataGridViewCellEventArgs e)//dgvEleves
        {

        }

        private void btnRechargerTabEleves_Click(object sender, EventArgs e)//btnRechargerTabEleves
        {
            functionRechargerTabEleves();
        }

        private void btnValiderInscriptionByCours_Click(object sender, EventArgs e)//btnbtnValiderInscriptionByCours
        {
            functionTrierByCours();
        }

        private void btnTrierByResponsables_Click(object sender, EventArgs e)
        {
            functionTrierByResponsables();
        }

        private void btnTrierByAgeGrand_Click(object sender, EventArgs e)
        {
            functionEleveByAgeGrand();
        }

        private void btnTrierByAgePetit_Click(object sender, EventArgs e)
        {
            functionEleveByAgePetit();
        }
        private void btnResponsables2_Click(object sender, EventArgs e)
        {
            functionTrierByResponsables2();
        }

        private void functionRechargerTabEleves()//afficher eleves
        {
            try
            {
                dgvEleves.Rows.Clear();//clear le dgv

                SqlConnectionStringBuilder builder = Home.initSqlConnectionStringBuilder();
                
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
        private void functionRechargerTabInscriptions()//affiche inscriptions
        {
            try
            {
                dgvInscriptions.Rows.Clear();//clear le dgv

                SqlConnectionStringBuilder builder = Home.initSqlConnectionStringBuilder();
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT * FROM eleves WHERE id IN (SELECT id_eleves FROM inscriptions)");

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
                                string nom = reader.GetString(1);
                                string prenom = reader.GetString(2);
                                string EleveInscrit = "" + prenom + " " + nom + "";
                                //Console.WriteLine(EleveInscrit);
                                dgvInscriptions.Rows.Add(EleveInscrit);
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
        private void functionInscriptionByCours()//trier par cours
        {
            try
            {
                cbByCours.Items.Clear();//clear le cb

                SqlConnectionStringBuilder builder = Home.initSqlConnectionStringBuilder();
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT * FROM eleves WHERE id IN (SELECT id_eleves FROM inscriptions)");


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
                                string nom = reader.GetString(1);
                                string prenom = reader.GetString(2);
                                string EleveInscrit = "" + prenom + " " + nom + "";
                                //Console.WriteLine(EleveInscrit);
                                dgvInscriptions.Rows.Add(EleveInscrit);
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

        private void functionTrierByCours()//trier les inscriptions par cours
        {
            try
            {
                dgvInscriptions.Rows.Clear();

                SqlConnectionStringBuilder builder = Home.initSqlConnectionStringBuilder();
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    StringBuilder sb = new StringBuilder();
                    string libelle = cbByCours.Text;
                    sb.Append("SELECT * FROM eleves WHERE id IN (SELECT id_eleves FROM inscriptions WHERE id_cours IN (SELECT id FROM cours WHERE libelle = '" + libelle + "'))");

                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string nom = reader.GetString(1);
                                string prenom = reader.GetString(2);
                                string Eleve = "" + prenom + " " + nom + "";
                                dgvInscriptions.Rows.Add(Eleve.ToString());
                            }
                        }
                        connection.Close();
                    }
                }
            }
            catch (SqlException E)
            {
                Console.WriteLine(E.ToString());
                Console.WriteLine("ERROR Connexion");
            }
        }
        private void functionCbCours()//affiches cours
        {
            cbByCours.Items.Clear();
            cbByCours.Text = "";

            try
            {
                SqlConnectionStringBuilder builder = Home.initSqlConnectionStringBuilder();
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT * FROM cours");
                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string libelle = reader.GetString(1);
                                //Console.WriteLine("{0}", libelle);
                                cbByCours.Items.Add(libelle.ToString());
                            }
                        }
                        connection.Close();
                    }
                }
            }
            catch (SqlException E)
            {
                Console.WriteLine(E.ToString());
                Console.WriteLine("ERROR Connexion");
            }
        }
        private void functionDgResponsables()//affiche responsables
        {
            cbResponsables.Items.Clear();
            cbResponsables.Text = "";

            try
            {
                SqlConnectionStringBuilder builder = Home.initSqlConnectionStringBuilder();
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT * FROM responsables");
                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string prenom = reader.GetString(2);
                                cbResponsables.Items.Add(prenom.ToString());
                            }
                        }
                        connection.Close();
                    }
                }
            }
            catch (SqlException E)
            {
                Console.WriteLine(E.ToString());
                Console.WriteLine("ERROR Connexion");
            }
        }
        private void functionDgResponsables2()//affiche responsables
        {
            cbResponsables2.Items.Clear();
            cbResponsables2.Text = "";

            try
            {
                SqlConnectionStringBuilder builder = Home.initSqlConnectionStringBuilder();
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT * FROM responsables");
                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string prenom = reader.GetString(2);
                                cbResponsables2.Items.Add(prenom.ToString());
                            }
                        }
                        connection.Close();
                    }
                }
            }
            catch (SqlException E)
            {
                Console.WriteLine(E.ToString());
                Console.WriteLine("ERROR Connexion");
            }
        }
        private void functionTrierByResponsables()//trier les eleves par responsables
        {
            try
            {
                dgvEleves.Rows.Clear();

                SqlConnectionStringBuilder builder = Home.initSqlConnectionStringBuilder();
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    StringBuilder sb = new StringBuilder();
                    string libelle = cbResponsables.Text;
                    sb.Append("SELECT * FROM eleves WHERE id_responsables IN (SELECT id FROM responsables WHERE prenom = '" + libelle + "')");

                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string nom = reader.GetString(1);
                                string prenom = reader.GetString(2); 
                                string Eleve = "" + prenom + " " + nom + "";
                                dgvEleves.Rows.Add(Eleve.ToString());
                            }
                        }
                        connection.Close();
                    }
                }
            }
            catch (SqlException E)
            {
                Console.WriteLine(E.ToString());
                Console.WriteLine("ERROR Connexion");
            }
        }
        private void functionEleveByAgeGrand()//trier les eleves par l'age du plus grand au plus petit
        {
            try
            {
                dgvEleves.Rows.Clear();

                SqlConnectionStringBuilder builder = Home.initSqlConnectionStringBuilder();
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    StringBuilder sb = new StringBuilder();
                    string libelle = cbResponsables.Text;
                    sb.Append("SELECT * FROM eleves ORDER BY date_naiss");

                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string nom = reader.GetString(1);
                                string prenom = reader.GetString(2);
                                string Eleve = "" + prenom + " " + nom + "";
                                dgvEleves.Rows.Add(Eleve.ToString());
                            }
                        }
                        connection.Close();
                    }
                }
            }
            catch (SqlException E)
            {
                Console.WriteLine(E.ToString());
                Console.WriteLine("ERROR Connexion");
            }
        }
        private void functionEleveByAgePetit()//trier les eleves par l'age du plus petit au plus grand
        {
            try
            {
                dgvEleves.Rows.Clear();

                SqlConnectionStringBuilder builder = Home.initSqlConnectionStringBuilder();
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    StringBuilder sb = new StringBuilder();
                    string libelle = cbResponsables.Text;
                    sb.Append("SELECT * FROM eleves ORDER BY date_naiss DESC");

                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string nom = reader.GetString(1);
                                string prenom = reader.GetString(2);
                                string Eleve = "" + prenom + " " + nom + "";
                                dgvEleves.Rows.Add(Eleve.ToString());
                            }
                        }
                        connection.Close();
                    }
                }
            }
            catch (SqlException E)
            {
                Console.WriteLine(E.ToString());
                Console.WriteLine("ERROR Connexion");
            }
        }
        private void functionTrierByResponsables2()//trier les eleves par responsables
        {
            try
            {
                dgvInscriptions.Rows.Clear();
                SqlConnectionStringBuilder builder = Home.initSqlConnectionStringBuilder();
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    StringBuilder sb = new StringBuilder();
                    string libelle = cbResponsables2.Text;
                    sb.Append("SELECT * FROM eleves WHERE id IN (SELECT id_eleves FROM inscriptions WHERE id_eleves IN (SELECT id FROM eleves WHERE id_responsables IN (SELECT id FROM responsables WHERE prenom = '" + libelle + "')))");
                    
                    String sql = sb.ToString();
                    Console.WriteLine(sql);
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string nom = reader.GetString(1);
                                string prenom = reader.GetString(2);
                                string Eleve = "" + prenom + " " + nom + "";
                                dgvInscriptions.Rows.Add(Eleve.ToString());
                                Console.WriteLine(Eleve);
                            }
                        }
                        connection.Close();
                        functionDgResponsables2();
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
