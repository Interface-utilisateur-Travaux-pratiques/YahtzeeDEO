using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Encodings.Web;


namespace tpSynthese
{

    public partial class FrmProprieteJoueur : Form
    {
        // impression
        string chemin = Application.StartupPath + "\\";
        string fichierJoueur = "DonneesJoueur.pdf";
        string portionDocImpression;
        string contenuDocumentEntier;
        Font policeImpression;


        // const erreurs
        private const string ERREUR_CHAMP_VIDE = "Le champ ne peut pas être vide.";
        private const string ERREUR_AVATAR_NON_SELECTIONNE = "Veuillez sélectionner un avatar.";
        private const string TIP_MAX_AVATARS = "Tous les avatars sont déjà choisis. \nVous devez supprimer un joueur pour en créer un autre.";
        private const int MAX_JOUEUR = 6;

        List<Joueur> listeJoueurs;
        List<string> avatarsOccupes = new List<string>();
        private PictureBox avatarSelectionne = null;
        private Random random = new Random();
        Joueur joueurSelectionne;
        string avatarChoisi = "aucun";
        int compteurJoueurs = 0;


        public FrmProprieteJoueur(List<Joueur> joueurs)
        {
            InitializeComponent();
            listeJoueurs = joueurs;

            foreach (Joueur j in listeJoueurs)
            {
                if (!string.IsNullOrEmpty(j.Avatar) && j.Avatar != "aucun")
                {
                    avatarsOccupes.Add(j.Avatar);
                }
            }
        }

        private void FrmProprieteJoueur_Load(object sender, EventArgs e)
        {
            listBox_Joueur.DataSource = null; 
            listBox_Joueur.DataSource = listeJoueurs;

            listBox_Joueur.SelectedIndex = -1;

            compteurJoueurs = listeJoueurs.Count;

            if (compteurJoueurs >= MAX_JOUEUR)
            {
                btnNvJoueur.Enabled = false;
                btnNvJoueur.Cursor = Cursors.No;
                btnAleatoire.Enabled = false;
                btnAleatoire.Cursor = Cursors.No;
            }
        
        }

