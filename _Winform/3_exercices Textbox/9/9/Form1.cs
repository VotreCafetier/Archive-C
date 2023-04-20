using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Methode de verification
        private bool Verification()
        {
            if (tbIdentifiant.Text == "")
            {
                return true;
            }

            else if (tbMdp.Text == "")
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Verification();
            if (Verification() == false)
            {
                btnConnect.Enabled = true;
            }

            else
            {
                btnConnect.Enabled = false;
            }
        }

        private void tbIdentifiant_TextChanged(object sender, EventArgs e)
        {
            Verification();
            if (Verification() == false)
            {
                btnConnect.Enabled = true;
            }

            else
            {
                btnConnect.Enabled = false;
            }
        }

        private void tbMdp_TextChanged(object sender, EventArgs e)
        {
            Verification();
            if (Verification() == false)
            {
                btnConnect.Enabled = true;
            }

            else
            {
                btnConnect.Enabled = false;
            }
        }
    }
}
