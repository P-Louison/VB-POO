namespace WinFormPers
{
    partial class PageAjoutLivre
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.cmbEditeur = new System.Windows.Forms.ComboBox();
            this.lblEditeur = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.tbxTitre = new System.Windows.Forms.TextBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.tbxISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxAuteur = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(455, 339);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // cmbEditeur
            // 
            this.cmbEditeur.FormattingEnabled = true;
            this.cmbEditeur.Location = new System.Drawing.Point(383, 64);
            this.cmbEditeur.Name = "cmbEditeur";
            this.cmbEditeur.Size = new System.Drawing.Size(233, 21);
            this.cmbEditeur.TabIndex = 1;
            // 
            // lblEditeur
            // 
            this.lblEditeur.AutoSize = true;
            this.lblEditeur.Location = new System.Drawing.Point(452, 48);
            this.lblEditeur.Name = "lblEditeur";
            this.lblEditeur.Size = new System.Drawing.Size(100, 13);
            this.lblEditeur.TabIndex = 2;
            this.lblEditeur.Text = "La liste des éditeurs";
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(679, 338);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 3;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // tbxTitre
            // 
            this.tbxTitre.Location = new System.Drawing.Point(96, 64);
            this.tbxTitre.Name = "tbxTitre";
            this.tbxTitre.Size = new System.Drawing.Size(109, 20);
            this.tbxTitre.TabIndex = 4;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(110, 48);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(86, 13);
            this.lblTitre.TabIndex = 5;
            this.lblTitre.Text = "Quel est le titre ?";
            // 
            // tbxISBN
            // 
            this.tbxISBN.Location = new System.Drawing.Point(96, 160);
            this.tbxISBN.Name = "tbxISBN";
            this.tbxISBN.Size = new System.Drawing.Size(109, 20);
            this.tbxISBN.TabIndex = 6;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(109, 140);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(87, 13);
            this.lblISBN.TabIndex = 7;
            this.lblISBN.Text = "Quel est l\'ISBN ?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Le(s) Auteur(s) ? ";
            // 
            // lbxAuteur
            // 
            this.lbxAuteur.FormattingEnabled = true;
            this.lbxAuteur.Location = new System.Drawing.Point(407, 160);
            this.lbxAuteur.Name = "lbxAuteur";
            this.lbxAuteur.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxAuteur.Size = new System.Drawing.Size(173, 95);
            this.lbxAuteur.TabIndex = 9;
            // 
            // PageAjoutLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxAuteur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.tbxISBN);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.tbxTitre);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.lblEditeur);
            this.Controls.Add(this.cmbEditeur);
            this.Controls.Add(this.btnAjouter);
            this.Name = "PageAjoutLivre";
            this.Text = "PageAjoutLivre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ComboBox cmbEditeur;
        private System.Windows.Forms.Label lblEditeur;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.TextBox tbxTitre;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox tbxISBN;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxAuteur;
    }
}