using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        //Var
        Random rnd = new Random();
        int V1, V2, D1, D2, N = 0;

        //Methode de refraishisement
        private new void Update()
        {
            //Refresh
            lblNbD1.Text = D1.ToString();
            lblNbD2.Text = D2.ToString();
            lblNbN1.Text = N.ToString();
            lblNbN2.Text = N.ToString();
            lblNbV1.Text = V1.ToString();
            lblNbV2.Text = V2.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Update();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLancer_Click(object sender, EventArgs e)
        {
            //Desactive les label gagnant
            lblNull.Visible = false;
            lblGagnant1.Visible = false;
            lblGagnant2.Visible = false;

            //Var
            int rndNb2 = rnd.Next(1, 7);
            int rndNb1 = rnd.Next(1, 7);

            //Met var dans le label
            lblDe1.Text = rndNb1.ToString();
            lblDe2.Text = rndNb2.ToString();

            //refresh
            Update();

            //Si le nombre du joueur 2 est plus grand que le 1(joueur 2 gagne)
            if (rndNb1 < rndNb2)
            {
                //Affiche le label
                lblGagnant2.Visible = true;

                //ajoute au compteur V2 && D1
                V2++;
                D1++;
            }

            else if (rndNb1 == rndNb2)
            {
                //Affiche le label
                lblNull.Visible = true;

                //ajoute au compteur N
                N++;
            }

            else
            {
                //affiche le label
                lblGagnant1.Visible = true;

                //ajoute au compteur V1 && D2
                D2++;
                V1++;
            }
        }
    }
}
