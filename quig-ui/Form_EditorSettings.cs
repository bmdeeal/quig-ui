using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//(C)2022 B.M.Deeal
//TODO: put GPL3 notice here
//TODO: should file association be on this page?
//TODO: should there be an option to associate .quig files with quig itself, or no?
//TODO: we should maybe add a way to try and find some common programs? eg, notepad++, gimp, etc

namespace quig_ui
{
    public partial class Form_EditorSettings : Form
    {
        public Form_EditorSettings()
        {
            InitializeComponent();
        }

        //reset to default options (just notepad and paint)
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxCode.Text = "notepad.exe";
            textBoxGraphics.Text = "mspaint.exe";
        }

        //cancel without saving
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //look for a code editor
        private void buttonCodeBrowse_Click(object sender, EventArgs e)
        {
            //TODO: if I can get this working on Linux, I'll need to edit how this operates
            //and I'd really need to figure out how to get a GUI editor that'd be available on most/all systems
            var openDialog = new OpenFileDialog
            {
                Title = "Select the code editor to use...",
                Filter = "Applications (*.exe)|*.exe|All files (*.*)|*.*",
                InitialDirectory=Environment.GetEnvironmentVariable("ProgramFiles")
            };
            openDialog.ShowDialog();
            if (openDialog.FileName != "")
            {
                textBoxCode.Text = openDialog.FileName;
            }
        }

        //look for a graphics editor
        private void buttonGraphicsBrowse_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog
            {
                Title = "Select the code editor to use...",
                Filter = "Applications (*.exe)|*.exe|All files (*.*)|*.*",
                InitialDirectory = Environment.GetEnvironmentVariable("ProgramFiles")
            };
            openDialog.ShowDialog();
            if (openDialog.FileName != "")
            {
                textBoxGraphics.Text = openDialog.FileName;
            }
        }

        //save and exit
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Program.settings.codeEditor = textBoxCode.Text;
            Program.settings.graphicsEditor = textBoxGraphics.Text;
            Program.settings.saveSettings();
            Close();
        }

        //populate the form
        private void Form_EditorSettings_Load(object sender, EventArgs e)
        {
            textBoxCode.Text = Program.settings.codeEditor;
            textBoxGraphics.Text = Program.settings.graphicsEditor;
        }

        //button to register quig-ui ias the default .quig file handler
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (AssociateFile.associateQuigUi())
            {
                MessageBox.Show("quig-ui is now the default editor for .quig files.");
            }
            else
            {
                MessageBox.Show("Could not associate .quig files with quig-ui.");
            }
        }
    }
}