        private void btnAleatoire_Click(object sender, EventArgs e)
        {
            btnNvJoueur_Click(sender, e);
            string nomAlea = "player" + random.Next(1000);

            tbNomJoueur.Text = nomAlea;
            int indexAvatar = random.Next(1, 7);
            string nomControl = "pictureBox_avatar" + indexAvatar;

            Control[] trouves = tableLayoutPanel_Avatars.Controls.Find(nomControl, true);

            do
            {
                indexAvatar = random.Next(1, 7);
                nomControl = "pictureBox_avatar" + indexAvatar;
                trouves = tableLayoutPanel_Avatars.Controls.Find(nomControl, true);
            }
            while (avatarsOccupes.Contains("avatar" + indexAvatar));

            if (trouves.Length > 0 && trouves[0] is PictureBox pb)
            {
                SelectionnerAvatar(pb, "avatar" + indexAvatar);
            }
           


        }




        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNomJoueur.Text))
            {
                errorProvider_Champ.SetError(tbNomJoueur, ERREUR_CHAMP_VIDE);
            }
            else
            {
                errorProvider_Champ.SetError(tbNomJoueur, null);
                if (avatarChoisi == "aucun")
                {
                    errorProvider_Avatar.SetError(tableLayoutPanel_Avatars, ERREUR_AVATAR_NON_SELECTIONNE);
                }
                else
                {

                    errorProvider_Avatar.SetError(tableLayoutPanel_Avatars, null);
                    if (joueurSelectionne == null)
                    {
                        Joueur nouveauJoueur = new Joueur(tbNomJoueur.Text, avatarChoisi);
                        listeJoueurs.Add(nouveauJoueur);

                        avatarsOccupes.Add(avatarChoisi);
                    }
                    else
                    {
                        if (joueurSelectionne.Avatar != avatarChoisi)
                        {
                            avatarsOccupes.Remove(joueurSelectionne.Avatar);
                            avatarsOccupes.Add(avatarChoisi);
                        }

                        joueurSelectionne.Nom = tbNomJoueur.Text;
                        joueurSelectionne.Avatar = avatarChoisi;
                    }


                    listBox_Joueur.DataSource = null;
                    listBox_Joueur.DataSource = listeJoueurs;
                    listBox_Joueur.SelectedIndex = -1;
                    tbNomJoueur.Clear();

                    tbNomJoueur.Enabled = false;
                    btnSave.Enabled = false;
                    tableLayoutPanel_Avatars.Enabled = false;
                    btnAleatoire.Enabled = false;

                    foreach (Control control in tableLayoutPanel_Avatars.Controls)
                    {
                        if (control is PictureBox pb)
                        {
                            string nomAvatar = pb.Name.Replace("pictureBox_", "");

                            if (avatarsOccupes.Contains(nomAvatar))
                            {
                                pb.BackColor = Color.FromArgb(254, 0, 0);
                                pb.Enabled = false;
                            }
                            else
                            {
                                pb.BackColor = Color.Transparent;
                                pb.Enabled = true;
                            }
                        }
                    }

                    compteurJoueurs = listeJoueurs.Count;

                    if (compteurJoueurs >= MAX_JOUEUR)
                    {
                        btnNvJoueur.Enabled = false;
                        toolTip_Max.SetToolTip(listBox_Joueur, TIP_MAX_AVATARS);
                    }
                    else
                    {
                        toolTip_Max.SetToolTip(btnNvJoueur, null);
                    }

                }
            }
        }



        private void pictureBox_avatar1_Click(object sender, EventArgs e)
        {
            SelectionnerAvatar(pictureBox_avatar1, "avatar1");
        }

        private void pictureBox_avatar2_Click(object sender, EventArgs e)
        {
            SelectionnerAvatar(pictureBox_avatar2, "avatar2");
        }

        private void pictureBox_avatar3_Click(object sender, EventArgs e)
        {
            SelectionnerAvatar(pictureBox_avatar3, "avatar3");
        }

        private void pictureBox_avatar4_Click(object sender, EventArgs e)
        {
            SelectionnerAvatar(pictureBox_avatar4, "avatar4");
        }

        private void pictureBox_avatar5_Click(object sender, EventArgs e)
        {
            SelectionnerAvatar(pictureBox_avatar5, "avatar5");
        }

        private void pictureBox_avatar6_Click(object sender, EventArgs e)
        {
            SelectionnerAvatar(pictureBox_avatar6, "avatar6");
        }

        private void SelectionnerAvatar(PictureBox pbClique, string nomAvatar)
        {
            avatarSelectionne = pbClique;
            avatarChoisi = nomAvatar;

            errorProvider_Avatar.SetError(tableLayoutPanel_Avatars, null);

            foreach (Control control in tableLayoutPanel_Avatars.Controls)
            {
                if (control is PictureBox pb)
                {
                    if (pb.BackColor != Color.FromArgb(254, 0, 0))
                    {
                        pb.BackColor = Color.Transparent;
                    }
                    
                }
            }

            pbClique.BackColor = Color.Red;

        }

        private void btnNvJoueur_Click(object sender, EventArgs e)
        {
            tbNomJoueur.Clear();
            tbNomJoueur.Enabled = true;
            avatarSelectionne = null;
            avatarChoisi = "aucun";
            errorProvider_Avatar.SetError(tableLayoutPanel_Avatars, null);
            btnSave.Enabled = true;
            tableLayoutPanel_Avatars.Enabled = true;
            btnAleatoire.Enabled = true;
            listBox_Joueur.SelectedIndex = -1;

            foreach (Control control in tableLayoutPanel_Avatars.Controls)
            {
                if (control is PictureBox pb)
                {
                    string nomAvatar = pb.Name.Replace("pictureBox_", "");

                    if (avatarsOccupes.Contains(nomAvatar))
                    {
                        pb.BackColor = Color.FromArgb(254, 0, 0);
                        pb.Enabled = false;
                    }
                    else
                    {
                        pb.BackColor = Color.Transparent;
                        pb.Enabled = true;
                    }
                }
            }

        }

        private void listBox_Joueur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Joueur.SelectedIndex != -1)
            {
                Joueur joueurSelectionne = (Joueur)listBox_Joueur.SelectedItem;
                tbNomJoueur.Text = joueurSelectionne.Nom;
                string p_avatar = joueurSelectionne.Avatar;

                foreach (Control control in tableLayoutPanel_Avatars.Controls)
                {
                    if (control is PictureBox pb)
                    {
                        if (pb.Name == "pictureBox_" + p_avatar)
                        {
                            SelectionnerAvatar(pb, p_avatar);
                        }
                        else
                        {
                            pb.BackColor = Color.Transparent;
                        }
                    }
                }
                tbNomJoueur.Enabled = false;
                btnSave.Enabled = false;
                tableLayoutPanel_Avatars.Enabled = false;
                btnAleatoire.Enabled = false;
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            

            if (listBox_Joueur.SelectedIndex != -1)
            {
                joueurSelectionne = (Joueur)listBox_Joueur.SelectedItem;
                tbNomJoueur.Enabled = true;
                btnSave.Enabled = true;
                tableLayoutPanel_Avatars.Enabled = true;
                btnAleatoire.Enabled = true;
            }

            
        }


        private void ecritureFichier(object sender, EventArgs e)
        {
            saveFileDialog_FichierJoueur.Title = "Enregistrer la liste des joueurs";
            saveFileDialog_FichierJoueur.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            saveFileDialog_FichierJoueur.FilterIndex = 2;
            saveFileDialog_FichierJoueur.InitialDirectory = Application.StartupPath + @"fichierJoueur/";


            if (saveFileDialog_FichierJoueur.ShowDialog() == DialogResult.OK)
            {
                StreamWriter ecriture = new StreamWriter(saveFileDialog_FichierJoueur.FileName, true);
                foreach (Joueur joueur in listeJoueurs)
                {
                    ecriture.WriteLine(joueur.Nom + ";" + joueur.Avatar + ";" + joueur.ScorePartie + ";" + joueur.TotalPartiesJouees + ";" + joueur.ScoreTotalParties);
                }
                ecriture.Close();
            }
        }


        private void lectureFichierJoueur(object sender, EventArgs e)
        {

        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nomFichier = Application.StartupPath + @"/fichierJoueur/proprieteJoueur.json";
            object liste = listeJoueurs;

            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };

                var jsonString = JsonSerializer.Serialize(liste, options);
                File.WriteAllText(nomFichier, jsonString, System.Text.Encoding.UTF8);

                MessageBox.Show("Fichier JSON écrit avec succès : " + nomFichier);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'écriture du fichier JSON : " + ex.Message);
            }
        }

        private void retourÀLaccueilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imprimerLesDonnéesDuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox_Joueur.SelectedIndex != -1)
            {
                Joueur joueurImprimé = (Joueur)listBox_Joueur.SelectedItem;
                policeImpression = this.Font;
                printDocumentImp.DocumentName = fichierJoueur;
                printDocumentImp.PrinterSettings.PrinterName = "PDFCreator";

                portionDocImpression = joueurImprimé.ToString();

                printDialogImp.Document = printDocumentImp;
                printDialogImp.AllowSelection = true;
                printDialogImp.AllowSomePages = true;

                if (printDialogImp.ShowDialog() == DialogResult.OK)
                {
                    printDocumentImp.Print();
                }

                
            }


        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            if (listBox_Joueur.SelectedIndex != -1)
            {
                Joueur joueurASupp = (Joueur)listBox_Joueur.SelectedItem;
                listeJoueurs.Remove(joueurASupp);
                avatarsOccupes.Remove(joueurASupp.Avatar);
                listBox_Joueur.DataSource = null;
                listBox_Joueur.DataSource = listeJoueurs;
                btnNvJoueur.Enabled = true;
                compteurJoueurs = listeJoueurs.Count;
            }
        }
    }
}
