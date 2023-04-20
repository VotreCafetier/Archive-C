namespace _1
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
            this.btnEssayer = new System.Windows.Forms.Button();
            this.lblMain = new System.Windows.Forms.Label();
            this.lblIndice = new System.Windows.Forms.Label();
            this.tbNb = new System.Windows.Forms.TextBox();
            this.lblSous = new System.Windows.Forms.Label();
            this.lblEssai = new System.Windows.Forms.Label();
            this.lblNb = new System.Windows.Forms.Label();
            this.lbltemp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEssayer
            // 
            this.btnEssayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnEssayer.Location = new System.Drawing.Point(190, 391);
            this.btnEssayer.Name = "btnEssayer";
            this.btnEssayer.Size = new System.Drawing.Size(139, 23);
            this.btnEssayer.TabIndex = 0;
            this.btnEssayer.Text = "Essayer!";
            this.btnEssayer.UseVisualStyleBackColor = true;
            this.btnEssayer.Click += new System.EventHandler(this.btnEssayer_Click);
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Location = new System.Drawing.Point(183, 25);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(146, 39);
            this.lblMain.TabIndex = 1;
            this.lblMain.Text = "Mini-Jeu";
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(102, 203);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(0, 13);
            this.lblIndice.TabIndex = 1;
            // 
            // tbNb
            // 
            this.tbNb.Location = new System.Drawing.Point(211, 335);
            this.tbNb.Name = "tbNb";
            this.tbNb.Size = new System.Drawing.Size(100, 20);
            this.tbNb.TabIndex = 2;
            // 
            // lblSous
            // 
            this.lblSous.AutoSize = true;
            this.lblSous.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSous.Location = new System.Drawing.Point(68, 73);
            this.lblSous.Name = "lblSous";
            this.lblSous.Size = new System.Drawing.Size(405, 21);
            this.lblSous.TabIndex = 1;
            this.lblSous.Text = "Un nombre à été choisi entre 1 et 20 inclusivement.";
            // 
            // lblEssai
            // 
            this.lblEssai.AutoSize = true;
            this.lblEssai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblEssai.Location = new System.Drawing.Point(431, 437);
            this.lblEssai.Name = "lblEssai";
            this.lblEssai.Size = new System.Drawing.Size(73, 13);
            this.lblEssai.TabIndex = 1;
            this.lblEssai.Text = "Essai restant :";
            // 
            // lblNb
            // 
            this.lblNb.AutoSize = true;
            this.lblNb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNb.Location = new System.Drawing.Point(510, 419);
            this.lblNb.Name = "lblNb";
            this.lblNb.Size = new System.Drawing.Size(36, 37);
            this.lblNb.TabIndex = 1;
            this.lblNb.Text = "3";
            // 
            // lbltemp
            // 
            this.lbltemp.AutoSize = true;
            this.lbltemp.Location = new System.Drawing.Point(493, 25);
            this.lbltemp.Name = "lbltemp";
            this.lbltemp.Size = new System.Drawing.Size(13, 13);
            this.lbltemp.TabIndex = 1;
            this.lbltemp.Text = "0";
            this.lbltemp.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 465);
            this.Controls.Add(this.tbNb);
            this.Controls.Add(this.lbltemp);
            this.Controls.Add(this.lblIndice);
            this.Controls.Add(this.lblNb);
            this.Controls.Add(this.lblEssai);
            this.Controls.Add(this.lblSous);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.btnEssayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEssayer;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblIndice;
        private System.Windows.Forms.TextBox tbNb;
        private System.Windows.Forms.Label lblSous;
        private System.Windows.Forms.Label lblEssai;
        private System.Windows.Forms.Label lblNb;
        private System.Windows.Forms.Label lbltemp;
    }
}

