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

        }

        private void BtnCours_Click(object sender, RoutedEventArgs e)//btnCours
        {

        }

        private void BtnInscription_Eleves_Click(object sender, RoutedEventArgs e)//btnInscription_Eleves
        {

        }
    }
}
