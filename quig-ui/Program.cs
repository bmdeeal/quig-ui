using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
quig-ui -- a C# based front end for editing and playing quig games
(C) 2022 B.M.Deeal <brenden.deeal@gmail.com>

This program is free software: you can redistribute it and/or modify it under
the terms of the GNU General Public License as published by the Free Software
Foundation, either version 3 of the License, or (at your option) any later
version.

This program is distributed in the hope that it will be useful, but WITHOUT ANY
WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A
PARTICULAR PURPOSE. See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License along with
this program. If not, see <https://www.gnu.org/licenses/>.

TODO list:
    * maybe ask to associate .quig files with quig-ui on first launch? dunno
    * should the settings all be on one form?
    * loads of testing -- quig-ui seems stable enough, but I need tests to know if it is or not
    * nicer message boxes that look like the rest of the program compared to the standard MessageBox
    * a few refactorings for duplicated functionality/snippets
    * a few more refactorings for things that should be in different places (a bunch of stuff in this class probably shouldn't be)
    * debug mode should probably log stuff to a file
*/
namespace quig_ui
{
    static class Program
    {
        //program settings
        public static ProgramSettings settings=new ProgramSettings();

        //program version info
        public const int versionMajor = 1; //increment for significant changes to behavior
        public const int versionMinor = 0; //increment every time we do a -release version;.10 is bigger than .1
        public const string versionStatus = "beta"; //there are three states for each release: alpha (stuff is definitely broken), beta, release
        public const string versionExtra = "2"; //stuff like alpha1, beta2a, etc -- leave this blank if we're on release status
        public static readonly string versionString = $"{versionMajor}.{versionMinor}-{versionStatus}{versionExtra}";

        //debug mode toggles some extra info about exceptions mostly
        //once we're on a full release, then we can turn this off by default
        //it can be enabled/disabled by double-clicking in the About dialog and setting the checkbox that appears
        public static bool debug = true;

        //create a .png file of a given color
        public static bool makePNG(string filename, int width, int height, int r, int g, int b)
        {
            try
            {
                var bmp = new Bitmap(width, height);
                var gfx = Graphics.FromImage(bmp);
                gfx.FillRectangle(new SolidBrush(Color.FromArgb(r, g, b)), 0, 0, width, height);
                bmp.Save(filename);
                gfx.Dispose();
                bmp.Dispose();
            }
            //for if bmp.Save fails
            catch (ExternalException ex)
            {
                if (debug) { MessageBox.Show($"debug notice: {ex}"); }
                return false;
            }
            return true;
        }

        //run a program
        //checks %PATH%, naturally
        //ignores some exceptions that probably would occur normally, returns false if they occur
        public static bool runProgram(string name, string args)
        {
            try
            {
                Process.Start(name, args);
            }
            catch (Exception ex) when (ex is Win32Exception || ex is ObjectDisposedException || ex is FileNotFoundException)
            {
                if (debug) { MessageBox.Show($"debug notice: {ex}"); }
                return false;
            }
            return true;
        }

        //run a file, like if you double clicked it
        //ignores some exceptions that probably would occur normally, returns false if they occur
        //still lets InvalidOperationException, ArgumentNullException, and PlatformNotSupportedException through
        //we catch FileNotFoundException but like, the docs have the least helpful statement on when it can happen or why this particular error is thrown
        //apparently this checks %PATH% despite operating on files -- I had the PuTTY readme show up while testing this, so take note of that, always pass a fully qualified pathname
        public static bool runFile(string name)
        {
            try
            {
                Process.Start(new ProcessStartInfo(name) { UseShellExecute = true });
            }
            catch (Exception ex) when (ex is Win32Exception || ex is ObjectDisposedException || ex is FileNotFoundException)
            {
                if (debug) { MessageBox.Show($"debug notice: {ex}"); }
                return false;
            }
            return true;
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            settings.loadSettings();
            //both of these need to be true to load a game from the command line
            var argSuccess = false; //was handling the arguments a success? were the files all found?
            var loadingFile = false; //are we currently loading a file?
            //read the argument
            //TODO: we only check the first argument
            if (args.Length > 0)
            {
                loadingFile = true;
                //we accept .quig and .png files and figure the rest out, since both are needed
                //TODO: this is repeated in like 3 places and I need to refactor it
                if (Path.GetExtension(args[0]) == ".png")
                {
                    settings.graphicsFile = args[0];
                    settings.codeFile = Path.ChangeExtension(args[0], ".quig");
                }
                else if (Path.GetExtension(args[0]) == ".quig")
                {
                    settings.codeFile = args[0];
                    settings.graphicsFile = Path.ChangeExtension(args[0], ".png");
                }
                else
                {
                    MessageBox.Show($"error: unknown extension for '{args[0]}'!\nDid not load file.");
                    loadingFile = false;
                    argSuccess = false;
                }
            }
            //handle loading from argument
            if (loadingFile)
            {
                //check if the .quig mentioned exists
                if (File.Exists(settings.codeFile))
                {
                    //check if the .png file exists
                    if (File.Exists(settings.graphicsFile))
                    {
                        argSuccess = true;
                    }
                    //bail out (TODO: should we ask to create one?)
                    else
                    {
                        MessageBox.Show($"error: cannot find '{settings.graphicsFile}'!\nDid not load game.");
                        argSuccess = false;
                    }
                }
                //bail out
                else
                {
                    MessageBox.Show($"error: cannot find '{settings.codeFile}'!\nDid not load game.");
                    argSuccess = false;
                }
            }
            //show the open file
            if (loadingFile && argSuccess)
            {
                new Form_OpenFile().Show();
            }
            //no file loaded
            else
            {
                new Form_NoFile().Show();
            }
            Application.Run();
        }
        
    }
}
