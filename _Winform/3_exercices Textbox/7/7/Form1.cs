using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7
{
    public partial class Form1 : Form
    {
        string nom;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Fermer
            this.Close();
        }

        private void btnEntrer_Click(object sender, EventArgs e)
        {
            //Afficher
            lblBienvenu.Visible = true;

            //Cacher
            lblNom.Visible = false;
            tbNom.Visible = false;
            btnEntrer.Visible = false;

            //Entrer le txt dans var nom
            nom = tbNom.Text;

            //Changer le txt
            lblBienvenu.Text = "Bienvenu " + nom + " dans ce programme.";
        }
    }
}
