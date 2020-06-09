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
//C:\Users\lance\source\repos

namespace ecolemusique
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txbMotDePasse.Text = "";
            txbMotDePasse.PasswordChar = 'x';
        }
        private void btnValider_Click(object sender, EventArgs e)//btnValider
        {
            fonctionLogin();
        }
        private void gbLogin_Enter(object sender, EventArgs e)//gbLogin
        {

        }
        private void txbIdentifiant_TextChanged(object sender, EventArgs e)//txbIdentifiant
        {

        }
        private void txbMotDePasse_TextChanged(object sender, EventArgs e)//txbMotDePasse
        {
            
        }

        private void fonctionLogin()
        {

            Console.WriteLine("identifiant(mail) quand bouton click :" + this.txbIdentifiant.Text);
            Console.WriteLine("pwd(pwd) quand bouton click :" + this.txbMotDePasse.Text);

            Console.WriteLine("InitConnection");
            try
            {
                SqlConnectionStringBuilder builder = Home.initSqlConnectionStringBuilder();

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT * FROM utilisateur WHERE email = '" + this.txbIdentifiant.Text + "' AND mdp = '" + this.txbMotDePasse.Text + "'");

                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        Console.WriteLine("\nQuery :" + sql + " should be executed");
                        connection.Open();
                        Console.WriteLine("Connexion opened to database");

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            Console.WriteLine("\nExecute Query :" + sql);
                            if (reader.Read())
                            {
                                MessageBox.Show("Connexion réussie, changement de page");
                                Home form2 = new Home();
                                form2.Show();
                                this.Hide();
                                //this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Le mot de passe ou l'email n'est pas correct");
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

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            txbIdentifiant.Text = "admin@admin.com";
            txbMotDePasse.Text = "admin";
        }
    }
}
