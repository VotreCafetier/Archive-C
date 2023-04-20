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
        string Age, nom;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            //mettre la le  text de tbAge dans la var age
            Age = tbAge.Text;

            //mettre le text nom dans nom
            nom = tbNom.Text;

            //trimer les variables
            Age = Age.Trim();
            nom = nom.Trim();
            
            //Changer le texte
            lblEntre.Text = "Bienvenu " + nom + ". Vous avez " + Age + " ans.";

            //changer la visibilite du texte
            lblEntre.Visible = true;
        }
    }
}
