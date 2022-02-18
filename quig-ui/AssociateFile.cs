using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security;
using System.Text;
using System.Windows.Forms;

namespace quig_ui
{
    public class AssociateFile
    {
        //external calls to tell Explorer we're changing things
        [System.Runtime.InteropServices.DllImport("Shell32.dll")]
        private static extern int SHChangeNotify(int eventId, int flags, IntPtr item1, IntPtr item2);
        private const int SHCNE_ASSOCCHANGED = 0x8000000;
        private const int SHCNF_FLUSH = 0x1000;

        //generate the association for quig-ui
        public static bool associateQuigUi()
        {
            return setAssociation(
                ".quig",
                "quig_ui_file",
                ".quig game",
                Process.GetCurrentProcess().MainModule.FileName
            );
        }

        //set up an arbitrary file association
        public static bool setAssociation(string extension, string progID, string description, string path)
        {
            bool result =
                setKey($@"Software\Classes\{extension}", progID) &&
                setKey($@"Software\Classes\{progID}", description) &&
                setKey($@"Software\Classes\{progID}\shell\open\command", "\"" + path + "\" \"%1\"");
            if (result)
            {
                SHChangeNotify(SHCNE_ASSOCCHANGED, SHCNF_FLUSH, IntPtr.Zero, IntPtr.Zero);
                return true;
            }
            else
            {
                return false;
            }
        }

        //set a key value in the registry under the current user, catching common exceptions
        private static bool setKey(string keyPath, string value)
        {
            using var key = Registry.CurrentUser.CreateSubKey(keyPath);
            try
            {
                key.SetValue("", value);
                return true;
            }
            catch (Exception ex) when (ex is SecurityException || ex is IOException)
            {
                if (Program.debug) { MessageBox.Show($"debug notice: {ex}"); }
                return false;
            }
        }
    }
}