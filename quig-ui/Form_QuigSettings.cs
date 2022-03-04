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
    public partial class Form_QuigSettings : Form
    {
        public string lastScaleFactor = "";
        public Form_QuigSettings()
        {
            InitializeComponent();
        }

        //Cancel changing settings.
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Save settings.
        //TODO: save to disk
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (radioButtonHardware.Checked)
            {
                Program.settings.graphicsMode = ProgramSettings.GraphicsMode.hardware;
            }
            else if (radioButtonHardwareVSync.Checked)
            {
                Program.settings.graphicsMode = ProgramSettings.GraphicsMode.hardware_vsync;
            }
            else if (radioButtonSoftware.Checked)
            {
                Program.settings.graphicsMode = ProgramSettings.GraphicsMode.software;
            }
            Program.settings.fullscreen = checkBoxFullscreen.Checked;
            Program.settings.quigLocation = textBoxQuigLocation.Text;
            Program.settings.autoScale = radioButtonAutoScale.Checked; //we ignore if the other one is checked since radio buttons automatically handle that
            if (Int32.TryParse(textBoxCustomScale.Text, out int tempnum))
            {
                Program.settings.scaleFactor = tempnum;
            }
            Program.settings.saveSettings();
            Close();
        }

        //Load saved settings.
        private void Form_QuigSettings_Load(object sender, EventArgs e)
        {
            if (Program.settings.graphicsMode == ProgramSettings.GraphicsMode.hardware)
            {
                radioButtonHardware.Checked = true;
            }
            else if (Program.settings.graphicsMode == ProgramSettings.GraphicsMode.hardware_vsync)
            {
                radioButtonHardwareVSync.Checked = true;
            }
            else if (Program.settings.graphicsMode == ProgramSettings.GraphicsMode.software)
            {
                radioButtonSoftware.Checked=true;
            }
            checkBoxFullscreen.Checked = Program.settings.fullscreen;
            textBoxQuigLocation.Text = Program.settings.quigLocation;
            textBoxCustomScale.Text = Program.settings.scaleFactor.ToString();
            lastScaleFactor = textBoxCustomScale.Text;
            if (Program.settings.autoScale)
            {
                radioButtonAutoScale.Checked = true;
            }
            else
            {
                radioButtonCustomScale.Checked = true;
            }

        }
        //Allow the user to locate where quig is.
        //I originally wasn't going to make this an option, but at least at the moment, it's required.
        private void buttonQuigBrowse_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog
            {
                Title = "Select the location of quig.exe...",
                Filter = "Applications (*.exe)|*.exe|All files (*.*)|*.*"
            };
            openDialog.ShowDialog();
            if (openDialog.FileName != "")
            {
                textBoxQuigLocation.Text = openDialog.FileName;
            }
        }

        //Reset 
        private void buttonReset_Click(object sender, EventArgs e)
        {
            checkBoxFullscreen.Checked = false;
            textBoxQuigLocation.Text = "quig.exe";
            radioButtonHardware.Checked = true;
        }

        private void textBoxCustomScale_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCustomScale.Text != "")
            {
                if (Int32.TryParse(textBoxCustomScale.Text, out int result))
                {
                    textBoxCustomScale.Text = result.ToString();
                }
                else
                {
                    textBoxCustomScale.Text = lastScaleFactor;
                }
            }
        }
    }
}
