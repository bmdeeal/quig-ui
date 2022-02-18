using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace quig_ui
{
    public partial class Form_New : Form
    {
        //data to store in each new file
        //this probably should get moved elsewhere
        private static readonly string[] emptyFile = {
            @"--name of game: [untitled]",
            @"--game author: [unnamed]",
            @"",
            @"--called at start of game:",
            @"function init()",
            @"end",
            @"",
            @"--called every frame",
            @"function step()",
            "\tcls(100,120,170) --clear the screen, (red, green, blue)",
            "\ttext(\"quig-ui empty game\", 0,0, 1, 0) "+
            "--draw text (string, x-position, y-position, scale, drawing mode [0 is white on black, 1 is black on white, 2 is white on transparent, and 3 is black on transparent])",
            @"end"
        };

        //was a new file created?
        public bool created = false;

        public Form_New()
        {
            InitializeComponent();
        }

        //button to make a new .quig game
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            created = false;
            //check the extension, set the current files to what the user selected
            if (Path.GetExtension(textBoxGameLocation.Text) == ".png")
            {
                Program.settings.graphicsFile = textBoxGameLocation.Text;
                Program.settings.codeFile = Path.ChangeExtension(textBoxGameLocation.Text, ".quig");
            }
            else if (Path.GetExtension(textBoxGameLocation.Text) == ".quig")
            {
                Program.settings.codeFile = textBoxGameLocation.Text;
                Program.settings.graphicsFile = Path.ChangeExtension(textBoxGameLocation.Text, ".png");
            }
            else
            {
                MessageBox.Show($"error: '{textBoxGameLocation.Text}' is not a quig file!\nSelect a different filename.");
                return;
            }
            //check if the files exist
            //this behavior will probably change later, but right now, we bail out if either file exists
            if (File.Exists(Program.settings.codeFile))
            {
                //TODO: nicer dialog
                MessageBox.Show($"error: '{Program.settings.codeFile}' already exists!\nSelect a different filename.");
                return;
            }
            if (File.Exists(Program.settings.graphicsFile))
            {
                //TODO: nicer dialog
                MessageBox.Show($"error: '{Program.settings.graphicsFile}' already exists!\nSelect a different filename.");
                return;
            }
            //generate the graphics and code file
            if (!Program.makePNG(Program.settings.graphicsFile, 128, 128, 255, 0, 255))
            {
                MessageBox.Show("error: could not create graphics file...");
                return;
            }
            try
            {
                File.WriteAllLines(Program.settings.codeFile, emptyFile);
            }
            catch (Exception ex) when (ex is ArgumentException || ex is IOException ||  ex is NotSupportedException || ex is SystemException)
            {
                if (Program.debug) { MessageBox.Show($"debug notice: {ex}"); }
                MessageBox.Show("error: could not create code file...");
                return;
            }
            created = true;
            Close();
        }

        //button to just close the window
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            created = false;
            Close();
        }

        //button to find where to save
        private void buttonBrowseLocation_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog
            {
                DefaultExt = "quig",
                Filter = ".quig scripts|*.quig|.png images|*.png",
                AddExtension = true,
            };
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                textBoxGameLocation.Text = dialog.FileName;
            }

        }
    }
}
