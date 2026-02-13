namespace WinFormPers
{
    partial class PageDelete
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
            this.lblISBN = new System.Windows.Forms.Label();
            this.tbxISBN = new System.Windows.Forms.TextBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(299, 112);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(115, 13);
            this.lblISBN.TabIndex = 0;
            this.lblISBN.Text = "Quel est l\'ISBN du livre";
            this.lblISBN.Click += new System.EventHandler(this.lblISBN_Click);
            // 
            // tbxISBN
            // 
            this.tbxISBN.Location = new System.Drawing.Point(302, 141);
            this.tbxISBN.Name = "tbxISBN";
            this.tbxISBN.Size = new System.Drawing.Size(112, 20);
            this.tbxISBN.TabIndex = 1;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(312, 334);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(87, 23);
            this.btnFermer.TabIndex = 2;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(312, 192);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(87, 23);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // PageDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.tbxISBN);
            this.Controls.Add(this.lblISBN);
            this.Name = "PageDelete";
            this.Text = "PageDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox tbxISBN;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnSupprimer;
    }
}