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

        //set status of the hidden debug toggle and set up the about text
        private void Form_About_Load(object sender, EventArgs e)
        {
            checkBoxDebug.Checked = Program.debug;
            labelVersion.Text = $"This is quig-ui, version {Program.versionString}.";
        }

        //allow enabling debug mode for quig-ui
        private void Form_About_DoubleClick(object sender, EventArgs e)
        {
            checkBoxDebug.Enabled= !checkBoxDebug.Enabled;
            checkBoxDebug.Visible = !checkBoxDebug.Visible;
        }

        //checkbox to toggle debug mode
        private void checkBoxDebug_Click(object sender, EventArgs e)
        {
            Program.debug = checkBoxDebug.Checked;
        }
    }
}
