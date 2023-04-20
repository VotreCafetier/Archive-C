using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        int iN = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            lblN.Text = iN.ToString();
            iN++;
            lblN.Text = iN.ToString();

            if (iN < 1)
            {
                iN++;
            }

            else if (iN > 9)
            {
                iN--;
            }
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            lblN.Text = iN.ToString();
            iN--;
            lblN.Text = iN.ToString();

            if (iN < 1)
            {
                iN++;
            }

            else if (iN > 9)
            {
                iN--;
            }
        }
    }
}
