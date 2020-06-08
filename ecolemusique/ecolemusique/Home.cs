using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ecolemusique
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)//btnQuitter
        {
            Application.Exit();
        }

        private void btnAjouterModifierInstrument_Click(object sender, EventArgs e)//btnAjouterModifierInstrument
        {
            AjouterModifierInstruments ajouterModifierInstruments = new AjouterModifierInstruments();
            ajouterModifierInstruments.Show();
            this.Hide();
        }

        private void btnSaisieCouts_Click(object sender, EventArgs e)//btnSaisieCouts
        {

        }

        private void btnModifierAjouterQF_Click(object sender, EventArgs e)//btnModifierAjouterQF
        {

        }

        private void btnModifierAjouterCours_Click(object sender, EventArgs e)//btnModifierAjouterCours
        {
            AjouterModifierCours ajouterModifierCours = new AjouterModifierCours();
            ajouterModifierCours.Show();
            this.Hide();
        }

        private void btnAffichageInscriptionsetEleves_Click(object sender, EventArgs e)//btnAffichageInscriptionsetEleves
        {
            AfficheInscriptionsetEleves afficheInscriptionsetEleves = new AfficheInscriptionsetEleves();
            afficheInscriptionsetEleves.Show();
            this.Hide();
        }
    }
}
