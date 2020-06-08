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
    public partial class AjouterModifierInstruments : Form
    {
        public AjouterModifierInstruments()
        {
            InitializeComponent();
            rafraichirCombobox();
        }
        private void btnHome_Click(object sender, EventArgs e)//btn pour retourner a la page Home
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        private void btnAjoutInstrument_Click(object sender, EventArgs e)//btnAjouterInstrument
        {
            ajoutIstruments();
        }

        private void btnSupprimerInstrument_Click(object sender, EventArgs e)//btnPourSupprimerUnInstrument
        {
            supprimerInstruments();
        }

        private void btnModifierInstrument_Click(object sender, EventArgs e)//btnModifierInstrument
        {
            modiffierInstruments();
        }
        private void rafraichirCombobox()// fonction pour rafraichirCombobox
        {
            cbSupprimerInstrument.Items.Clear();
            cbSupprimerInstrument.Text = "";
            cbModifierInstrument.Items.Clear();
            cbModifierInstrument.Text = "";
            txbModifierInstrument.Clear();
            txbAjoutInstrument.Clear();

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
                                cbSupprimerInstrument.Items.Add(libelle.ToString());
                                cbModifierInstrument.Items.Add(libelle.ToString());
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

        private void ajoutIstruments()//fonction pour ajouter un instrument
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
                        string libelle = txbAjoutInstrument.Text;
                        command.CommandText = "INSERT INTO instruments (libelle) VALUES (@libelle);";
                        command.Parameters.AddWithValue("@libelle", libelle);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Instrument créer");
                    }
                }
            }
            catch (SqlException E)
            {
                Console.WriteLine(E.ToString());
                Console.WriteLine("ERROR Connexion");
            }
            rafraichirCombobox();
        }

        private void supprimerInstruments()//fonction pour supprimer un instrument
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
                        string libelle = cbSupprimerInstrument.Text;
                        command.CommandText = "DELETE FROM instruments WHERE libelle = @libelle;";
                        command.Parameters.AddWithValue("@libelle", libelle);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Instrument supprimer");
                    }
                }
            }
            catch (SqlException E)
            {
                Console.WriteLine(E.ToString());
                Console.WriteLine("ERROR Connexion");
            }
            rafraichirCombobox();
        }

        private void modiffierInstruments()
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

                        string libelles = cbModifierInstrument.Text;
                        string nouvlibelle = txbModifierInstrument.Text;

                        command.CommandText = "UPDATE instruments SET libelle = @nouvlibelle WHERE libelle = @libelles";
                        command.Parameters.AddWithValue("@libelles", libelles);
                        command.Parameters.AddWithValue("@nouvlibelle", nouvlibelle);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Instrument modifier");
                    }
                }
            }
            catch (SqlException E)
            {
                Console.WriteLine(E.ToString());
                Console.WriteLine("ERROR Connexion");
            }
            rafraichirCombobox();
        }
    }
}
