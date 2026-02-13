namespace WinFormPers
{
    partial class Menu
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
            this.lblCase1 = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.btnChoixUn = new System.Windows.Forms.Button();
            this.btnChoixDeux = new System.Windows.Forms.Button();
            this.btnChoixTrois = new System.Windows.Forms.Button();
            this.btnChoixQuatre = new System.Windows.Forms.Button();
            this.btnAfficheTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCase1
            // 
            this.lblCase1.AutoSize = true;
            this.lblCase1.Location = new System.Drawing.Point(793, 507);
            this.lblCase1.Name = "lblCase1";
            this.lblCase1.Size = new System.Drawing.Size(0, 13);
            this.lblCase1.TabIndex = 0;
            this.lblCase1.Click += new System.EventHandler(this.lblCase1_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(785, 422);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 1;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(908, 422);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 20);
            this.domainUpDown1.TabIndex = 2;
            this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // btnChoixUn
            // 
            this.btnChoixUn.Location = new System.Drawing.Point(52, 178);
            this.btnChoixUn.Name = "btnChoixUn";
            this.btnChoixUn.Size = new System.Drawing.Size(165, 23);
            this.btnChoixUn.TabIndex = 3;
            this.btnChoixUn.Text = "Afficher les éditeurs";
            this.btnChoixUn.UseVisualStyleBackColor = true;
            this.btnChoixUn.Click += new System.EventHandler(this.btnChoixUn_Click);
            // 
            // btnChoixDeux
            // 
            this.btnChoixDeux.Location = new System.Drawing.Point(52, 250);
            this.btnChoixDeux.Name = "btnChoixDeux";
            this.btnChoixDeux.Size = new System.Drawing.Size(165, 23);
            this.btnChoixDeux.TabIndex = 4;
            this.btnChoixDeux.Text = "Ajouter un éditeur";
            this.btnChoixDeux.UseVisualStyleBackColor = true;
            this.btnChoixDeux.Click += new System.EventHandler(this.btnChoixDeux_Click);
            // 
            // btnChoixTrois
            // 
            this.btnChoixTrois.Location = new System.Drawing.Point(52, 318);
            this.btnChoixTrois.Name = "btnChoixTrois";
            this.btnChoixTrois.Size = new System.Drawing.Size(165, 23);
            this.btnChoixTrois.TabIndex = 5;
            this.btnChoixTrois.Text = "Supprimer un titre dans la table Titles";
            this.btnChoixTrois.UseVisualStyleBackColor = true;
            this.btnChoixTrois.Click += new System.EventHandler(this.btnChoixTrois_Click);
            // 
            // btnChoixQuatre
            // 
            this.btnChoixQuatre.Location = new System.Drawing.Point(52, 394);
            this.btnChoixQuatre.Name = "btnChoixQuatre";
            this.btnChoixQuatre.Size = new System.Drawing.Size(165, 23);
            this.btnChoixQuatre.TabIndex = 6;
            this.btnChoixQuatre.Text = "Ajouter un titre";
            this.btnChoixQuatre.UseVisualStyleBackColor = true;
            this.btnChoixQuatre.Click += new System.EventHandler(this.btnChoixQuatre_Click);
            // 
            // btnAfficheTable
            // 
            this.btnAfficheTable.Location = new System.Drawing.Point(52, 457);
            this.btnAfficheTable.Name = "btnAfficheTable";
            this.btnAfficheTable.Size = new System.Drawing.Size(165, 23);
            this.btnAfficheTable.TabIndex = 7;
            this.btnAfficheTable.Text = "Affiche les tables";
            this.btnAfficheTable.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 635);
            this.Controls.Add(this.btnAfficheTable);
            this.Controls.Add(this.btnChoixQuatre);
            this.Controls.Add(this.btnChoixTrois);
            this.Controls.Add(this.btnChoixDeux);
            this.Controls.Add(this.btnChoixUn);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.lblCase1);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCase1;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Button btnChoixUn;
        private System.Windows.Forms.Button btnChoixDeux;
        private System.Windows.Forms.Button btnChoixTrois;
        private System.Windows.Forms.Button btnChoixQuatre;
        private System.Windows.Forms.Button btnAfficheTable;
    }
}

