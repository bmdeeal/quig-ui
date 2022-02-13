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
    public partial class Form_About : Form
    {
        public Form_About()
        {
            InitializeComponent();
        }

        //button to close the form
        private void buttonOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
