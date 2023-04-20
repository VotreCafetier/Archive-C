namespace _0
{
    partial class Form1
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
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnPrenom = new System.Windows.Forms.Button();
            this.btnAge = new System.Windows.Forms.Button();
            this.LIGNE = new System.Windows.Forms.Label();
            this.lblShow = new System.Windows.Forms.Label();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(193, 36);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 0;
            this.lblPrenom.Text = "Prenom";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(193, 77);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "Âge";
            // 
            // btnPrenom
            // 
            this.btnPrenom.Location = new System.Drawing.Point(13, 13);
            this.btnPrenom.Name = "btnPrenom";
            this.btnPrenom.Size = new System.Drawing.Size(146, 44);
            this.btnPrenom.TabIndex = 1;
            this.btnPrenom.Text = "Affiche la var monPrenom dans lblPrenom";
            this.btnPrenom.UseVisualStyleBackColor = true;
            this.btnPrenom.Click += new System.EventHandler(this.btnPrenom_Click);
            // 
            // btnAge
            // 
            this.btnAge.Location = new System.Drawing.Point(12, 63);
            this.btnAge.Name = "btnAge";
            this.btnAge.Size = new System.Drawing.Size(146, 44);
            this.btnAge.TabIndex = 1;
            this.btnAge.Text = "Affiche la var monÂge dans lblAge\r\n";
            this.btnAge.UseVisualStyleBackColor = true;
            this.btnAge.Click += new System.EventHandler(this.btnAge_Click);
            // 
            // LIGNE
            // 
            this.LIGNE.AutoSize = true;
            this.LIGNE.Location = new System.Drawing.Point(-56, 110);
            this.LIGNE.Name = "LIGNE";
            this.LIGNE.Size = new System.Drawing.Size(421, 13);
            this.LIGNE.TabIndex = 0;
            this.LIGNE.Text = "_____________________________________________________________________";
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(24, 150);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(75, 13);
            this.lblShow.TabIndex = 0;
            this.lblShow.Text = "Clique sur moi.";
            this.lblShow.Click += new System.EventHandler(this.lblShow_Click);
            // 
            // lblCouleur
            // 
            this.lblCouleur.AutoSize = true;
            this.lblCouleur.Location = new System.Drawing.Point(24, 177);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(230, 26);
            this.lblCouleur.TabIndex = 0;
            this.lblCouleur.Text = "Clique ici pour changer la couleur du formulaire \r\navec un switch case";
            this.lblCouleur.Click += new System.EventHandler(this.lblCouleur_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(57, 218);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(70, 25);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "label1";
            this.lblColor.Visible = false;
            this.lblColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.btnAge);
            this.Controls.Add(this.btnPrenom);
            this.Controls.Add(this.LIGNE);
            this.Controls.Add(this.lblCouleur);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblPrenom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnPrenom;
        private System.Windows.Forms.Button btnAge;
        private System.Windows.Forms.Label LIGNE;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.Label lblColor;
    }
}

