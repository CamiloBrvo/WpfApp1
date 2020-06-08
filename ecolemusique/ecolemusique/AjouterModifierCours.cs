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
    public partial class AjouterModifierCours : Form
    {
        public AjouterModifierCours()
        {
            InitializeComponent();
            Connectionsql();
            RafraichirCombobox();
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
        public void RafraichirCombobox()
        {
            cbxSupprimezCours.Items.Clear();
            cbxSupprimezCours.Text = "";
            cbxAInstruments.Items.Clear();
            cbxAInstruments.Text = "";
            cbxATypreCours.Items.Clear();
            cbxATypreCours.Text = "";
            txbALibelleCours.Clear();
            txbAAgeMin.Clear();
            txbAAgeMax.Clear();
            txbANbPlaces.Clear();

            
            cbxMSelectCours.Items.Clear();
            cbxMInstruments.Items.Clear();
            cbxMTypeCours.Items.Clear();
            cbxMSelectCours.Text = "";
            cbxMInstruments.Text = "";
            cbxMTypeCours.Text = "";
            txbMAgeMaxi.Clear();
            txbMAgeMini.Clear();
            txbMNBPlaces.Clear();
            txbMLibelleCours.Clear();

            try
            {


                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "localhost";
                builder.IntegratedSecurity = true;
                builder.InitialCatalog = "ecoledemusique";
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("select libelle from instruments");
                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                string libelleinstruments = reader.GetString(0);
                                Console.WriteLine("{0}", libelleinstruments);
                                cbxAInstruments.Items.Add(libelleinstruments.ToString());
                                cbxMInstruments.Items.Add(libelleinstruments.ToString());
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

            try
            {


                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "localhost";
                builder.IntegratedSecurity = true;
                builder.InitialCatalog = "ecoledemusique";
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("select libelle from type_cour;");
                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                string libelletypecour = reader.GetString(0);
                                Console.WriteLine("{0}", libelletypecour);
                                cbxATypreCours.Items.Add(libelletypecour.ToString());
                                cbxMTypeCours.Items.Add(libelletypecour.ToString());

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
            try
            {


                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "localhost";
                builder.IntegratedSecurity = true;
                builder.InitialCatalog = "ecoledemusique";
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("select libelle from cours;");
                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                string libellecour = reader.GetString(0);
                                Console.WriteLine("{0}", libellecour);
                                cbxSupprimezCours.Items.Add(libellecour.ToString());
                                cbxMSelectCours.Items.Add(libellecour.ToString());

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
        public void AjoutCour()
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
                        string libelleinstruments = cbxAInstruments.Text;
                        string libelletypecour = cbxATypreCours.Text;
                        string libellecour = txbALibelleCours.Text;
                        command.CommandText = "INSERT INTO cours (libelle,agemini,agemaxi,nbplaces,id_instruments,id_type_cour) VALUES (@libellecour,'" + txbAAgeMin.Text + "','" + txbAAgeMax.Text + "','" + txbANbPlaces.Text + "',(SELECT id FROM instruments where libelle = @libelleinstruments),(SELECT id FROM type_cour where libelle = @libelletypecour));";
                        command.Parameters.AddWithValue("@libelleinstruments", libelleinstruments);
                        command.Parameters.AddWithValue("@libellecour", libellecour);
                        command.Parameters.AddWithValue("@libelletypecour", libelletypecour);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
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
        public void supprimezCour()
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
                        string libelle = cbxSupprimezCours.Text;
                        command.CommandText = "Delete from cours where libelle= @libelle;";
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
        public void selectionnerLamodifications()
        {


            cbxMInstruments.Items.Clear();
            cbxMTypeCours.Items.Clear();


            cbxMInstruments.Text = "";
            cbxMTypeCours.Text = "";

            txbMAgeMini.Clear();
            txbMAgeMaxi.Clear();
            txbMNBPlaces.Clear();
            txbMLibelleCours.Clear();

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
                        string libelle = cbxMSelectCours.Text;
                        command.CommandText = "SELECT libelle, agemini, agemaxi, nbplaces,id_instruments,id_type_cour, (SELECT libelle FROM instruments where id =  id_instruments),(SELECT libelle FROM instruments where id = id_type_cour)  FROM cours WHERE libelle = @libelle;"; ;
                        command.Parameters.AddWithValue("@libelle", libelle);
                        SqlDataReader monDR;
                        connection.Open();
                        monDR = command.ExecuteReader();
                        if (monDR.Read())
                        {
                            txbMLibelleCours.Text = monDR[0].ToString();
                            txbMAgeMini.Text = monDR[1].ToString();
                            txbMAgeMaxi.Text = monDR[2].ToString();
                            txbMNBPlaces.Text = monDR[3].ToString();
                            cbxMInstruments.Text = monDR[6].ToString();
                            cbxMTypeCours.Text = monDR[7].ToString();

                        }
                        else
                        {
                            MessageBox.Show("Identifiant non trouvé dans la BD");
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
        public void validezLamodifications()
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

                        command.CommandText = "INSERT INTO cours (libelle,agemini,agemaxi,nbplaces,id_instruments,id_type_cour) VALUES (@libellecour,'" + txbMAgeMini.Text + "','" + txbMAgeMaxi.Text + "','" + txbMNBPlaces.Text + "',(SELECT id FROM instruments where libelle = @libelleinstruments),(SELECT id FROM type_cour where libelle = @libelletypecour));";


                        string libelles = cbxMSelectCours.Text;
                        string nouvlibelle = txbMLibelleCours.Text;
                        string libelleinstruments = cbxMInstruments.Text;
                        string libelletypecour = cbxMTypeCours.Text;

                        command.CommandText = "UPDATE instruments SET libelle = @nouvlibelle , agemini = '" + txbMAgeMini.Text + "' , agemaxi = '" + txbMAgeMaxi.Text + "' , nbplaces = '" + txbMNBPlaces.Text + "', id_instruments =(SELECT id FROM instruments where libelle = @libelleinstruments), id_type_cour = (SELECT id FROM type_cour where libelle = @libelletypecour))  WHERE libelle = @libelles";
                        command.Parameters.AddWithValue("@libelles", libelles);
                        command.Parameters.AddWithValue("@nouvlibelle", nouvlibelle);
                        command.Parameters.AddWithValue("@libelleinstruments", libelleinstruments);
                        command.Parameters.AddWithValue("@libelletypecour", libelletypecour);
                        connection.Open();
                        MessageBox.Show("Connexion Ouverte");
                        command.ExecuteNonQuery();
                        MessageBox.Show("Commande OK");
                        connection.Close();
                        MessageBox.Show("Connexion Close");
                        RafraichirCombobox();

                    }
                }
            }
            catch (SqlException E)
            {
                Console.WriteLine(E.ToString());
            }

            RafraichirCombobox();

        }
        private void AjouterModifierCours_Load(object sender, EventArgs e)
        {

        }

        private void btnSupprimezCours_Click(object sender, EventArgs e)
        {
            supprimezCour();
        }

        private void btnValidezAjouts_Click(object sender, EventArgs e)
        {
            AjoutCour();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home form2 = new Home();
            form2.Show();
            this.Hide();
        }

        private void btnMSelectCours_Click(object sender, EventArgs e)
        {
            selectionnerLamodifications();
        }
    }

}
