using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//(C)2022 B.M.Deeal
//TODO: put GPL3 notice here

namespace quig_ui
{
    public partial class Form_NoFile : Form
    {
        private bool exiting = true; //set this to false to close the window without ending the whole program
        
        //call this to go to the next screen after a file is loaded/created
        public void loadFile()
        {
            exiting = false;
            new Form_OpenFile().Show();
            Close();
        }

        public Form_NoFile()
        {
            InitializeComponent();
        }

        //button to how the settings for quig itself
        private void buttonConfigQuig_Click(object sender, EventArgs e)
        {
            new Form_QuigSettings().ShowDialog();
        }

        //button to exit the application
        private void buttonExit_Click(object sender, EventArgs e)
        {
            exiting = true;
            Close();
        }

        //button to configure the code and image editors
        private void buttonConfigEditors_Click(object sender, EventArgs e)
        {
            new Form_EditorSettings().ShowDialog();
        }

        //button to load a game
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            //allow the user to find a game by selecting either the .png or the .quig
            var fileDialog = new OpenFileDialog
            {
                Filter = ".quig scripts|*.quig|.png images|*.png",
                Title = "Select a quig game..."
            };
            fileDialog.ShowDialog();
            //handle a cancelled dialog
            if (fileDialog.FileName=="") { return; }
            //sort out the extensions
            //TODO: refactor this into a function
            if (Path.GetExtension(fileDialog.FileName)==".png")
            {
                Program.settings.graphicsFile = fileDialog.FileName;
                Program.settings.codeFile = Path.ChangeExtension(fileDialog.FileName, ".quig");
            }
            else
            {
                Program.settings.codeFile = fileDialog.FileName;
                Program.settings.graphicsFile = Path.ChangeExtension(fileDialog.FileName, ".png");
            }
            //check if the graphics file exists
            //TODO: nothing is implemented so we don't actually bother with dialog.result
            if (!File.Exists(Program.settings.graphicsFile))
            {
                var dialog = new Form_MissingGraphics();
                dialog.ShowDialog();
                return;
            }
            //check if the quig file exists
            if (!File.Exists(Program.settings.codeFile))
            {
                MessageBox.Show("No .quig file!\n(TODO: ask user if they want a blank one)");
                return;
            }
            loadFile();
        }

        //close the whole program only if told to
        //if we're not closing the whole program, we're probably bringing up a different form
        private void Form_NoFile_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (exiting) { Application.Exit(); }
        }

        //ask whether or not to exit if we're closing the whole program
        private void Form_NoFile_FormClosing(object sender, FormClosingEventArgs e)
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

        //buttton to show about text and hidden debug toggle
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            new Form_About().ShowDialog();
        }

        //button to show the readme
        //TODO: refactor, make it so that it checks the quig directory for it instead of the quig-ui directory
        private void buttonReadme_Click(object sender, EventArgs e)
        {
            if (!Program.runFile(Path.Combine(AppContext.BaseDirectory, "readme.txt")))
            {
                MessageBox.Show($"Could not open the quig readme.");
            }
        }

        //button to show the dialog to make a new file
        private void buttonNew_Click(object sender, EventArgs e)
        {
            var dialog = new Form_New();
            dialog.ShowDialog();
            if (dialog.created)
            {
                loadFile();
            }
        }

        //set the verson string
        private void Form_NoFile_Load(object sender, EventArgs e)
        {
            Icon = quig_ui.Properties.Resources.Icon;
            labelVersion.Text = $"This is quig-ui, version {Program.versionString}.";
        }
    }
}
