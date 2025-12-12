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

namespace tpSynthese
{
    public partial class FrmJeu : Form
    {
        private const string TIP_BRASSER = "Vous ne pouvez plus brasser, choississez un pointage.";

        private List<Joueur> listeJoueurs;
        private Thread threadDe1, threadDe2, threadDe3, threadDe4, threadDe5;
        private volatile bool enExecutionDe1, enExecutionDe2, enExecutionDe3, enExecutionDe4, enExecutionDe5;
        private Random aleatoireDe1, aleatoireDe2, aleatoireDe3, aleatoireDe4, aleatoireDe5;
        private int[] valeursDes = new int[5];
        private int lancersRestants = 3;
        Partie partie;
        private bool deSelect1, deSelect2, deSelect3, deSelect4, deSelect5;


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
            TerminerTour();
        }

        private void lblUnJ2_Click(object sender, EventArgs e)
        {
             TerminerTour();
        }

        private void lblDeuxJ1_Click(object sender, EventArgs e)
        {
            TerminerTour();
        }

        private void lblDeuxJ2_Click(object sender, EventArgs e)
        {
            TerminerTour();
        }

        private void lblTroisJ1_Click(object sender, EventArgs e)
        {
             TerminerTour();
        }

        private void lblTroisJ2_Click(object sender, EventArgs e)
        {
             TerminerTour();
        }

        private void lblQuatreJ1_Click(object sender, EventArgs e)
        {
             TerminerTour();
        }

        private void lblQuatreJ2_Click(object sender, EventArgs e)
        {
            TerminerTour();
        }

        private void lblCinqJ1_Click(object sender, EventArgs e)
        {    
            TerminerTour();
        }

        private void lblCinqJ2_Click(object sender, EventArgs e)
        {
            TerminerTour();
        }

        private void lblSixJ1_Click(object sender, EventArgs e)
        {
            TerminerTour();
        }

        private void lblSixJ2_Click(object sender, EventArgs e)
        {  
            TerminerTour();
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
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblYatJ1_Click(object sender, EventArgs e)
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
            AfficherScore();
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
            }
            else
            {
                toolTip_Tour.SetToolTip(btnBrasser, TIP_BRASSER);
                AfficherScore();
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
                        ChangerImageDe(pictureBox_de1, nombreDuDe);
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
                        ChangerImageDe(pictureBox_de2, nombreDuDe2);
                    }));
                    Thread.Sleep(100);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur dans executionLancerDe2: " + ex.Message);
            }

        }



        private void ChangerImageDe(PictureBox pb, int numero)
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
                        ChangerImageDe(pictureBox_de3, nombreDuDe3);
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
                        ChangerImageDe(pictureBox_de4, nombreDuDe4);
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
                        ChangerImageDe(pictureBox_de5, nombreDuDe5);
                    }));
                    Thread.Sleep(100);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur dans executionLancerDe5: " + ex.Message);
            }

        }
    

        private void TerminerTour()
        {
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

            MettreAJourAffichageTour();
        }

        private void MettreAJourAffichageTour()
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

        private void AfficherScore()
        {
            if (partie.JoueurCourant == listeJoueurs[0])
            {
                int somme1 = 0;
                int somme2 = 0;
                int somme3 = 0;
                int somme4 = 0;
                int somme5 = 0;
                int somme6 = 0;

                foreach (int valeur in valeursDes)
                {
                    if (valeur == 1)
                    {
                        somme1 += 1;
                    }

                    if (valeur == 2)
                    {
                        somme2 += 2;
                    }
                    if (valeur == 3)
                    {
                        somme3 += 3;
                    }
                    if (valeur == 4)
                    {
                        somme4 += 4;
                    }
                    if (valeur == 5)
                    {
                        somme5 += 5;
                    }
                    if (valeur == 6)
                    {
                        somme6 += 6;
                    }
                }
                if (somme1 != 0)
                {
                    lblUnJ1.Text = somme1.ToString();
                    lblUnJ1.ForeColor = Color.Green;
                }
                if (somme2 != 0)
                {
                    lblDeuxJ1.Text = somme2.ToString();
                    lblDeuxJ1.ForeColor = Color.Green;
                }
                if (somme3 != 0)
                {
                    lblTroisJ1.Text = somme3.ToString();
                    lblTroisJ1.ForeColor = Color.Green;
                }
                if (somme4 != 0)
                {
                    lblQuatreJ1.Text = somme4.ToString();
                    lblQuatreJ1.ForeColor = Color.Green;
                }
                if (somme5 != 0)
                {
                    lblCinqJ1.Text = somme5.ToString();
                    lblCinqJ1.ForeColor = Color.Green;
                }
            }
            else
            {
                int somme1 = 0;
                int somme2 = 0;
                int somme3 = 0;
                int somme4 = 0;
                int somme5 = 0;
                int somme6 = 0;
                foreach (int valeur in valeursDes)
                {
                    if (valeur == 1)
                    {
                        somme1 += 1;
                    }
                    if (valeur == 2)
                    {
                        somme2 += 2;
                    }
                    if (valeur == 3)
                    {
                        somme3 += 3;
                    }
                    if (valeur == 4)
                    {
                        somme4 += 4;
                    }
                    if (valeur == 5)
                    {
                        somme5 += 5;
                    }
                    if (valeur == 6)
                    {
                        somme6 += 6;
                    }
                }
                if (somme1 != 0)
                {
                    lblUnJ2.Text = somme1.ToString();
                    lblUnJ2.ForeColor = Color.Green;
                }
                if (somme2 != 0)
                {
                    lblDeuxJ2.Text = somme2.ToString();
                    lblDeuxJ2.ForeColor = Color.Green;
                }
                if (somme3 != 0)
                {
                    lblTroisJ2.Text = somme3.ToString();
                    lblTroisJ2.ForeColor = Color.Green;
                }
                if (somme4 != 0)
                {
                    lblQuatreJ2.Text = somme4.ToString();
                    lblQuatreJ2.ForeColor = Color.Green;
                }
                if (somme5 != 0)
                {
                    lblCinqJ2.Text = somme5.ToString();
                    lblCinqJ2.ForeColor = Color.Green;
                }
            }


        }


    }
    
}
