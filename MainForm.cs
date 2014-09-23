using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DuelParser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void UnitTestButton_Click(object sender, EventArgs e)
        {
            InstructionTextBox.Text = "";

            List<string> lines = FileReader.ReadFromFile("C:\\Users\\Ossuary\\Documents\\Visual Studio 2010\\Projects\\DuelParser\\DuelParser\\SampleTextFiles\\SampleFistsDuel_AwkwardCaller.txt");
            lines = FileReader.RemoveNonDuelText(lines);
            lines = FileReader.RemoveExtraneousDuelText(lines);

            string output = "";
            foreach (string line in lines)
            {
                output += line + "\r\n";
            }

            InstructionTextBox.Text = output;
        }
    }
}
