namespace tpSynthese
{
    partial class FrmProprieteJoueur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProprieteJoueur));
            this.tbNomJoueur = new System.Windows.Forms.TextBox();
            this.lblNomJoueur = new System.Windows.Forms.Label();
            this.btnNvJoueur = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAleatoire = new System.Windows.Forms.Button();
            this.listBox_Joueur = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel_Avatars = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_avatar1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_avatar4 = new System.Windows.Forms.PictureBox();
            this.pictureBox_avatar6 = new System.Windows.Forms.PictureBox();
            this.pictureBox_avatar3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_avatar5 = new System.Windows.Forms.PictureBox();
            this.pictureBox_avatar2 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.errorProvider_Champ = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_Avatar = new System.Windows.Forms.ErrorProvider(this.components);
            this.saveFileDialog_FichierJoueur = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip_Fichier = new System.Windows.Forms.MenuStrip();
            this.impressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerLesDonnéesDuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retourÀLaccueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocumentImp = new System.Drawing.Printing.PrintDocument();
            this.printDialogImp = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialogImp = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialogImp = new System.Windows.Forms.PrintPreviewDialog();
            this.toolTip_Max = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel_Avatars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Champ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Avatar)).BeginInit();
            this.menuStrip_Fichier.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNomJoueur
            // 
            this.tbNomJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomJoueur.Location = new System.Drawing.Point(149, 310);
            this.tbNomJoueur.Name = "tbNomJoueur";
            this.tbNomJoueur.Size = new System.Drawing.Size(203, 29);
            this.tbNomJoueur.TabIndex = 0;
            // 
            // lblNomJoueur
            // 
            this.lblNomJoueur.AutoSize = true;
            this.lblNomJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomJoueur.Location = new System.Drawing.Point(146, 289);
            this.lblNomJoueur.Name = "lblNomJoueur";
            this.lblNomJoueur.Size = new System.Drawing.Size(86, 18);
            this.lblNomJoueur.TabIndex = 1;
            this.lblNomJoueur.Text = "Nom joueur";
            // 
            // btnNvJoueur
            // 
            this.btnNvJoueur.AutoSize = true;
            this.btnNvJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNvJoueur.Location = new System.Drawing.Point(163, 492);
            this.btnNvJoueur.Name = "btnNvJoueur";
            this.btnNvJoueur.Size = new System.Drawing.Size(161, 34);
            this.btnNvJoueur.TabIndex = 4;
            this.btnNvJoueur.Text = "Nouveau Joueur";
            this.btnNvJoueur.UseVisualStyleBackColor = true;
            this.btnNvJoueur.Click += new System.EventHandler(this.btnNvJoueur_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.AutoSize = true;
            this.btnSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupp.Location = new System.Drawing.Point(89, 364);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(118, 34);
            this.btnSupp.TabIndex = 6;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.AutoSize = true;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(293, 364);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(127, 34);
            this.btnModifier.TabIndex = 7;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(182, 425);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 34);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Sauvegarder";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAleatoire
            // 
            this.btnAleatoire.AutoSize = true;
            this.btnAleatoire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAleatoire.Location = new System.Drawing.Point(651, 77);
            this.btnAleatoire.Name = "btnAleatoire";
            this.btnAleatoire.Size = new System.Drawing.Size(75, 28);
            this.btnAleatoire.TabIndex = 9;
            this.btnAleatoire.Text = "Aléatoire";
            this.btnAleatoire.UseVisualStyleBackColor = true;
            this.btnAleatoire.Click += new System.EventHandler(this.btnAleatoire_Click);
            // 
            // listBox_Joueur
            // 
            this.listBox_Joueur.FormattingEnabled = true;
            this.listBox_Joueur.Location = new System.Drawing.Point(529, 297);
            this.listBox_Joueur.Name = "listBox_Joueur";
            this.listBox_Joueur.Size = new System.Drawing.Size(233, 251);
            this.listBox_Joueur.TabIndex = 10;
            this.listBox_Joueur.SelectedIndexChanged += new System.EventHandler(this.listBox_Joueur_SelectedIndexChanged);
            // 
            // tableLayoutPanel_Avatars
            // 
            this.tableLayoutPanel_Avatars.ColumnCount = 3;
            this.tableLayoutPanel_Avatars.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.23656F));
            this.tableLayoutPanel_Avatars.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.76344F));
            this.tableLayoutPanel_Avatars.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tableLayoutPanel_Avatars.Controls.Add(this.pictureBox_avatar1, 0, 0);
            this.tableLayoutPanel_Avatars.Controls.Add(this.pictureBox_avatar4, 0, 1);
            this.tableLayoutPanel_Avatars.Controls.Add(this.pictureBox_avatar6, 2, 1);
            this.tableLayoutPanel_Avatars.Controls.Add(this.pictureBox_avatar3, 2, 0);
            this.tableLayoutPanel_Avatars.Controls.Add(this.pictureBox_avatar5, 1, 1);
            this.tableLayoutPanel_Avatars.Controls.Add(this.pictureBox_avatar2, 1, 0);
            this.tableLayoutPanel_Avatars.Location = new System.Drawing.Point(36, 35);
            this.tableLayoutPanel_Avatars.Name = "tableLayoutPanel_Avatars";
            this.tableLayoutPanel_Avatars.RowCount = 2;
            this.tableLayoutPanel_Avatars.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Avatars.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Avatars.Size = new System.Drawing.Size(575, 256);
            this.tableLayoutPanel_Avatars.TabIndex = 13;
            // 
            // pictureBox_avatar1
            // 
            this.pictureBox_avatar1.BackgroundImage = global::tpSynthese.Properties.Resources.avatar1;
            this.pictureBox_avatar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_avatar1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_avatar1.Name = "pictureBox_avatar1";
            this.pictureBox_avatar1.Size = new System.Drawing.Size(171, 122);
            this.pictureBox_avatar1.TabIndex = 0;
            this.pictureBox_avatar1.TabStop = false;
            this.pictureBox_avatar1.Click += new System.EventHandler(this.pictureBox_avatar1_Click);
            // 
            // pictureBox_avatar4
            // 
            this.pictureBox_avatar4.BackgroundImage = global::tpSynthese.Properties.Resources.avatar4;
            this.pictureBox_avatar4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_avatar4.Location = new System.Drawing.Point(3, 131);
            this.pictureBox_avatar4.Name = "pictureBox_avatar4";
            this.pictureBox_avatar4.Size = new System.Drawing.Size(171, 122);
            this.pictureBox_avatar4.TabIndex = 1;
            this.pictureBox_avatar4.TabStop = false;
            this.pictureBox_avatar4.Click += new System.EventHandler(this.pictureBox_avatar4_Click);
            // 
            // pictureBox_avatar6
            // 
            this.pictureBox_avatar6.BackgroundImage = global::tpSynthese.Properties.Resources.avatar6;
            this.pictureBox_avatar6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_avatar6.Location = new System.Drawing.Point(386, 131);
            this.pictureBox_avatar6.Name = "pictureBox_avatar6";
            this.pictureBox_avatar6.Size = new System.Drawing.Size(176, 122);
            this.pictureBox_avatar6.TabIndex = 3;
            this.pictureBox_avatar6.TabStop = false;
            this.pictureBox_avatar6.Click += new System.EventHandler(this.pictureBox_avatar6_Click);
            // 
            // pictureBox_avatar3
            // 
            this.pictureBox_avatar3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_avatar3.BackgroundImage = global::tpSynthese.Properties.Resources.avatar3;
            this.pictureBox_avatar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_avatar3.Location = new System.Drawing.Point(386, 3);
            this.pictureBox_avatar3.Name = "pictureBox_avatar3";
            this.pictureBox_avatar3.Size = new System.Drawing.Size(176, 122);
            this.pictureBox_avatar3.TabIndex = 5;
            this.pictureBox_avatar3.TabStop = false;
            this.pictureBox_avatar3.Click += new System.EventHandler(this.pictureBox_avatar3_Click);
            // 
            // pictureBox_avatar5
            // 
            this.pictureBox_avatar5.BackgroundImage = global::tpSynthese.Properties.Resources.avatar5;
            this.pictureBox_avatar5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_avatar5.Location = new System.Drawing.Point(180, 131);
            this.pictureBox_avatar5.Name = "pictureBox_avatar5";
            this.pictureBox_avatar5.Size = new System.Drawing.Size(176, 122);
            this.pictureBox_avatar5.TabIndex = 4;
            this.pictureBox_avatar5.TabStop = false;
            this.pictureBox_avatar5.Click += new System.EventHandler(this.pictureBox_avatar5_Click);
            // 
            // pictureBox_avatar2
            // 
            this.pictureBox_avatar2.BackgroundImage = global::tpSynthese.Properties.Resources.avatar2;
            this.pictureBox_avatar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_avatar2.Location = new System.Drawing.Point(180, 3);
            this.pictureBox_avatar2.Name = "pictureBox_avatar2";
            this.pictureBox_avatar2.Size = new System.Drawing.Size(176, 122);
            this.pictureBox_avatar2.TabIndex = 2;
            this.pictureBox_avatar2.TabStop = false;
            this.pictureBox_avatar2.Click += new System.EventHandler(this.pictureBox_avatar2_Click);
            // 
            // errorProvider_Champ
            // 
            this.errorProvider_Champ.ContainerControl = this;
            // 
            // errorProvider_Avatar
            // 
            this.errorProvider_Avatar.ContainerControl = this;
            // 
            // menuStrip_Fichier
            // 
            this.menuStrip_Fichier.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impressionToolStripMenuItem});
            this.menuStrip_Fichier.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Fichier.Name = "menuStrip_Fichier";
            this.menuStrip_Fichier.Size = new System.Drawing.Size(795, 24);
            this.menuStrip_Fichier.TabIndex = 14;
            this.menuStrip_Fichier.Text = "Menu ";
            // 
            // impressionToolStripMenuItem
            // 
            this.impressionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eToolStripMenuItem,
            this.imprimerLesDonnéesDuToolStripMenuItem,
            this.retourÀLaccueilToolStripMenuItem});
            this.impressionToolStripMenuItem.Name = "impressionToolStripMenuItem";
            this.impressionToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.impressionToolStripMenuItem.Text = "Menu";
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.eToolStripMenuItem.Text = "Exporter les données du joueur (JSON)";
            this.eToolStripMenuItem.Click += new System.EventHandler(this.eToolStripMenuItem_Click);
            // 
            // imprimerLesDonnéesDuToolStripMenuItem
            // 
            this.imprimerLesDonnéesDuToolStripMenuItem.Name = "imprimerLesDonnéesDuToolStripMenuItem";
            this.imprimerLesDonnéesDuToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.imprimerLesDonnéesDuToolStripMenuItem.Text = "Imprimer les données du joueur (PDF)";
            this.imprimerLesDonnéesDuToolStripMenuItem.Click += new System.EventHandler(this.imprimerLesDonnéesDuToolStripMenuItem_Click);
            // 
            // retourÀLaccueilToolStripMenuItem
            // 
            this.retourÀLaccueilToolStripMenuItem.Name = "retourÀLaccueilToolStripMenuItem";
            this.retourÀLaccueilToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.retourÀLaccueilToolStripMenuItem.Text = "Retour à l\'accueil";
            this.retourÀLaccueilToolStripMenuItem.Click += new System.EventHandler(this.retourÀLaccueilToolStripMenuItem_Click);
            // 
            // printDocumentImp
            // 
            this.printDocumentImp.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentImp_PrintPage);
            // 
            // printDialogImp
            // 
            this.printDialogImp.UseEXDialog = true;
            // 
            // printPreviewDialogImp
            // 
            this.printPreviewDialogImp.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogImp.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogImp.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogImp.Enabled = true;
            this.printPreviewDialogImp.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogImp.Icon")));
            this.printPreviewDialogImp.Name = "printPreviewDialogImp";
            this.printPreviewDialogImp.Visible = false;
            // 
            // FrmProprieteJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(795, 571);
            this.Controls.Add(this.tableLayoutPanel_Avatars);
            this.Controls.Add(this.listBox_Joueur);
            this.Controls.Add(this.btnAleatoire);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnNvJoueur);
            this.Controls.Add(this.lblNomJoueur);
            this.Controls.Add(this.tbNomJoueur);
            this.Controls.Add(this.menuStrip_Fichier);
            this.MainMenuStrip = this.menuStrip_Fichier;
            this.Name = "FrmProprieteJoueur";
            this.Load += new System.EventHandler(this.FrmProprieteJoueur_Load);
            this.tableLayoutPanel_Avatars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Champ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Avatar)).EndInit();
            this.menuStrip_Fichier.ResumeLayout(false);
            this.menuStrip_Fichier.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNomJoueur;
        private System.Windows.Forms.Label lblNomJoueur;
        private System.Windows.Forms.Button btnNvJoueur;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAleatoire;
        private System.Windows.Forms.ListBox listBox_Joueur;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Avatars;
        private System.Windows.Forms.PictureBox pictureBox_avatar1;
        private System.Windows.Forms.PictureBox pictureBox_avatar4;
        private System.Windows.Forms.PictureBox pictureBox_avatar2;
        private System.Windows.Forms.PictureBox pictureBox_avatar6;
        private System.Windows.Forms.PictureBox pictureBox_avatar3;
        private System.Windows.Forms.PictureBox pictureBox_avatar5;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider_Champ;
        private System.Windows.Forms.ErrorProvider errorProvider_Avatar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_FichierJoueur;
        private System.Windows.Forms.MenuStrip menuStrip_Fichier;
        private System.Windows.Forms.ToolStripMenuItem impressionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerLesDonnéesDuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retourÀLaccueilToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocumentImp;
        private System.Windows.Forms.PrintDialog printDialogImp;
        private System.Windows.Forms.PageSetupDialog pageSetupDialogImp;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogImp;
        private System.Windows.Forms.ToolTip toolTip_Max;
    }
}