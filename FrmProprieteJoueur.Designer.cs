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
            this.tbNomJoueur = new System.Windows.Forms.TextBox();
            this.lblNomJoueur = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnNvJoueur = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNomJoueur
            // 
            this.tbNomJoueur.Location = new System.Drawing.Point(180, 263);
            this.tbNomJoueur.Name = "tbNomJoueur";
            this.tbNomJoueur.Size = new System.Drawing.Size(203, 20);
            this.tbNomJoueur.TabIndex = 0;
            // 
            // lblNomJoueur
            // 
            this.lblNomJoueur.AutoSize = true;
            this.lblNomJoueur.Location = new System.Drawing.Point(177, 247);
            this.lblNomJoueur.Name = "lblNomJoueur";
            this.lblNomJoueur.Size = new System.Drawing.Size(61, 13);
            this.lblNomJoueur.TabIndex = 1;
            this.lblNomJoueur.Text = "Nom joueur";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(202, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 172);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnNvJoueur
            // 
            this.btnNvJoueur.Location = new System.Drawing.Point(217, 386);
            this.btnNvJoueur.Name = "btnNvJoueur";
            this.btnNvJoueur.Size = new System.Drawing.Size(127, 23);
            this.btnNvJoueur.TabIndex = 4;
            this.btnNvJoueur.Text = "Nouveau Joueur";
            this.btnNvJoueur.UseVisualStyleBackColor = true;
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(120, 317);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(118, 23);
            this.btnSupp.TabIndex = 6;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(324, 317);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(127, 23);
            this.btnModifier.TabIndex = 7;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(217, 455);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Sauvegarder";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // FrmProprieteJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 519);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnNvJoueur);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblNomJoueur);
            this.Controls.Add(this.tbNomJoueur);
            this.Name = "FrmProprieteJoueur";
            this.Text = "FrmProprieteJoueur";
            this.Load += new System.EventHandler(this.FrmProprieteJoueur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNomJoueur;
        private System.Windows.Forms.Label lblNomJoueur;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnNvJoueur;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSave;
    }
}