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
        private const int NB_JOUEURS = 2;
        private const string TIP_NB_JOUEURS = "Ce jeu se joue à 2 seulement.";
        public frmAcceuil()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Joueur joueur1 = new Joueur("Alice", "avatar1");
            Joueur joueur2 = new Joueur("Bob", "avatar2");
            listeJoueursDispo.Add(joueur1);
            listeJoueursDispo.Add(joueur2);
            listBox_JoueurDispo.DataSource = listeJoueursDispo;

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            FrmProprieteJoueur frmProprieteJoueur = new FrmProprieteJoueur(listeJoueursDispo);
            frmProprieteJoueur.Closed += new EventHandler(frm_Closed);
            frmProprieteJoueur.Show();
            this.Hide();

        }

        private void frm_Closed(object sender, EventArgs e)
        {
            this.Show();
            listBox_JoueurDispo.DataSource = null;
            listBox_JoueurDispo.DataSource = listeJoueursDispo;
        }

        private void listBox_JoueurGame_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (listBox_JoueurDispo.SelectedItem != null && listBox_JoueurGame.Items.Count < NB_JOUEURS)
            {
                Joueur joueurSelectionne = (Joueur)listBox_JoueurDispo.SelectedItem;
                listeJoueursSelectionnes.Add(joueurSelectionne);
                listeJoueursDispo.Remove(joueurSelectionne);
                listBox_JoueurDispo.DataSource = null;
                listBox_JoueurDispo.DataSource = listeJoueursDispo;
                listBox_JoueurGame.DataSource = null;
                listBox_JoueurGame.DataSource = listeJoueursSelectionnes;
                toolTip_NbJoueur.SetToolTip(btnAjouter, TIP_NB_JOUEURS);
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

        private void btnDemarer_Click(object sender, EventArgs e)
        {
            
            if (listeJoueursSelectionnes.Count == NB_JOUEURS)
            {
                FrmJeu frmJeu = new FrmJeu(listeJoueursSelectionnes);
                frmJeu.Closed += new EventHandler(frm_Closed);
                frmJeu.Show();
                this.Hide();

            }
            else
            {
                errorProvider_NbJoueur.SetError(btnDemarer, TIP_NB_JOUEURS);
            }
        }
    }
}
