using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//(C)2022 B.M.Deeal
//TODO: put GPL3 notice here

namespace quig_ui
{
    public partial class Form_Close : Form
    {
        public bool exiting = false;
        public Form_Close()
        {
            InitializeComponent();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            exiting = true;
            Close();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            exiting = false;
            Close();
        }
    }
}
