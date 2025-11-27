using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpSynthese
{
    public partial class frmAcceuil : Form
    {  

        List<Joueur> listeJoueursDispo = new List<Joueur>();
        List<Joueur> listeJoueursSelectionnes = new List<Joueur>();
        private const int NB_JOUEURS_MAX = 2;
        public frmAcceuil()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listeJoueursDispo.Add(new Joueur("Joueur 1", "Avatar1"));
            listeJoueursDispo.Add(new Joueur("Joueur 2", "Avatar2"));
            listeJoueursDispo.Add(new Joueur("Joueur 3", "Avatar3"));

            listBox_JoueurDispo.DataSource = listeJoueursDispo;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            FrmProprieteJoueur frmProprieteJoueur = new FrmProprieteJoueur();
            frmProprieteJoueur.Closed += new EventHandler(frm_Closed);
            frmProprieteJoueur.Show();
            this.Hide();

        }

        private void frm_Closed(object sender, EventArgs e)
        {
            this.Show();
        }

        private void listBox_JoueurGame_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (listBox_JoueurDispo.SelectedItem != null && listBox_JoueurGame.Items.Count < NB_JOUEURS_MAX)
            {
                Joueur joueurSelectionne = (Joueur)listBox_JoueurDispo.SelectedItem;
                listeJoueursSelectionnes.Add(joueurSelectionne);
                listeJoueursDispo.Remove(joueurSelectionne);
                listBox_JoueurDispo.DataSource = null;
                listBox_JoueurDispo.DataSource = listeJoueursDispo;
                listBox_JoueurGame.DataSource = null;
                listBox_JoueurGame.DataSource = listeJoueursSelectionnes;
            }
        }

        private void btnRetirer_Click(object sender, EventArgs e)
        {
            if (listBox_JoueurGame.SelectedItem != null)
            {
                Joueur joueurSelectionne = (Joueur)listBox_JoueurGame.SelectedItem;
                listeJoueursSelectionnes.Remove(joueurSelectionne);
                listeJoueursDispo.Add(joueurSelectionne);
                listBox_JoueurDispo.DataSource = null;
                listBox_JoueurDispo.DataSource = listeJoueursDispo;
                listBox_JoueurGame.DataSource = null;
                listBox_JoueurGame.DataSource = listeJoueursSelectionnes;
            }
        }
    }
}
