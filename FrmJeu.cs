using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace tpSynthese
{
    public partial class FrmJeu : Form
    {
        private const string TIP_BRASSER = "Vous ne pouvez plus brasser, choississez un pointage.";
        private const int MAX_TOURS_YAHTZEE = 3;

        private bool phaseYahtzeeActive = false;
        private int toursYahtzeeJoues = 0;
        private List<Joueur> listeJoueurs;
        private Thread threadDe1, threadDe2, threadDe3, threadDe4, threadDe5;
        private volatile bool enExecutionDe1, enExecutionDe2, enExecutionDe3, enExecutionDe4, enExecutionDe5;
        private Random aleatoireDe1, aleatoireDe2, aleatoireDe3, aleatoireDe4, aleatoireDe5;
        private int[] valeursDes = new int[5];
        private int lancersRestants = 3;
        Partie partie;
        private bool deSelect1, deSelect2, deSelect3, deSelect4, deSelect5;

        List<Label> listeLabels;

        string fichierSon = Application.StartupPath + "\\son\\brasse.wav";

        SoundPlayer lecteur = new SoundPlayer();


        private void pictureBox_de4_Click(object sender, EventArgs e)
        {
            deSelect4 = true;
            pictureBox_de4.BorderStyle = BorderStyle.FixedSingle;
            btnDeselec.Enabled = true;
        }

        private void btnDeselec_Click(object sender, EventArgs e)
        {
            deSelect1 = false;
            deSelect2 = false;
            deSelect3 = false;
            deSelect4 = false;
            deSelect5 = false;
            pictureBox_de1.BorderStyle = BorderStyle.None;
            pictureBox_de2.BorderStyle = BorderStyle.None;
            pictureBox_de3.BorderStyle = BorderStyle.None;
            pictureBox_de4.BorderStyle = BorderStyle.None;
            pictureBox_de5.BorderStyle = BorderStyle.None;
            btnDeselec.Enabled = false;
        }

        private void pictureBox_de5_Click_1(object sender, EventArgs e)
        {
            deSelect5 = true;
            pictureBox_de5.BorderStyle = BorderStyle.FixedSingle;
            btnDeselec.Enabled = true;
        }

        private void pictureBox_de3_Click(object sender, EventArgs e)
        {
            deSelect3 = true;
            pictureBox_de3.BorderStyle = BorderStyle.FixedSingle;
            btnDeselec.Enabled = true;
        }

        private void pictureBox_de2_Click(object sender, EventArgs e)
        {
            deSelect2 = true;
            pictureBox_de2.BorderStyle = BorderStyle.FixedSingle;
            btnDeselec.Enabled = true;
        }

        private void lblUnJ1_Click(object sender, EventArgs e)
        {
            lblUnJ1.ForeColor = Color.Black;
            lblUnJ1.Enabled = false;
            terminerTour();
        }

        private void lblUnJ2_Click(object sender, EventArgs e)
        {
             lblUnJ2.ForeColor = Color.Black;
             lblUnJ2.Enabled = false;
             terminerTour();
        }

        private void lblDeuxJ1_Click(object sender, EventArgs e)
        {
            lblDeuxJ1.ForeColor = Color.Black;
            lblDeuxJ1.Enabled = false; 
            terminerTour();
        }

        private void lblDeuxJ2_Click(object sender, EventArgs e)
        {
            lblDeuxJ2.ForeColor = Color.Black;
            lblDeuxJ2.Enabled = false;
            terminerTour();
        }

        private void lblTroisJ1_Click(object sender, EventArgs e)
        {
            lblTroisJ1.ForeColor = Color.Black;
            lblTroisJ1.Enabled = false;
            terminerTour();
        }

        private void lblTroisJ2_Click(object sender, EventArgs e)
        {
            lblTroisJ2.ForeColor = Color.Black;
            lblTroisJ2.Enabled = false;
            terminerTour();
        }

        private void lblQuatreJ1_Click(object sender, EventArgs e)
        {
            lblQuatreJ1.ForeColor = Color.Black;
            lblQuatreJ1.Enabled = false;
            terminerTour();
        }

        private void lblQuatreJ2_Click(object sender, EventArgs e)
        {
            lblQuatreJ2.ForeColor = Color.Black;
            lblQuatreJ2.Enabled = false;
            terminerTour();

        }

        private void lblCinqJ1_Click(object sender, EventArgs e)
        {    
            lblCinqJ1.ForeColor = Color.Black;
            lblCinqJ1.Enabled = false;
            terminerTour();
        }

        private void lblCinqJ2_Click(object sender, EventArgs e)
        {
            lblCinqJ2.ForeColor = Color.Black;
            lblCinqJ2.Enabled = false;
            terminerTour();
        }

        private void lblSixJ1_Click(object sender, EventArgs e)
        {
            lblSixJ1.ForeColor = Color.Black;
            lblSixJ1.Enabled = false;
            terminerTour();
        }

        private void lblSixJ2_Click(object sender, EventArgs e)
        {  
            lblSixJ2.ForeColor = Color.Black;
            lblSixJ2.Enabled = false;
            terminerTour();
        }

        private void lblYatJ1_Click(object sender, EventArgs e)
        {
            lblYatJ1.ForeColor = Color.Black;
            lblYatJ1.Enabled = false;
            terminerTour();
        }

        

        public FrmJeu(List<Joueur> listeJoueur)
        {
            InitializeComponent();
            aleatoireDe1 = new Random();
            aleatoireDe2 = new Random(Guid.NewGuid().GetHashCode());
            aleatoireDe3 = new Random(Guid.NewGuid().GetHashCode());
            aleatoireDe4 = new Random(Guid.NewGuid().GetHashCode());
            aleatoireDe5 = new Random(Guid.NewGuid().GetHashCode());
            this.listeJoueurs = listeJoueur;
            this.partie = new Partie(this.listeJoueurs);

            listeLabels = new List<Label> { lblUnJ1, lblDeuxJ1, lblTroisJ1, lblQuatreJ1, lblCinqJ1, lblSixJ1, lblUnJ2, lblDeuxJ2, lblTroisJ2, lblQuatreJ2, lblCinqJ2, lblSixJ2, lblYatJ1, lblYatJ2 };

        }

        private void FrmJeu_Load(object sender, EventArgs e)
        {
            pictureBox_de1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_de2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_de3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_de4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_de5.SizeMode = PictureBoxSizeMode.Zoom;

            lblJ1.Text = listeJoueurs[0].Nom;
            lblJ2.Text = listeJoueurs[1].Nom;
            lblNom1.Text = listeJoueurs[0].Nom;
            lblNom2.Text = listeJoueurs[1].Nom;
            if (File.Exists(Application.StartupPath + "\\avatar\\" + listeJoueurs[0].Avatar + ".png"))
            {
                pictureBox_J1.Image = Image.FromFile(Application.StartupPath + "\\avatar\\" + listeJoueurs[0].Avatar + ".png");
                pictureBox_J1.SizeMode = PictureBoxSizeMode.Zoom;

            }

            if (File.Exists(Application.StartupPath + "\\avatar\\" + listeJoueurs[1].Avatar + ".png"))
            {
                pictureBox_J2.Image = Image.FromFile(Application.StartupPath + "\\avatar\\" + listeJoueurs[1].Avatar + ".png");
                pictureBox_J2.SizeMode = PictureBoxSizeMode.Zoom;

            }

            mettreAJourAffichageTour();

            foreach (Label lbl in listeLabels)
            {
                lbl.Visible = false;
                lbl.Enabled = false;
                lbl.ForeColor = Color.Pink;
            }

        }

        private void lblYatJ2_Click(object sender, EventArgs e)
        {
            lblYatJ2.ForeColor = Color.Black;
            lblYatJ2.Enabled = false;
            terminerTour();
        }

        private void contextMenuStrip_Jeu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void nvPartietoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NouvellePartie();
        }

        private void RetourtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProJoueurtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProprieteJoueur frmProprieteJoueur = new FrmProprieteJoueur(listeJoueurs);
            frmProprieteJoueur.ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void btnArreter_Click(object sender, EventArgs e)
        {
            enExecutionDe1 = false;
            enExecutionDe2 = false;
            enExecutionDe3 = false;
            enExecutionDe4 = false;
            enExecutionDe5 = false;
            btnBrasser.Enabled = true;
            afficherScore();

            lecteur.Stop();
        }
        private void pictureBox_de1_Click(object sender, EventArgs e)
        {
            deSelect1 = true;
            pictureBox_de1.BorderStyle = BorderStyle.FixedSingle;
            btnDeselec.Enabled = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (lancersRestants > 0)
            {
                toolTip_Tour.SetToolTip(btnBrasser, null);
                lancersRestants--;
                btnBrasser.Enabled = false; // Désactiver pendant le roulement
                btnArreter.Enabled = true;

                if (threadDe1 == null || !threadDe1.IsAlive && !deSelect1)
                {
                    enExecutionDe1 = true;

                    threadDe1 = new Thread(executionLancerDe1);

                    threadDe1.IsBackground = true;

                    threadDe1.Start();
                }

                if (threadDe2 == null || !threadDe2.IsAlive && !deSelect2)
                {
                    enExecutionDe2 = true;


                    threadDe2 = new Thread(executionLancerDe2);

                    threadDe2.IsBackground = true;

                    threadDe2.Start();
                }

                if (threadDe3 == null || !threadDe3.IsAlive && !deSelect3)
                {
                    enExecutionDe3 = true;
                    threadDe3 = new Thread(executionLancerDe3);
                    threadDe3.IsBackground = true;
                    threadDe3.Start();
                }

                if (threadDe4 == null || !threadDe4.IsAlive && !deSelect4)
                {
                    enExecutionDe4 = true;
                    threadDe4 = new Thread(executionLancerDe4);
                    threadDe4.IsBackground = true;
                    threadDe4.Start();
                }

                if (threadDe5 == null || !threadDe5.IsAlive && !deSelect5)
                {
                    enExecutionDe5 = true;
                    threadDe5 = new Thread(executionLancerDe5);
                    threadDe5.IsBackground = true;
                    threadDe5.Start();
                }

                
                if (File.Exists(fichierSon))
                {
                    lecteur.SoundLocation = fichierSon;
                    lecteur.Play();
                }
            }
            else
            {
                toolTip_Tour.SetToolTip(btnBrasser, TIP_BRASSER);
                afficherScore();
            }
        }



        private void executionLancerDe1()
        {
            try
            {
                while (enExecutionDe1)
                {
                    int nombreDuDe = aleatoireDe1.Next(1, 7);
                    valeursDes[0] = nombreDuDe;
                    this.Invoke(new Action(() =>
                    {
                        changerImageDe(pictureBox_de1, nombreDuDe);
                    }));
                    Thread.Sleep(100);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur dans executionLancerDe1: " + ex.Message);
            }
        }


        private void executionLancerDe2()
        {
            try {
                while (enExecutionDe2)
                {
                    int nombreDuDe2 = aleatoireDe2.Next(1, 7);
                    valeursDes[1] = nombreDuDe2;
                    this.Invoke(new Action(() =>
                    {
                        changerImageDe(pictureBox_de2, nombreDuDe2);
                    }));
                    Thread.Sleep(100);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur dans executionLancerDe2: " + ex.Message);
            }

        }



        private void changerImageDe(PictureBox pb, int numero)
        {
            if (File.Exists(Application.StartupPath + "\\dé\\" + numero + ".png"))
            {
                pb.Image = Image.FromFile(Application.StartupPath + "\\dé\\" + numero + ".png");
            }
            else
            {
                MessageBox.Show("Fichier image du dé " + Application.StartupPath + "\\dé\\" + numero + ".png");
            }
        }

        private void executionLancerDe3()
        {
            try
            {
                while (enExecutionDe3)
                {
                    int nombreDuDe3 = aleatoireDe3.Next(1, 7);
                    valeursDes[2] = nombreDuDe3;

                    this.Invoke(new Action(() =>
                    {
                        changerImageDe(pictureBox_de3, nombreDuDe3);
                    }));
                    Thread.Sleep(100);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur dans executionLancerDe3: " + ex.Message);
            }

        }

        private void executionLancerDe4()
        {
            try
            {
                while (enExecutionDe4)
                {
                    int nombreDuDe4 = aleatoireDe4.Next(1, 7);
                    valeursDes[3] = nombreDuDe4;

                    this.Invoke(new Action(() =>
                    {
                        changerImageDe(pictureBox_de4, nombreDuDe4);
                    }));
                    Thread.Sleep(100);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur dans executionLancerDe4: " + ex.Message);
            }

        }

        private void executionLancerDe5()
        {
            try
            {
                while (enExecutionDe5)
                {
                    int nombreDuDe5 = aleatoireDe5.Next(1, 7);
                    valeursDes[4] = nombreDuDe5;

                    this.Invoke(new Action(() =>
                    {
                        changerImageDe(pictureBox_de5, nombreDuDe5);
                    }));
                    Thread.Sleep(100);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur dans executionLancerDe5: " + ex.Message);
            }

        }
    

        private void terminerTour()
        {
            foreach (Label lbl in listeLabels)
            {
                if (lbl.ForeColor == Color.Green)
                {
                    lbl.Text = "";
                    lbl.Visible = false;
                    lbl.ForeColor = Color.Pink; // Remise à l'état par défaut
                }
            }
            if (lblYatJ1.ForeColor != Color.Black) { lblYatJ1.Text = ""; lblYatJ1.Visible = false; }
            if (lblYatJ2.ForeColor != Color.Black) { lblYatJ2.Text = ""; lblYatJ2.Visible = false; }


            if (sontCategoriesPrincipalesTerminees())
            {
                calculerEtAfficherGagnant();
            }


            deSelect1 = deSelect2 = deSelect3 = deSelect4 = deSelect5 = false;
            pictureBox_de1.BorderStyle = BorderStyle.None;
            pictureBox_de2.BorderStyle = BorderStyle.None;
            pictureBox_de3.BorderStyle = BorderStyle.None;
            pictureBox_de4.BorderStyle = BorderStyle.None;
            pictureBox_de5.BorderStyle = BorderStyle.None;
            btnDeselec.Enabled = false;

            lancersRestants = 3;
            btnBrasser.Enabled = true;
            btnArreter.Enabled = false;

            partie.ChangerTour();
            mettreAJourAffichageTour();
        }

        private void mettreAJourAffichageTour()
        {
            if (partie.ListeJoueurs.IndexOf(partie.JoueurCourant) == 0)
            {
                lblTourJ1.Visible = true;
                lblTourJ2.Visible = false;

            }
            else
            {
                lblTourJ1.Visible = false;
                lblTourJ2.Visible = true;
            } 
        }

        private void afficherScore()
        {
            int[] somme = new int[7];

            foreach (int valeur in valeursDes)
            {
                somme[valeur] += valeur;
            }

            Label lblUn, lblDeux, lblTrois, lblQuatre, lblCinq, lblSix;

            if (partie.JoueurCourant == listeJoueurs[0])
            {
                lblUn = lblUnJ1; lblDeux = lblDeuxJ1; lblTrois = lblTroisJ1;
                lblQuatre = lblQuatreJ1; lblCinq = lblCinqJ1; lblSix = lblSixJ1;
                lblYat = lblYatJ1;
            }
            else
            {
                lblUn = lblUnJ2; lblDeux = lblDeuxJ2; lblTrois = lblTroisJ2;
                lblQuatre = lblQuatreJ2; lblCinq = lblCinqJ2; lblSix = lblSixJ2;
                lblYat = lblYatJ2;
            }

            int pointsYahtzee = partie.CalculerYahtzee(valeursDes);

            affichageAjour(lblUn, somme[1]);
            affichageAjour(lblDeux, somme[2]);
            affichageAjour(lblTrois, somme[3]);
            affichageAjour(lblQuatre, somme[4]);
            affichageAjour(lblCinq, somme[5]);
            affichageAjour(lblSix, somme[6]);

            if (pointsYahtzee > 0)
            {
                affichageAjour(lblYat, pointsYahtzee);
            }
            else
            {
                if (lblYat.ForeColor != Color.Black) 
                {
                    lblYat.Text = "0";
                    lblYat.ForeColor = Color.Green;
                    lblYat.Visible = true;
                    lblYat.Enabled = true;
                }
            }
        }

        private void affichageAjour(Label lbl, int score)
        {
            if (lbl.ForeColor != Color.Black)
            {
                if (score > 0)
                {
                    lbl.ForeColor = Color.Green;
                    lbl.Text = score.ToString();
                    lbl.Visible = true;
                    lbl.Enabled = true;
                }
                else
                {
                    lbl.Visible = false;
                    lbl.Enabled = false;
                    lbl.Text = "";
                }
            }
            
        }

        private bool sontCategoriesPrincipalesTerminees()
        {
            bool j1Fini = lblUnJ1.ForeColor == Color.Black &&
                          lblDeuxJ1.ForeColor == Color.Black &&
                          lblTroisJ1.ForeColor == Color.Black &&
                          lblQuatreJ1.ForeColor == Color.Black &&
                          lblCinqJ1.ForeColor == Color.Black &&
                          lblSixJ1.ForeColor == Color.Black &&
                          lblYatJ1.ForeColor ==Color.Black;

            bool j2Fini = lblUnJ2.ForeColor == Color.Black &&
                          lblDeuxJ2.ForeColor == Color.Black &&
                          lblTroisJ2.ForeColor == Color.Black &&
                          lblQuatreJ2.ForeColor == Color.Black &&
                          lblCinqJ2.ForeColor == Color.Black &&
                          lblSixJ2.ForeColor == Color.Black &&
                          lblYatJ2.ForeColor == Color.Black;

            return j1Fini && j2Fini;
        }

        private void calculerEtAfficherGagnant()
        {
            int scoreJ1 = 0;
            int scoreJ2 = 0;
            foreach (Label lbl in listeLabels)
            {
                if (lbl.ForeColor == Color.Black)
                {
                    if (lbl.Name.EndsWith("J1"))
                    {
                        scoreJ1 += int.Parse(lbl.Text);
                    }
                    else if (lbl.Name.EndsWith("J2"))
                    {
                        scoreJ2 += int.Parse(lbl.Text);
                    }
                }
            }

            lblTotalJ1.Text = scoreJ1.ToString();
            lblTotalJ2.Text = scoreJ2.ToString();

            listeJoueurs[0].ScorePartie = scoreJ1;              
            listeJoueurs[0].ScoreTotalParties += scoreJ1;        
            listeJoueurs[0].TotalPartiesJouees++;                

            listeJoueurs[1].ScorePartie = scoreJ2;               
            listeJoueurs[1].ScoreTotalParties += scoreJ2;        
            listeJoueurs[1].TotalPartiesJouees++;                

            if (scoreJ1 > scoreJ2)
            {
                lblGagnant.Text = listeJoueurs[0].Nom + " a GAGNE !!" ;
            } 
            else if (scoreJ2 > scoreJ1)
            {
                lblGagnant.Text = listeJoueurs[1].Nom + " a GAGNE !!";
            }
            else
            {
                lblGagnant.Text = " WOWW egalite !!!";
            }

            foreach (var ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.Enabled = false;
                }
            }

            btnBrasser.Enabled = false;

        }

        private void NouvellePartie()
        {
            this.partie = new Partie(this.listeJoueurs); 
            this.lancersRestants = 3;
            Array.Clear(valeursDes, 0, valeursDes.Length); 

            deSelect1 = deSelect2 = deSelect3 = deSelect4 = deSelect5 = false;

            pictureBox_de1.BorderStyle = BorderStyle.None;
            pictureBox_de2.BorderStyle = BorderStyle.None;
            pictureBox_de3.BorderStyle = BorderStyle.None;
            pictureBox_de4.BorderStyle = BorderStyle.None;
            pictureBox_de5.BorderStyle = BorderStyle.None;

            foreach (Label lbl in listeLabels)
            {
                lbl.Text = "";          
                lbl.ForeColor = Color.Pink; 
                lbl.Visible = false;     
                lbl.Enabled = false;     
            }

            lblGagnant.Text = "";

            btnBrasser.Enabled = true;
            btnArreter.Enabled = false;
            btnDeselec.Enabled = false;
            toolTip_Tour.SetToolTip(btnBrasser, null);

            mettreAJourAffichageTour();
        }



    }

    
}
