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

        public Form1()
        {
            InitializeComponent();
        }

        //Quand bouton de est clicke
        private void btnDe_Click(object sender, EventArgs e)
        {
            //Cree une variable entre 1 et 7
            int iD = rnd.Next(1, 7);

            //Change le text du bouton pour la variable
            lblNb.Text = iD.ToString();

            //Remet la variable visible
            lblNb.Visible = true;
        }
    }
}
