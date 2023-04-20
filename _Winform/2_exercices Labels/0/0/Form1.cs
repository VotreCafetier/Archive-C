using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _0
{
    public partial class Form1 : Form
    {
        //Var
        string monPrenom = "Bill";
        int monAge = 68;
        int temp = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //Quand bouton du nom est clique
        private void btnPrenom_Click(object sender, EventArgs e)
        {
            lblPrenom.Text = monPrenom;
        }

        //quand le bouton age est clique
        private void btnAge_Click(object sender, EventArgs e)
        {
            lblAge.Text = monAge.ToString();
        }

        //bouton changement d'affichage
        private void lblShow_Click(object sender, EventArgs e)
        {
            lblShow.Text = "NE ME CLIQUE PAS DESSUS !";
            lblShow.BackColor = Color.Magenta;
        }

        //changement de couleur de fond avec lbl
        private void lblCouleur_Click(object sender, EventArgs e)
        {
            temp++;
            switch (temp)
            {
                case 1:
                    this.BackColor = Color.LightBlue;
                    lblColor.Text = "Light Blue";
                    lblColor.Visible = true;
                    break;

                case 2:
                    this.BackColor = Color.LightGreen;
                    lblColor.Text = "Light Green";
                    lblColor.Visible = true;
                    break;

                case 3:
                    this.BackColor = Color.LightSalmon;
                    lblColor.Text = "Light Salmon";
                    lblColor.Visible = true;
                    break;

                case 4:
                    this.BackColor = Color.LightYellow;
                    lblColor.Text = "Light Yellow";
                    lblColor.Visible = true;
                    break;

                case 5:
                    this.BackColor = Color.Pink;
                    lblColor.Text = "Pink";
                    lblColor.Visible = true;
                    break;
            }
        }

        private void lblColor_Click(object sender, EventArgs e)
        {
            
        }
    }
}
