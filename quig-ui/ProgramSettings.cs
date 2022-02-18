using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

//(C)2022 B.M.Deeal
//TODO: put GPL3 notice here

namespace quig_ui
{
    //Holds settings for the program and any global state.
    //TODO: we should explicitly force default settings in some spots; make a function that does this
    //TODO: possible Linux mode if this works with Mono
    class ProgramSettings
    {
        string defaultConfigLocation = Path.Combine(AppContext.BaseDirectory, "quig-ui.cfg");
        //location of quig
        public string quigLocation = "quig.exe";
        //what graphics mode to use
        public enum GraphicsMode
        {
            hardware = 0,
            hardware_vsync = 1,
            software = 2
        }
        //graphics settings
        public bool fullscreen = false;
        public GraphicsMode graphicsMode = GraphicsMode.hardware;
        //currently open files
        public string codeFile = ""; //should have .quig extension
        public string graphicsFile = ""; //should have .png extension
        //file editors
        public string codeEditor = "notepad.exe"; //.quig editor
        public string graphicsEditor = "mspaint.exe"; //.png editor

        //Load settings from a file.
        //returns false if settings didn't load
        public bool loadSettings(string fileName)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    //grab the data, check the header
                    var data = new List<string>(File.ReadAllLines(fileName));
                    if (data[0] != "@quig-ui-version=1")
                    {
                        MessageBox.Show($"Error loading config file!\nIncorrect header found...\nUsing default settings.");
                        return false;
                    }
                    //parse the rest of the lines
                    data.RemoveAt(0);
                    foreach (string line in data)
                    {
                        //skip blank lines
                        if (line=="") { continue; }
                        //split to pairs
                        var keypair = line.Split(@"=", 2);
                        //if a pair is invalid, complain
                        if (keypair.Length < 2)
                        {
                            MessageBox.Show($"Error loading config file!\nCould not understand '{line}', ignoring...");
                            continue;
                        }
                        //process each pair
                        switch (keypair[0])
                        {
                            case "@quig-location":
                                quigLocation = keypair[1];
                                break;
                            case "@code-editor":
                                codeEditor = keypair[1];
                                break;
                            case "@graphics-editor":
                                graphicsEditor = keypair[1];
                                break;
                            case "@graphics-mode":
                                int result = 0;
                                var success = int.TryParse(keypair[1], out result);
                                if (success && result >= 0 && result < 3)
                                {
                                    graphicsMode = (GraphicsMode)result;
                                }
                                else
                                {
                                    MessageBox.Show($"Error loading config file!\nUnknown graphics mode number '{keypair[1]}'.\nUsing default setting (hardware).");
                                    graphicsMode = GraphicsMode.hardware;
                                }
                                break;
                            case "@fullscreen":
                                fullscreen = keypair[1] == "True";
                                break;
                            default:
                                if (Program.debug) {
                                    MessageBox.Show($"debug: unknown keypair {line}...");
                                }
                                break;
                        }
                    }
                    return true;
                }
                else
                {
                    MessageBox.Show("No settings file exists.\nCreating new settings file and using default settings.");
                    saveSettings();
                    return false;
                }
            }
            //TODO: don't catch everything
            //it's really kind of painful trying to figure out what you have to handle
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading config file!\nThe following exception occurred: '{ex.Message}'.\nUsing default settings.");
                return false;
            }
        }

        //write data to a file
        //the format is dead simple: lines are a pair of = separated keys and values
        //keys start with an @ sign; values go immediately after the = sign
        //eg,
        //  @file-location=C:\Users\asdf\Desktop\something.txt
        //all characters are significant on the line, like leading/trailing space
        //the very first line is the version number
        public void saveSettings(string fileName)
        {
            try
            {
                using (StreamWriter outputFile = new StreamWriter(fileName, false))
                {
                    outputFile.WriteLine("@quig-ui-version=1");
                    outputFile.WriteLine($"@quig-location={quigLocation}");
                    outputFile.WriteLine($"@code-editor={codeEditor}");
                    outputFile.WriteLine($"@graphics-editor={graphicsEditor}");
                    outputFile.WriteLine($"@graphics-mode={(int)graphicsMode}");
                    outputFile.WriteLine($"@fullscreen={fullscreen}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving config file!\nThe following exception occurred: '{ex.Message}'.");
            }
        }

        //set up the arguments to pass to quig itself
        public string generateArguments()
        {
            //defaults if it can't be parsed for whatever reason
            string fullscreenSetting="--window";
            string graphicsSetting="--hard";
            //generate the argument string
            //TODO: I feel like there is a nicer way to do this
            switch (graphicsMode)
            {
                case GraphicsMode.hardware:
                    graphicsSetting = "--hard";
                    break;
                case GraphicsMode.hardware_vsync:
                    graphicsSetting = "--hard-vsync";
                    break;
                case GraphicsMode.software:
                    graphicsSetting = "--soft";
                    break;
            }
            if (fullscreen)
            {
                fullscreenSetting = "--fullscreen";
            }
            return $"{codeFile} {fullscreenSetting} {graphicsSetting}";
        }

        //overloads to load/save settings from the default filename
        public void loadSettings()
        {
            loadSettings(defaultConfigLocation);
        }
        public void saveSettings()
        {
            saveSettings(defaultConfigLocation);
        }
    }
}
