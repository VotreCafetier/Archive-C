namespace _7
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
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblMain = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.btnEntrer = new System.Windows.Forms.Button();
            this.lblBienvenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(321, 337);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 0;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Minion Pro", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Location = new System.Drawing.Point(196, 33);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(332, 37);
            this.lblMain.TabIndex = 1;
            this.lblMain.Text = "Programme d\'identification";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNom.Location = new System.Drawing.Point(160, 176);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(93, 13);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Entrez votre nom :";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(259, 173);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(238, 20);
            this.tbNom.TabIndex = 3;
            // 
            // btnEntrer
            // 
            this.btnEntrer.Location = new System.Drawing.Point(520, 171);
            this.btnEntrer.Name = "btnEntrer";
            this.btnEntrer.Size = new System.Drawing.Size(75, 23);
            this.btnEntrer.TabIndex = 0;
            this.btnEntrer.Text = "Entrer!";
            this.btnEntrer.UseVisualStyleBackColor = true;
            this.btnEntrer.Click += new System.EventHandler(this.btnEntrer_Click);
            // 
            // lblBienvenu
            // 
            this.lblBienvenu.AutoSize = true;
            this.lblBienvenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblBienvenu.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblBienvenu.Location = new System.Drawing.Point(256, 100);
            this.lblBienvenu.Name = "lblBienvenu";
            this.lblBienvenu.Size = new System.Drawing.Size(58, 13);
            this.lblBienvenu.TabIndex = 2;
            this.lblBienvenu.Text = "Bienvenue";
            this.lblBienvenu.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 406);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lblBienvenu);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.btnEntrer);
            this.Controls.Add(this.btnQuitter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Button btnEntrer;
        private System.Windows.Forms.Label lblBienvenu;
    }
}

