using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)//btnConnexion
        {
            fonctionLogin();
        }

       
        

        private void TextBox_MDP_TextChanged(object sender, TextChangedEventArgs e)
        {
            Console.WriteLine("GUI identifiant(mail)" + this.txbIdentifiant_GUI.Text);
            Console.WriteLine("GUI pwd(pwd)" + this.txbMotDePasse_GUI.Text);
        }

        private void TxbMotDePasse_GUI_TextInput(object sender, TextCompositionEventArgs e)
        {
            
        }

        private void TextBoxIdentifiant_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        /*
         *  ublic char PasswordChar{ get; set; }

        public void createPasswordTextBox()
        {
            txbMotDePasse_GUI.Text = "";
            txbMotDePasse_GUI.PasswordChar = "*";
        }
        */
        private void fonctionLogin()
        {

            Console.WriteLine("GUI identifiant(mail) quand bouton click :" + this.txbIdentifiant_GUI.Text);
            Console.WriteLine("GUI pwd(pwd) quand bouton click :" + this.txbMotDePasse_GUI.Text);

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
                    sb.Append("SELECT *  FROM responsables WHERE email = '" + this.txbIdentifiant_GUI.Text + "'");

                    int id_responsables = 0;
                    string mail = "mail";

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
                                id_responsables = reader.GetInt32(0);
                                mail = reader.GetString(6);

                                Console.WriteLine("Le mail correct est : {0}", mail);
                            }
                        }

                        connection.Close();
                        Console.WriteLine("Connexion closed to database");
                    }
                    if (mail != "mail")
                    {
                        MessageBox.Show("Le mail est correct");
                        StringBuilder sb2 = new StringBuilder();
                        sb2.Append("SELECT mdp FROM utilisateur WHERE id_responsables = '" + id_responsables + "'");

                        String sql2 = sb2.ToString();
                        using (SqlCommand command = new SqlCommand(sql2, connection))
                        {
                            Console.WriteLine("\nQuery :" + sql2 + " should be executed");
                            connection.Open();
                            Console.WriteLine("Connexion opened to database");
                            using (SqlDataReader reader2 = command.ExecuteReader())
                            {
                                Console.WriteLine("\nExecute Query :" + sql2);
                                while (reader2.Read())
                                {
                                    Console.WriteLine("Le mot de passe correct est : {0}", reader2.GetString(0));
                                    if (txbMotDePasse_GUI.Text == reader2.GetString(0))
                                    {
                                        MessageBox.Show("Le mdp est correct");

                                        PageHome home = new PageHome();
                                        home.Show();
                                        //this.Hide();
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Le mdp est faux");
                                    }
                                }
                            }
                            connection.Close();
                            Console.WriteLine("Connexion closed to database");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Le mail n'est pas correct");
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
