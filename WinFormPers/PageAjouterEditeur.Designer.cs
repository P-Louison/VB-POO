namespace WinFormPers
{
    partial class PageAjouterEditeur
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
            this.tbxNomPrenom = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.tbxAdresse = new System.Windows.Forms.TextBox();
            this.tbxVille = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblCodePostale = new System.Windows.Forms.Label();
            this.tbxCodePostale = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxNomPrenom
            // 
            this.tbxNomPrenom.Location = new System.Drawing.Point(396, 122);
            this.tbxNomPrenom.Name = "tbxNomPrenom";
            this.tbxNomPrenom.Size = new System.Drawing.Size(133, 20);
            this.tbxNomPrenom.TabIndex = 0;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(362, 106);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(200, 13);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "quel est le prenom et le nom de l\'auteur ?";
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(415, 190);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(97, 13);
            this.lblAdresse.TabIndex = 2;
            this.lblAdresse.Text = "quel est l\'adresse ?";
            // 
            // tbxAdresse
            // 
            this.tbxAdresse.Location = new System.Drawing.Point(396, 206);
            this.tbxAdresse.Name = "tbxAdresse";
            this.tbxAdresse.Size = new System.Drawing.Size(133, 20);
            this.tbxAdresse.TabIndex = 3;
            // 
            // tbxVille
            // 
            this.tbxVille.Location = new System.Drawing.Point(396, 295);
            this.tbxVille.Name = "tbxVille";
            this.tbxVille.Size = new System.Drawing.Size(133, 20);
            this.tbxVille.TabIndex = 4;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(393, 279);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(136, 13);
            this.lblVille.TabIndex = 5;
            this.lblVille.Text = "Quel est le nom de la ville ?";
            // 
            // lblCodePostale
            // 
            this.lblCodePostale.AutoSize = true;
            this.lblCodePostale.Location = new System.Drawing.Point(399, 352);
            this.lblCodePostale.Name = "lblCodePostale";
            this.lblCodePostale.Size = new System.Drawing.Size(130, 13);
            this.lblCodePostale.TabIndex = 6;
            this.lblCodePostale.Text = "Quel est le code postale ?";
            // 
            // tbxCodePostale
            // 
            this.tbxCodePostale.Location = new System.Drawing.Point(396, 378);
            this.tbxCodePostale.Name = "tbxCodePostale";
            this.tbxCodePostale.Size = new System.Drawing.Size(133, 20);
            this.tbxCodePostale.TabIndex = 7;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(430, 441);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(63, 23);
            this.btnValider.TabIndex = 8;
            this.btnValider.Text = "Ajouter";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(740, 441);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 9;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // PageAjouterEditeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 528);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.tbxCodePostale);
            this.Controls.Add(this.lblCodePostale);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.tbxVille);
            this.Controls.Add(this.tbxAdresse);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.tbxNomPrenom);
            this.Name = "PageAjouterEditeur";
            this.Text = "PageAjouterEditeur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNomPrenom;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox tbxAdresse;
        private System.Windows.Forms.TextBox tbxVille;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblCodePostale;
        private System.Windows.Forms.TextBox tbxCodePostale;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnFermer;
    }
}