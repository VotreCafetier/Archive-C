using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        //Var
        Random rnd = new Random();
        int compteur = 3;
        int rndNb;

        public Form1()
        {
            InitializeComponent();
            rndNb = rnd.Next(1, 21);
            
        }

        private void btnEssayer_Click(object sender, EventArgs e)
        {
            //Var
            string temp = "";

            //Si compteur = 4 change de nombre
            if (compteur == 4)
            {
                tbNb.Text = "";
                lblIndice.Text = "";
                temp = RndToString();
                lbltemp.Text = temp;
            }

            //Prend le chiffre du label invisible
            else
            {
                temp = rndNb.ToString();
            }

            //Enleve du compteur
            compteur--;
            lblNb.Text = compteur.ToString();

            //Creer un pop-up quand compteur = 0
            if (compteur == 0)
            {
                MessageBox.Show("Vous n'avez plus d'essai ! Le nombre était " + lbltemp.Text + ". Recommencer ?");
                compteur = 4;
            }

            //Referme le if
            else
            {
                //Rien mettre
            }

            if (tbNb.Text == rndNb.ToString())
            {
                lblIndice.ForeColor = Color.Green;
                lblIndice.Text = "Bravo vous avez trouvé";
            }

            else
            {
                int temp1, temp2 = 0;
                int.TryParse(tbNb.Text, out temp1);
                int.TryParse(lbltemp.Text, out temp2);
                if (temp2 < temp1)
                {
                    lblIndice.ForeColor = Color.Red;
                    lblIndice.Text = "Mon nombre est plus petit";
                }

                else
                {
                    lblIndice.ForeColor = Color.Red;
                    lblIndice.Text = "Mon nombre est plus grand";
                }
            }
        }

        //Génère le chiffre en méthode
        private string RndToString()
        {
            //var
            

            //quand compteur atteint 4 (recommence il re creer un nombre)
            if (compteur == 4)
            {
                rndNb = rnd.Next(1, 21);
                return rndNb.ToString();
            }
            return rndNb.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rndNb = rnd.Next(1, 21);
        }

    }
}
