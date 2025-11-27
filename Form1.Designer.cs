namespace tpSynthese
{
    partial class frmAcceuil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.listBox_JoueurDispo = new System.Windows.Forms.ListBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.listBox_JoueurGame = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnRetirer = new System.Windows.Forms.Button();
            this.btnDemarer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_JoueurDispo
            // 
            this.listBox_JoueurDispo.FormattingEnabled = true;
            this.listBox_JoueurDispo.Location = new System.Drawing.Point(12, 269);
            this.listBox_JoueurDispo.Name = "listBox_JoueurDispo";
            this.listBox_JoueurDispo.Size = new System.Drawing.Size(180, 225);
            this.listBox_JoueurDispo.TabIndex = 0;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Dice", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(47, 65);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(546, 46);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "Yatzee par daN";
            // 
            // listBox_JoueurGame
            // 
            this.listBox_JoueurGame.FormattingEnabled = true;
            this.listBox_JoueurGame.Location = new System.Drawing.Point(438, 269);
            this.listBox_JoueurGame.Name = "listBox_JoueurGame";
            this.listBox_JoueurGame.Size = new System.Drawing.Size(187, 225);
            this.listBox_JoueurGame.TabIndex = 2;
            this.listBox_JoueurGame.SelectedIndexChanged += new System.EventHandler(this.listBox_JoueurGame_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Joueur disponible";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Joueur dans la partie";
            // 
            // btnCreer
            // 
            this.btnCreer.AutoSize = true;
            this.btnCreer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreer.Location = new System.Drawing.Point(243, 173);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(158, 41);
            this.btnCreer.TabIndex = 5;
            this.btnCreer.Text = "Créer un Joueur";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.AutoSize = true;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(252, 320);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(139, 34);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter joueur >>";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnRetirer
            // 
            this.btnRetirer.AutoSize = true;
            this.btnRetirer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirer.Location = new System.Drawing.Point(252, 417);
            this.btnRetirer.Name = "btnRetirer";
            this.btnRetirer.Size = new System.Drawing.Size(139, 34);
            this.btnRetirer.TabIndex = 7;
            this.btnRetirer.Text = "<<  Retirer joueur";
            this.btnRetirer.UseVisualStyleBackColor = true;
            this.btnRetirer.Click += new System.EventHandler(this.btnRetirer_Click);
            // 
            // btnDemarer
            // 
            this.btnDemarer.AutoSize = true;
            this.btnDemarer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemarer.Location = new System.Drawing.Point(64, 539);
            this.btnDemarer.Name = "btnDemarer";
            this.btnDemarer.Size = new System.Drawing.Size(128, 44);
            this.btnDemarer.TabIndex = 8;
            this.btnDemarer.Text = "Démarrer";
            this.btnDemarer.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.AutoSize = true;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(438, 530);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(131, 44);
            this.btnQuitter.TabIndex = 9;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // frmAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 616);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnDemarer);
            this.Controls.Add(this.btnRetirer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_JoueurGame);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.listBox_JoueurDispo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAcceuil";
            this.Text = "Acceuil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListBox listBox_JoueurDispo;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.ListBox listBox_JoueurGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnRetirer;
        private System.Windows.Forms.Button btnDemarer;
        private System.Windows.Forms.Button btnQuitter;
    }
}

