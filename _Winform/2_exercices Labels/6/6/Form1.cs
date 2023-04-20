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
        int compteur = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            compteur++;
            switch (compteur)
            {
                case 1 :
                    label1.Text = "Hello World";
                    break;
                case 2 :
                    label1.Text = "Bonjour le monde";
                    break;

                case 3 :
                    label1.Text = "Hola Mundo";
                    break;

                case 4 :
                    label1.Text = "Ciao Mundo";
                    break;

                case 5 :
                    label1.Text = "Hallo Welt";
                    compteur = 0;
                    break;

                default :
                    break;
            }
        }
    }
}
