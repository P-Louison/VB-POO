namespace WinFormPers
{
    partial class PageAfficherEditeur
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
            this.btnrechercher = new System.Windows.Forms.Button();
            this.tbxRechercher = new System.Windows.Forms.TextBox();
            this.lvResultat = new System.Windows.Forms.ListView();
            this.lblQuestionNom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnrechercher
            // 
            this.btnrechercher.Location = new System.Drawing.Point(477, 220);
            this.btnrechercher.Name = "btnrechercher";
            this.btnrechercher.Size = new System.Drawing.Size(75, 23);
            this.btnrechercher.TabIndex = 0;
            this.btnrechercher.Text = "Rechercher";
            this.btnrechercher.UseVisualStyleBackColor = true;
            this.btnrechercher.Click += new System.EventHandler(this.btnrechercher_Click);
            // 
            // tbxRechercher
            // 
            this.tbxRechercher.Location = new System.Drawing.Point(464, 149);
            this.tbxRechercher.Name = "tbxRechercher";
            this.tbxRechercher.Size = new System.Drawing.Size(100, 20);
            this.tbxRechercher.TabIndex = 1;
            // 
            // lvResultat
            // 
            this.lvResultat.HideSelection = false;
            this.lvResultat.Location = new System.Drawing.Point(12, 12);
            this.lvResultat.Name = "lvResultat";
            this.lvResultat.Size = new System.Drawing.Size(291, 426);
            this.lvResultat.TabIndex = 2;
            this.lvResultat.UseCompatibleStateImageBehavior = false;
            // 
            // lblQuestionNom
            // 
            this.lblQuestionNom.AutoSize = true;
            this.lblQuestionNom.Location = new System.Drawing.Point(447, 120);
            this.lblQuestionNom.Name = "lblQuestionNom";
            this.lblQuestionNom.Size = new System.Drawing.Size(134, 13);
            this.lblQuestionNom.TabIndex = 3;
            this.lblQuestionNom.Text = "Quel est le début du nom ?";
            // 
            // PageAfficherEditeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblQuestionNom);
            this.Controls.Add(this.lvResultat);
            this.Controls.Add(this.tbxRechercher);
            this.Controls.Add(this.btnrechercher);
            this.Name = "PageAfficherEditeur";
            this.Text = "PageAfficherEditeur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnrechercher;
        private System.Windows.Forms.TextBox tbxRechercher;
        private System.Windows.Forms.ListView lvResultat;
        private System.Windows.Forms.Label lblQuestionNom;
    }
}