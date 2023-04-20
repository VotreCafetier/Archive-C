namespace _4
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
            this.btnP = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.lblN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnP
            // 
            this.btnP.Location = new System.Drawing.Point(183, 89);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(75, 23);
            this.btnP.TabIndex = 0;
            this.btnP.Text = "+";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnM
            // 
            this.btnM.Location = new System.Drawing.Point(183, 149);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(75, 23);
            this.btnM.TabIndex = 0;
            this.btnM.Text = "_";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.Location = new System.Drawing.Point(38, 111);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(31, 33);
            this.lblN.TabIndex = 1;
            this.lblN.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Label lblN;
    }
}

