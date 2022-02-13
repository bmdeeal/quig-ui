using System;
using System.Collections.Generic;
using System.Linq;
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
    * add a way to associate .quig files with quig-ui
    * creating a new empty .quig and .png file
    * quig-ui should make sure that 
    * if I can, it should talk about if the 
    * loads of testing
    * I think a few dialogs don't work
    * nicer dialog boxes that fit the rest of everything
    * a few refactorings for duplicated functionality
*/
namespace quig_ui
{
    static class Program
    {
        public static ProgramSettings settings=new ProgramSettings();
        public static bool debug = true;
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
