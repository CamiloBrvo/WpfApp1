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

namespace Ecolemusique
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Connectionsql();
            RafraichirCombobox();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            Connectionsql();
            RafraichirCombobox();

        }


        private void btnValidezAjoutsI_Click(object sender, EventArgs e)
        {
            AjoutIstruments();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblT2_Click(object sender, EventArgs e)
        {

        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }



        public void Connectionsql()
        {
            Console.WriteLine("InitConnection");
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "localhost";
                builder.IntegratedSecurity = true;
                builder.InitialCatalog = "ecoledemusique";
                Console.WriteLine("Connexion info created : " + builder.ConnectionString);

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT * FROM instruments");
                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        Console.WriteLine("Connexion opened to database");
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            Console.WriteLine("\nExecute Query :" + sql);
                            while (reader.Read())
                            {
                                Console.WriteLine("{0}id {1}libelle ", reader.GetInt32(0), reader.GetString(1));
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


        public void AjoutIstruments()
        {

            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "localhost";
                builder.IntegratedSecurity = true;
                builder.InitialCatalog = "ecoledemusique";
                Console.WriteLine("Connexion info created : " + builder.ConnectionString);

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        string libelle = textBox1.Text;
                        command.CommandText = "INSERT INTO instruments (libelle) VALUES (@libelle);";
                        command.Parameters.AddWithValue("@libelle", libelle);

                        connection.Open();

                        command.ExecuteNonQuery();

                        connection.Close();
                        textBox1.Clear();
                    }
                }
            }
            catch (SqlException E)
            {
                Console.WriteLine(E.ToString());
                Console.WriteLine("ERROR Connexion");
            }
            RafraichirCombobox();
        }


        private void btnValidezModifI_Click(object sender, EventArgs e)
        {
            ModiffierInstruments();


        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            SupprimerInstruments();
        }
        public void RafraichirCombobox()
        {
            cbxsuprimerI.Items.Clear();
            cbxIstrument.Items.Clear();
            try
            {


                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "localhost";
                builder.IntegratedSecurity = true;
                builder.InitialCatalog = "ecoledemusique";
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("select * from instruments");
                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                string libelle = reader.GetString(1);
                                Console.WriteLine("{0}", libelle);
                                cbxIstrument.Items.Add(libelle.ToString());
                                cbxsuprimerI.Items.Add(libelle.ToString());
                            }
                        }

                        connection.Close();

                    }

                }
            }






            catch (SqlException E)
            {
                Console.WriteLine(E.ToString());
                Console.WriteLine("erreur connection");
            }


        }
        public void SupprimerInstruments()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "localhost";
                builder.IntegratedSecurity = true;
                builder.InitialCatalog = "ecoledemusique";
                Console.WriteLine("Connexion info created : " + builder.ConnectionString);

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        string libelle = cbxsuprimerI.Text;
                        command.CommandText = "Delete from instruments where libelle= @libelle;";
                        command.Parameters.AddWithValue("@libelle", libelle);

                        connection.Open();

                        command.ExecuteNonQuery();

                        connection.Close();

                    }
                }
            }
            catch (SqlException E)
            {
                Console.WriteLine(E.ToString());
                Console.WriteLine("ERROR Connexion");
            }


            RafraichirCombobox();
        }
        public void ModiffierInstruments()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "localhost";
                builder.IntegratedSecurity = true;
                builder.InitialCatalog = "ecoledemusique";
                Console.WriteLine("Connexion info created : " + builder.ConnectionString);
                
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    
                    using (SqlCommand command = connection.CreateCommand())
                    {
                       
                        string libelles = cbxIstrument.Text;
                        string nouvlibelle = txbmodificationI.Text;

                        command.CommandText = "UPDATE instruments SET libelle = @nouvlibelle WHERE libelle = @libelles";
                        command.Parameters.AddWithValue("@libelles", libelles);
                        command.Parameters.AddWithValue("@nouvlibelle", nouvlibelle);
                        connection.Open();
                        MessageBox.Show("Connexion Ouverte");
                        command.ExecuteNonQuery();
                        MessageBox.Show("Commande OK");
                        connection.Close();
                        MessageBox.Show("Connexion Close");
                        RafraichirCombobox();
                        txbmodificationI.Clear();
                    }
                }
            }
            catch (SqlException E)
            {
                Console.WriteLine(E.ToString());



               
            }
            

        }
    }
}
