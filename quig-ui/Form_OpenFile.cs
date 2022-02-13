using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

//(C)2022 B.M.Deeal
//TODO: put GPL3 notice here

namespace quig_ui
{
    public partial class Form_OpenFile : Form
    {
        private bool exiting = true; //set this to false to close the window without ending the whole program
        public Form_OpenFile()
        {
            InitializeComponent();
        }

        //exit button for the program
        private void buttonExit_Click(object sender, EventArgs e)
        {
            exiting = true;
            Close();
        }

        //button to close the loaded game, but not the whole program
        private void buttonClose_Click(object sender, EventArgs e)
        {
            var form = new Form_Close();
            form.ShowDialog();
            if (form.exiting)
            {
                exiting = false;
                new Form_NoFile().Show();
                Close();
            }
            
        }

        //populate the interface with what the currently loaded file is
        private void Form_OpenFile_Load(object sender, EventArgs e)
        {
            toolStripStatusFilename.Text = $"Loaded '{Path.GetFileName(Program.settings.codeFile)}'.";
            Text = $"{Path.GetFileName(Program.settings.codeFile)} - quig-ui";
        }

        //close the program when the form closes, but only if the whole program should be closed
        //this should probably bring up the next dialog though
        private void Form_OpenFile_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (exiting)
            {
                Application.Exit();
            }
        }

        //if the program is closing, ask if that's okay
        private void Form_OpenFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (exiting)
            {
                var form = new Form_Exit();
                form.ShowDialog();
                if (!form.exiting)
                {
                    e.Cancel = true;
                }
            }
        }

        //button to show config settings
        private void buttonQuigConfig_Click(object sender, EventArgs e)
        {
            new Form_QuigSettings().ShowDialog();
        }

        //button to run the code editor
        private void buttonEditCode_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Program.settings.codeEditor, Program.settings.codeFile);
            }
            catch (Win32Exception)
            {
                MessageBox.Show("Could not start the code editor!\nSelect 'Configure editor settings' and make sure the location for your code editor is correct.");
            }
        }

        //button to run the game
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Program.settings.quigLocation, Program.settings.generateArguments());
            }
            catch (Win32Exception)
            {
                MessageBox.Show("Could not start quig!\nSelect 'Configure quig settings' and make sure the location of quig is correct.");
            }
        }

        //button to configure editor settings
        private void buttonConfigEditors_Click(object sender, EventArgs e)
        {
            new Form_EditorSettings().ShowDialog();
        }

        //button to run the graphics editor
        private void buttonEditGraphics_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Program.settings.graphicsEditor, Program.settings.graphicsFile);
            }
            catch (Win32Exception)
            {
                MessageBox.Show("Could not start the graphics editor!\nSelect 'Configure editor settings' and make sure the location for your graphics editor is correct.");
            }
        }

        //button to show the readme
        //TODO: make this look for the readme based on where quig is located
        private void buttonReadme_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo(@"readme.txt") { UseShellExecute=true });
            }
            catch (Win32Exception)
            {
                MessageBox.Show($"Could not open the quig readme.");
            }
        }
    }
}
