using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChanger_Click(object sender, EventArgs e)
        {
            if (txtCouleur.Text == "blanc" || txtCouleur.Text == "Blanc")
            {
                this.BackColor = Color.White;
                lblCouleur.Text = "Bleu";
                txtCouleur.Text = "";
            }

            else if (txtCouleur.Text == "rouge" || txtCouleur.Text == "Rouge")
            {
                this.BackColor = Color.Red;
                lblCouleur.Text = "Rouge";
                txtCouleur.Text = "";
            }

            else if (txtCouleur.Text == "bleu" || txtCouleur.Text == "Bleu")
            {
                this.BackColor = Color.Blue;
                lblCouleur.Text = "Bleu";
                txtCouleur.Text = "";
            }

            else if (txtCouleur.Text == "vert" || txtCouleur.Text == "Vert")
            {
                this.BackColor = Color.Green;
                lblCouleur.Text = "Vert";
                txtCouleur.Text = "";
            }

            else if (txtCouleur.Text == "rose" || txtCouleur.Text == "Rose")
            {
                this.BackColor = Color.Pink;
                lblCouleur.Text = "Rose";
                txtCouleur.Text = "";
            }

            else if (txtCouleur.Text == "Jaune" || txtCouleur.Text == "jaune")
            {
                this.BackColor = Color.Yellow;
                lblCouleur.Text = "Jaune";
                txtCouleur.Text = "";
            }

            else
            {
                lblCouleur.Text = "Veuillez entrer un choix valide";
                txtCouleur.Text = "";
            }
        }
    }
}
