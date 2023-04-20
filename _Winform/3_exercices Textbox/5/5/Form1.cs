using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        int Nb1, Nb2, Res = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Convertis les reponse
            int.TryParse(textBox1.Text, out Nb1);
            int.TryParse(textBox2.Text, out Nb2);

            //Addition des deux nombres
            Res = Nb1 + Nb2;

            //Affiche les reponses
            label1.Text = Res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
