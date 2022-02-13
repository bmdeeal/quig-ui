using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace quig_ui
{
    public partial class Form_MissingGraphics : Form
    {
        public enum Result {
            New, Copy, Cancel
        }

        Result result=Result.Cancel;
        public Form_MissingGraphics()
        {
            InitializeComponent();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently not implemented...");
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently not implemented...");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            result = Result.Cancel;
            Close();
        }
    }
}
