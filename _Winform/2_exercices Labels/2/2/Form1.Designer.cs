namespace _2
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
            this.btnDe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDe
            // 
            this.btnDe.Location = new System.Drawing.Point(94, 207);
            this.btnDe.Name = "btnDe";
            this.btnDe.Size = new System.Drawing.Size(75, 23);
            this.btnDe.TabIndex = 0;
            this.btnDe.Text = "Lancer le dé";
            this.btnDe.UseVisualStyleBackColor = true;
            this.btnDe.Click += new System.EventHandler(this.btnDe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "La valeur de votre dé :";
            // 
            // lblNb
            // 
            this.lblNb.AutoSize = true;
            this.lblNb.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNb.Location = new System.Drawing.Point(110, 138);
            this.lblNb.Name = "lblNb";
            this.lblNb.Size = new System.Drawing.Size(39, 42);
            this.lblNb.TabIndex = 1;
            this.lblNb.Text = "0";
            this.lblNb.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblNb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNb;
    }
}

