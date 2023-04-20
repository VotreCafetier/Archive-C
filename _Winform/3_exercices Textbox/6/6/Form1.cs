using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _6
{
    public partial class Form1 : Form
    {
        int Nb = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Convertir en nombre entier
            int.TryParse(textBox1.Text, out Nb);

            if (int.TryParse(textBox1.Text, out Nb) == true)
            {
                label1.Text = "Vous avez entré un nombre entier";
            }

            else
            {
                label1.Text = "Veuillez entrer un nombre entier";
            }

        }
    }
}
