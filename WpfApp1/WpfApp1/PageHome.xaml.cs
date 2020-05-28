using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour PageHome.xaml
    /// </summary>
    public partial class PageHome : Window
    {
        public PageHome()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)//btnQuitter
        {
            //MainWindow mainwindow = new MainWindow();
            //mainwindow.Show();
            //this.Hide();
            this.Close();
        }

        private void BtnInstruments_Click(object sender, RoutedEventArgs e)//btnInstruments
        {

        }

        private void BtnQuotienFamilial_Click(object sender, RoutedEventArgs e)//btnQuotienFamilial
        {

        }

        private void BtnCouts_Click(object sender, RoutedEventArgs e)//btnCouts
        {
            fonctionUpdateResponsables();
        }

        private void BtnCours_Click(object sender, RoutedEventArgs e)//btnCours
        {
            fonctionAddResponsable();
        }

        private void BtnInscription_Eleves_Click(object sender, RoutedEventArgs e)//btnInscription_Eleves
        {
            fonctionAddUtilisateur();
        }

        private void fonctionUpdateResponsables()
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
                    using(SqlCommand command = connection.CreateCommand())
                    {
                        string mdp = "motdepasse";
                        command.CommandText = "UPDATE utilisateur SET mdp = @mdp";
                        command.Parameters.AddWithValue("@mdp", mdp);

                        connection.Open();
                        MessageBox.Show("Connexion Ouverte");
                        command.ExecuteNonQuery();
                        MessageBox.Show("Commande OK");
                        connection.Close();
                        MessageBox.Show("Connexion Close");
                    }
                }
            }
            catch (SqlException E)
            {
                Console.WriteLine(E.ToString());
                Console.WriteLine("ERROR Connexion");
            }
        }
        private void fonctionAddResponsable()
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
                        string nom = "Paul";
                        string prenom = "Jean";
                        string adresse = "5 rue du Grand Bateau";
                        string ville = "Marseille";
                        int cp = 13000;
                        string mail = "jpaul@gmail.com";
                        int qf = 50;
                        int tel1 = 0101010101;
                        int tel2 = 0101010101;
                        int tel3 = 0101010101;

                        command.CommandText = "INSERT INTO responsables VALUES (@nom,@prenom,@adresse,@ville,@cp,@mail,@qf,@tel1,@tel2,@tel3)";
                        command.Parameters.AddWithValue("@nom", nom);
                        command.Parameters.AddWithValue("@prenom", prenom);
                        command.Parameters.AddWithValue("@adresse", adresse);
                        command.Parameters.AddWithValue("@ville", ville);
                        command.Parameters.AddWithValue("@cp", cp);
                        command.Parameters.AddWithValue("@mail", mail);
                        command.Parameters.AddWithValue("@qf", qf);
                        command.Parameters.AddWithValue("@tel1", tel1);
                        command.Parameters.AddWithValue("@tel2", tel2);
                        command.Parameters.AddWithValue("@tel3", tel3);

                        connection.Open();
                        MessageBox.Show("Connexion Ouverte");
                        command.ExecuteNonQuery();
                        MessageBox.Show("Commande OK");
                        connection.Close();
                        MessageBox.Show("Connexion Close");
                    }
                }
            }
            catch (SqlException E)
            {
                Console.WriteLine(E.ToString());
                Console.WriteLine("ERROR Connexion");
            }
        }
        private void fonctionAddUtilisateur()
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
                        string mdp = "motdepasse";
                        int id_r = 3;
                        command.CommandText = "INSERT INTO utilisateur VALUES (@mdp,@id_r)";
                        command.Parameters.AddWithValue("@mdp", mdp);
                        command.Parameters.AddWithValue("@id_r", id_r);

                        connection.Open();
                        MessageBox.Show("Connexion Ouverte");
                        command.ExecuteNonQuery();
                        MessageBox.Show("Commande OK");
                        connection.Close();
                        MessageBox.Show("Connexion Close");
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
