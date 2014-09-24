using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DuelParser
{
    public partial class MainForm : Form
    {
        //Location to pull files from - not to be changed mid-flight
        private readonly string startingFilename = Application.StartupPath;
        private readonly string sourceDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        //Location of files pulled in from dialog: will be changed based off the last successful load
        private string lastGoodFilename = "";
        private string lastGoodDirectory = "";

        private List<string> fileContents = new List<string>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void butSaveToDB_Click(object sender, EventArgs e)
        {
            // This should pop up a file thing to select where to save it, in case we don't want to save it to the main DB or w/e
            // and somehow we should make sure we aren't saving the same parsed log more than once?
        }

        private void checklbCallers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // probably will be eventually unnecessary 
        }

        private void textbLogFile_TextChanged(object sender, EventArgs e)
        {
            // Here is where we see mistakes after the initial load/parse and edit
            // It would be helpful if the fights were ordered fight 1 (round 1, 2, 3, etc), fight 2, fight 3, etc, instead of all mixed up
        }

        private void butParse_Click(object sender, EventArgs e)
        {
            // Once file is selected and callers clicked, this outputs to the log text box
            // Do some validation.
            if (fileContents.Count > 0)
            {
                // First, reset the bold font, so we don't forget.
                butParse.Font = new Font(butParse.Font.Name, butParse.Font.Size, FontStyle.Regular);
                butScout.Font = new Font(butParse.Font.Name, butParse.Font.Size, FontStyle.Bold);

                // And clear the address bar to reflect the file contents changing.
                textbLoadFile.ForeColor = SystemColors.InactiveCaption;
                textbLoadFile.Text = "Select a file to parse...";

                fileContents = FileReader.RemoveNonDuelText(fileContents);
                textbLogFile.Text = StringListToTextBox(fileContents);
            }
        }

        //Preps the list for text output
        public string StringListToTextBox(List<string> list)
        {
            string returnString = "";

            foreach (string line in list)
            {
                returnString += line + "\r\n";
            }

            return returnString;
        }

        private void butScout_Click(object sender, EventArgs e)
        {
            // This button takes the parsed (and possibly edited) log and outputs to the scouting text box

            if (fileContents.Count > 0)
            {
                // First, reset the bold font, so we don't forget.
                butParse.Font = new Font(butParse.Font.Name, butParse.Font.Size, FontStyle.Regular);
                butScout.Font = new Font(butParse.Font.Name, butParse.Font.Size, FontStyle.Regular);

                fileContents = FileReader.RemoveExtraneousDuelText(fileContents);
                // Clear the parse data
                textbLogFile.Text = "";
                // Write to the scout data
                textbOutput.Text = StringListToTextBox(fileContents);
            }
        }

        private void butSelectFile_Click(object sender, EventArgs e)
        {
            // First, reset the bold font, so we don't forget.
            butParse.Font = new Font(butParse.Font.Name, butParse.Font.Size, FontStyle.Regular);
            butScout.Font = new Font(butParse.Font.Name, butParse.Font.Size, FontStyle.Regular);

            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";

            //Be smart about where we set the dialog to, to prevent having to navigate up from C: everytime we open a file
            if (String.IsNullOrEmpty(lastGoodDirectory))
                theDialog.InitialDirectory = startingFilename;
            else
                theDialog.InitialDirectory = lastGoodDirectory;
            
            //Make sure the dialog was returned with "OK" before making any changes
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show("Loading file located at: " + theDialog.FileName.ToString());
                //Make sure the file exists first
                if (File.Exists(theDialog.FileName.ToString()))
                {
                    //Set global filename variables
                    lastGoodFilename = theDialog.FileName.ToString();
                    lastGoodDirectory = Path.GetDirectoryName(lastGoodFilename);
                    
                    //Set the address text box
                    textbLoadFile.ForeColor = Color.Black;
                    textbLoadFile.Text = theDialog.FileName.ToString();

                    //Set the parse button to bold, to lead the user on
                    butParse.Font = new Font(butParse.Font.Name, butParse.Font.Size, FontStyle.Bold);

                    //ReadFromFile is our custom method to dump the contents into a string list.
                    fileContents = FileReader.ReadFromFile(lastGoodFilename);
                }
            }
        }
    }
}
