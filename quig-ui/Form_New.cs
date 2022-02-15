using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace quig_ui
{
    public partial class Form_New : Form
    {
        //was a new file created?
        public bool created = false;
        public Form_New()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            created = false;
            Close();
        }
    }
}
