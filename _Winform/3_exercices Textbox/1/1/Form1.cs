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
        public Form1()
        {
            InitializeComponent();
        }

        //Methode quand le texte box est clique
        private void textBox1_Click(object sender, EventArgs e)
        {
            //Efface le texte
            textBox1.Text = "";

            //Change la couleur pour noir
            textBox1.ForeColor = Color.Black;
        }
    }
}
