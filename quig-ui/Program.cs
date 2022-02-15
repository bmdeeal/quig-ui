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
    * add a way to associate .quig files with quig-ui (maybe even ask that on first launch?)
    * creating a new empty .quig and .png file [in progress]
    * loading a .quig file should 
    * loads of testing
    * nice "generic" message boxes that look like the rest of the program
    * a few refactorings for duplicated functionality
    * a few more refactorings for things that should be in different places (a bunch of stuff in this class probably shouldn't be)
*/
namespace quig_ui
{
    static class Program
    {
        public static ProgramSettings settings=new ProgramSettings();

        //debug mode toggles some extra info about exceptions mostly
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
        //we catch FileNotFoundException but like, the docs have the least helpful statement on when it can happen or why thi particular error is thrown
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
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //TODO: handle arguments and use Form_OpenFile if we're passed a filename
            settings.loadSettings();
            new Form_NoFile().Show();
            Application.Run();
        }
        
    }
}
