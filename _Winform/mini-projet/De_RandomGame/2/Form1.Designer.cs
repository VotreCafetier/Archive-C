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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLancer = new System.Windows.Forms.Button();
            this.lblDe1 = new System.Windows.Forms.Label();
            this.lblV1 = new System.Windows.Forms.Label();
            this.lblD1 = new System.Windows.Forms.Label();
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblNbV1 = new System.Windows.Forms.Label();
            this.lblNbD1 = new System.Windows.Forms.Label();
            this.lblNbN1 = new System.Windows.Forms.Label();
            this.lblJoueur1 = new System.Windows.Forms.Label();
            this.lblMilieu = new System.Windows.Forms.Label();
            this.lblJoueur2 = new System.Windows.Forms.Label();
            this.lblDe2 = new System.Windows.Forms.Label();
            this.lblV2 = new System.Windows.Forms.Label();
            this.lblD2 = new System.Windows.Forms.Label();
            this.lblNbV2 = new System.Windows.Forms.Label();
            this.lblNbD2 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblNbN2 = new System.Windows.Forms.Label();
            this.lblGagnant2 = new System.Windows.Forms.Label();
            this.lblGagnant1 = new System.Windows.Forms.Label();
            this.lblNull = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLancer
            // 
            this.btnLancer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLancer.Location = new System.Drawing.Point(184, 370);
            this.btnLancer.Name = "btnLancer";
            this.btnLancer.Size = new System.Drawing.Size(133, 56);
            this.btnLancer.TabIndex = 0;
            this.btnLancer.Text = "Lancer les dés";
            this.btnLancer.UseVisualStyleBackColor = true;
            this.btnLancer.Click += new System.EventHandler(this.btnLancer_Click);
            // 
            // lblDe1
            // 
            this.lblDe1.AutoSize = true;
            this.lblDe1.BackColor = System.Drawing.Color.Transparent;
            this.lblDe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDe1.Location = new System.Drawing.Point(77, 284);
            this.lblDe1.Name = "lblDe1";
            this.lblDe1.Size = new System.Drawing.Size(56, 61);
            this.lblDe1.TabIndex = 1;
            this.lblDe1.Text = "0";
            // 
            // lblV1
            // 
            this.lblV1.AutoSize = true;
            this.lblV1.BackColor = System.Drawing.Color.Transparent;
            this.lblV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblV1.Location = new System.Drawing.Point(22, 130);
            this.lblV1.Name = "lblV1";
            this.lblV1.Size = new System.Drawing.Size(69, 16);
            this.lblV1.TabIndex = 1;
            this.lblV1.Text = "Victoire :";
            // 
            // lblD1
            // 
            this.lblD1.AutoSize = true;
            this.lblD1.BackColor = System.Drawing.Color.Transparent;
            this.lblD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblD1.Location = new System.Drawing.Point(21, 173);
            this.lblD1.Name = "lblD1";
            this.lblD1.Size = new System.Drawing.Size(70, 16);
            this.lblD1.TabIndex = 1;
            this.lblD1.Text = "Défaite : ";
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.BackColor = System.Drawing.Color.Transparent;
            this.lblN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblN1.Location = new System.Drawing.Point(44, 218);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(47, 16);
            this.lblN1.TabIndex = 1;
            this.lblN1.Text = "Null : ";
            // 
            // lblNbV1
            // 
            this.lblNbV1.AutoSize = true;
            this.lblNbV1.BackColor = System.Drawing.Color.Transparent;
            this.lblNbV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbV1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNbV1.Location = new System.Drawing.Point(97, 127);
            this.lblNbV1.Name = "lblNbV1";
            this.lblNbV1.Size = new System.Drawing.Size(19, 20);
            this.lblNbV1.TabIndex = 1;
            this.lblNbV1.Text = "0";
            // 
            // lblNbD1
            // 
            this.lblNbD1.AutoSize = true;
            this.lblNbD1.BackColor = System.Drawing.Color.Transparent;
            this.lblNbD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbD1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNbD1.Location = new System.Drawing.Point(97, 171);
            this.lblNbD1.Name = "lblNbD1";
            this.lblNbD1.Size = new System.Drawing.Size(19, 20);
            this.lblNbD1.TabIndex = 1;
            this.lblNbD1.Text = "0";
            // 
            // lblNbN1
            // 
            this.lblNbN1.AutoSize = true;
            this.lblNbN1.BackColor = System.Drawing.Color.Transparent;
            this.lblNbN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbN1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNbN1.Location = new System.Drawing.Point(97, 215);
            this.lblNbN1.Name = "lblNbN1";
            this.lblNbN1.Size = new System.Drawing.Size(19, 20);
            this.lblNbN1.TabIndex = 1;
            this.lblNbN1.Text = "0";
            // 
            // lblJoueur1
            // 
            this.lblJoueur1.AutoSize = true;
            this.lblJoueur1.BackColor = System.Drawing.Color.Transparent;
            this.lblJoueur1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoueur1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblJoueur1.Location = new System.Drawing.Point(51, 44);
            this.lblJoueur1.Name = "lblJoueur1";
            this.lblJoueur1.Size = new System.Drawing.Size(119, 31);
            this.lblJoueur1.TabIndex = 1;
            this.lblJoueur1.Text = "Joueur 1";
            // 
            // lblMilieu
            // 
            this.lblMilieu.AutoSize = true;
            this.lblMilieu.BackColor = System.Drawing.Color.Transparent;
            this.lblMilieu.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMilieu.Location = new System.Drawing.Point(246, 59);
            this.lblMilieu.Name = "lblMilieu";
            this.lblMilieu.Size = new System.Drawing.Size(9, 286);
            this.lblMilieu.TabIndex = 1;
            this.lblMilieu.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n";
            // 
            // lblJoueur2
            // 
            this.lblJoueur2.AutoSize = true;
            this.lblJoueur2.BackColor = System.Drawing.Color.Transparent;
            this.lblJoueur2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoueur2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblJoueur2.Location = new System.Drawing.Point(339, 44);
            this.lblJoueur2.Name = "lblJoueur2";
            this.lblJoueur2.Size = new System.Drawing.Size(119, 31);
            this.lblJoueur2.TabIndex = 1;
            this.lblJoueur2.Text = "Joueur 2";
            // 
            // lblDe2
            // 
            this.lblDe2.AutoSize = true;
            this.lblDe2.BackColor = System.Drawing.Color.Transparent;
            this.lblDe2.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDe2.Location = new System.Drawing.Point(377, 284);
            this.lblDe2.Name = "lblDe2";
            this.lblDe2.Size = new System.Drawing.Size(56, 61);
            this.lblDe2.TabIndex = 1;
            this.lblDe2.Text = "0";
            // 
            // lblV2
            // 
            this.lblV2.AutoSize = true;
            this.lblV2.BackColor = System.Drawing.Color.Transparent;
            this.lblV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblV2.Location = new System.Drawing.Point(322, 130);
            this.lblV2.Name = "lblV2";
            this.lblV2.Size = new System.Drawing.Size(69, 16);
            this.lblV2.TabIndex = 1;
            this.lblV2.Text = "Victoire :";
            // 
            // lblD2
            // 
            this.lblD2.AutoSize = true;
            this.lblD2.BackColor = System.Drawing.Color.Transparent;
            this.lblD2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblD2.Location = new System.Drawing.Point(321, 173);
            this.lblD2.Name = "lblD2";
            this.lblD2.Size = new System.Drawing.Size(70, 16);
            this.lblD2.TabIndex = 1;
            this.lblD2.Text = "Défaite : ";
            // 
            // lblNbV2
            // 
            this.lblNbV2.AutoSize = true;
            this.lblNbV2.BackColor = System.Drawing.Color.Transparent;
            this.lblNbV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbV2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNbV2.Location = new System.Drawing.Point(397, 127);
            this.lblNbV2.Name = "lblNbV2";
            this.lblNbV2.Size = new System.Drawing.Size(19, 20);
            this.lblNbV2.TabIndex = 1;
            this.lblNbV2.Text = "0";
            // 
            // lblNbD2
            // 
            this.lblNbD2.AutoSize = true;
            this.lblNbD2.BackColor = System.Drawing.Color.Transparent;
            this.lblNbD2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbD2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNbD2.Location = new System.Drawing.Point(397, 171);
            this.lblNbD2.Name = "lblNbD2";
            this.lblNbD2.Size = new System.Drawing.Size(19, 20);
            this.lblNbD2.TabIndex = 1;
            this.lblNbD2.Text = "0";
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.BackColor = System.Drawing.Color.Transparent;
            this.lblN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblN2.Location = new System.Drawing.Point(344, 218);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(47, 16);
            this.lblN2.TabIndex = 1;
            this.lblN2.Text = "Null : ";
            // 
            // lblNbN2
            // 
            this.lblNbN2.AutoSize = true;
            this.lblNbN2.BackColor = System.Drawing.Color.Transparent;
            this.lblNbN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbN2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNbN2.Location = new System.Drawing.Point(397, 215);
            this.lblNbN2.Name = "lblNbN2";
            this.lblNbN2.Size = new System.Drawing.Size(19, 20);
            this.lblNbN2.TabIndex = 1;
            this.lblNbN2.Text = "0";
            // 
            // lblGagnant2
            // 
            this.lblGagnant2.AutoSize = true;
            this.lblGagnant2.BackColor = System.Drawing.Color.Transparent;
            this.lblGagnant2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGagnant2.ForeColor = System.Drawing.Color.Lime;
            this.lblGagnant2.Location = new System.Drawing.Point(322, 268);
            this.lblGagnant2.Name = "lblGagnant2";
            this.lblGagnant2.Size = new System.Drawing.Size(153, 16);
            this.lblGagnant2.TabIndex = 1;
            this.lblGagnant2.Text = "Le joueur 2 à gagné !";
            this.lblGagnant2.Visible = false;
            // 
            // lblGagnant1
            // 
            this.lblGagnant1.AutoSize = true;
            this.lblGagnant1.BackColor = System.Drawing.Color.Transparent;
            this.lblGagnant1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGagnant1.ForeColor = System.Drawing.Color.Lime;
            this.lblGagnant1.Location = new System.Drawing.Point(22, 268);
            this.lblGagnant1.Name = "lblGagnant1";
            this.lblGagnant1.Size = new System.Drawing.Size(153, 16);
            this.lblGagnant1.TabIndex = 1;
            this.lblGagnant1.Text = "Le joueur 1 à gagné !";
            this.lblGagnant1.Visible = false;
            // 
            // lblNull
            // 
            this.lblNull.AutoSize = true;
            this.lblNull.BackColor = System.Drawing.Color.Transparent;
            this.lblNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNull.ForeColor = System.Drawing.Color.Magenta;
            this.lblNull.Location = new System.Drawing.Point(214, 193);
            this.lblNull.Name = "lblNull";
            this.lblNull.Size = new System.Drawing.Size(74, 31);
            this.lblNull.TabIndex = 1;
            this.lblNull.Text = "Null!";
            this.lblNull.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::_2.Properties.Resources.night_landscape_2814605_960_720;
            this.ClientSize = new System.Drawing.Size(517, 438);
            this.Controls.Add(this.lblNbN2);
            this.Controls.Add(this.lblNbN1);
            this.Controls.Add(this.lblGagnant1);
            this.Controls.Add(this.lblNull);
            this.Controls.Add(this.lblGagnant2);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblN1);
            this.Controls.Add(this.lblNbD2);
            this.Controls.Add(this.lblNbD1);
            this.Controls.Add(this.lblMilieu);
            this.Controls.Add(this.lblNbV2);
            this.Controls.Add(this.lblNbV1);
            this.Controls.Add(this.lblD2);
            this.Controls.Add(this.lblD1);
            this.Controls.Add(this.lblJoueur2);
            this.Controls.Add(this.lblV2);
            this.Controls.Add(this.lblJoueur1);
            this.Controls.Add(this.lblDe2);
            this.Controls.Add(this.lblV1);
            this.Controls.Add(this.lblDe1);
            this.Controls.Add(this.btnLancer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mini-Jeux 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLancer;
        private System.Windows.Forms.Label lblDe1;
        private System.Windows.Forms.Label lblV1;
        private System.Windows.Forms.Label lblD1;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Label lblNbV1;
        private System.Windows.Forms.Label lblNbD1;
        private System.Windows.Forms.Label lblNbN1;
        private System.Windows.Forms.Label lblJoueur1;
        private System.Windows.Forms.Label lblMilieu;
        private System.Windows.Forms.Label lblJoueur2;
        private System.Windows.Forms.Label lblDe2;
        private System.Windows.Forms.Label lblV2;
        private System.Windows.Forms.Label lblD2;
        private System.Windows.Forms.Label lblNbV2;
        private System.Windows.Forms.Label lblNbD2;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Label lblNbN2;
        private System.Windows.Forms.Label lblGagnant2;
        private System.Windows.Forms.Label lblGagnant1;
        private System.Windows.Forms.Label lblNull;
    }
}

