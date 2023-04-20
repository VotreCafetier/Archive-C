namespace _8
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
            this.lblCouleur = new System.Windows.Forms.Label();
            this.txtCouleur = new System.Windows.Forms.TextBox();
            this.btnChanger = new System.Windows.Forms.Button();
            this.lblChoix = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCouleur
            // 
            this.lblCouleur.AutoSize = true;
            this.lblCouleur.Location = new System.Drawing.Point(24, 202);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(0, 13);
            this.lblCouleur.TabIndex = 0;
            // 
            // txtCouleur
            // 
            this.txtCouleur.Location = new System.Drawing.Point(27, 152);
            this.txtCouleur.Name = "txtCouleur";
            this.txtCouleur.Size = new System.Drawing.Size(100, 20);
            this.txtCouleur.TabIndex = 1;
            // 
            // btnChanger
            // 
            this.btnChanger.Location = new System.Drawing.Point(109, 226);
            this.btnChanger.Name = "btnChanger";
            this.btnChanger.Size = new System.Drawing.Size(75, 23);
            this.btnChanger.TabIndex = 2;
            this.btnChanger.Text = "Changer!";
            this.btnChanger.UseVisualStyleBackColor = true;
            this.btnChanger.Click += new System.EventHandler(this.btnChanger_Click);
            // 
            // lblChoix
            // 
            this.lblChoix.AutoSize = true;
            this.lblChoix.Location = new System.Drawing.Point(24, 26);
            this.lblChoix.Name = "lblChoix";
            this.lblChoix.Size = new System.Drawing.Size(175, 91);
            this.lblChoix.TabIndex = 0;
            this.lblChoix.Text = "Veuillez choisir entre ces couleurs : \r\n-Bleu\r\n-Rouge\r\n-Blanc\r\n-Vert\r\n-Jaune\r\n-Ro" +
                "se";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnChanger);
            this.Controls.Add(this.txtCouleur);
            this.Controls.Add(this.lblChoix);
            this.Controls.Add(this.lblCouleur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.TextBox txtCouleur;
        private System.Windows.Forms.Button btnChanger;
        private System.Windows.Forms.Label lblChoix;
    }
}

