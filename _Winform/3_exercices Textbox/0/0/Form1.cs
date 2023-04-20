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
        int Nb1, Nb2, Res = 0;
        public Form1()
        {
            InitializeComponent();
        }

        //Methode verification deux avec le bouton
        private bool Verification()
        {
            if (tbNb1.Text == "")
            {
                return false;
            }

            else if (tbNb2.Text == "")
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        //methode verification deux
        private bool Verification2()
        {
            if (tbNb3.Text == "")
            {
                return false;
            }

            else if (tbNb4.Text == "")
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            //enregistrer dans une variable
            int.TryParse(tbNb1.Text, out Nb1);
            int.TryParse(tbNb2.Text, out Nb2);

            //Calcul
            Res = Nb1 * Nb2;
            lblResultat.Text = Res.ToString();

            //changer la couleur si rien dedans
            if (Verification() == false)
            {
                lblNb1.ForeColor = Color.Red;
                lblNb2.ForeColor = Color.Red;
            }

            //Effacer les reponses
            tbNb1.Text = "";
            tbNb2.Text = "";
        }

        private void tbNb3_TextChanged(object sender, EventArgs e)
        {
            //Verification
            if (Verification2() == false)
            {
                lblNb3.ForeColor = Color.Red;
                lblNb4.ForeColor = Color.Red;
            }

            //Convertir le texte en nombre dans la variable
            int.TryParse(tbNb3.Text, out Nb1);
            int.TryParse(tbNb3.Text, out Nb2);

            //calculer
            Res = Nb1 * Nb2;

            //Afficher
            tbRes.Text = Res.ToString();
        }

        private void tbEcriver_TextChanged(object sender, EventArgs e)
        {
            //Apparais si rien d'ecris
            if (tbEcriver.Text == "")
            {
                lblRien.Visible = true;
            }

            else
            {
                lblRien.Visible = false;
            }
        }

        private void tbNb4_TextChanged(object sender, EventArgs e)
        {
            //Verification & changement de couleur
            if (Verification2() == false)
            {
                lblNb3.ForeColor = Color.Red;
                lblNb4.ForeColor = Color.Red;
            }

            else
            {
                lblNb3.ForeColor = Color.Black;
                lblNb4.ForeColor = Color.Black;
            }

            //Convertir le texte en nombre dans la variable
            int.TryParse(tbNb3.Text, out Nb1);
            int.TryParse(tbNb4.Text, out Nb2);

            //calculer
            Res = Nb1 * Nb2;

            //Afficher
            tbRes.Text = Res.ToString();
        }

        private void tbRes_TextChanged(object sender, EventArgs e)
        {
            Nb1 = 0;
            Nb2 = 0;
            Res = 0;
            //Verification
            if (Verification2() == false)
            {
                lblNb3.ForeColor = Color.Red;
                lblNb4.ForeColor = Color.Red;
            }

            //Convertir le texte en nombre dans la variable
            int.TryParse(tbNb3.Text, out Nb1);
            int.TryParse(tbNb4.Text, out Nb2);

            //calculer
            Res = Nb1* Nb2;

            //Afficher
            tbRes.Text = Res.ToString();
        }
    }
}
