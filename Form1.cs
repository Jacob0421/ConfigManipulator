using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ConfigManipulator
{
    public partial class Form1 : Form
    {

        private Dictionary<string, bool> DaysOpen = new Dictionary<string, bool>() {
            ["Monday"] = true,
            ["Tuesday"] = false,
            ["Wednesday"] = false,
            ["Thursday"] = false,
            ["Friday"] = false,
            ["Saturday"] = false,
            ["Sunday"] = false
        };

        private string configPath = @"../../../FileSystemWatcher/Config/FileSystemWatcher.config";

        public Form1()
        {
            InitializeComponent();
            fileMoverFields.Visible = false;
            groupBox_WindowDays.Controls.OfType<CheckBox>().ToList().ForEach(x => x.CheckedChanged += WindowDays_Changed);
        }

        private void TextBox_InputPath_FolderSelector(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                textbox_inputPath.Text = dialog.SelectedPath;
            }
        }

        private void TextBox_DestinationPath_FolderSelector(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox_destinationPath.Text = dialog.SelectedPath;
            }
        }

        private void Dropdown_JobSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropdown_JobSelector.Text == "FileMover")
            {
                fileMoverFields.Visible = true;
            } else
            {
                fileMoverFields.Visible = false;
            }
        }

        private void WindowDays_Changed(object sender, EventArgs e)
        {
            var c = (CheckBox)sender;
            DaysOpen[c.Text] = !DaysOpen[c.Text];
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            textBox_jobName.Text = string.Empty;
            textbox_inputPath.Text = string.Empty;
            textBox_destinationPath.Text = string.Empty;
            textBox_fileNamePattern.Text = string.Empty;
            dateTimePicker_windowStart.Text = DateTime.Now.ToLongTimeString();
            dateTimePicker_windowEnd.Text = DateTime.Now.ToLongTimeString();
            groupBox_WindowDays.Controls.OfType<CheckBox>().ToList().ForEach(c => c.Checked = false);
            DaysOpen.ToList().ForEach(x => DaysOpen[x.Key] = false);
            richTextBox_output.Text = string.Empty;
            dropdown_JobSelector.SelectedItem = null;
            dropdown_JobSelector.Text = "-- Select Job Type --";
        }

        private void Button_Validate_Click(object sender, EventArgs e)
        {
            bool isValidJob = false;
            List<string> errorMessages = new List<string>();
            List<string> warningMessages = new List<string>();

            if (textBox_jobName.Text == String.Empty) {
                errorMessages.Add($"{DateTime.Now.ToLongTimeString()}: Valid Job name not entered.");
            }

            if(textbox_inputPath.Text == String.Empty || !Directory.Exists(textbox_inputPath.Text))
            {
                errorMessages.Add($"{DateTime.Now.ToLongTimeString()}: invalid input file path entered.");
            }

            if (textBox_destinationPath.Text == String.Empty || !Directory.Exists(textBox_destinationPath.Text))
            {
                errorMessages.Add($"{DateTime.Now.ToLongTimeString()}: invalid destination file path entered.");
            }

            if (DateTime.Parse(dateTimePicker_windowStart.Text) > DateTime.Parse(dateTimePicker_windowEnd.Text))
            {
                warningMessages.Add($"{DateTime.Now.ToLongTimeString()}: Window End occurs earlier in the day than Window Start. Please confirm this is expected");
            }

            
            if(!DaysOpen.ToList().Any(d => d.Value))
            {
                errorMessages.Add($"{DateTime.Now.ToLongTimeString()}: No open window days are selected.");
            }


            if (errorMessages.Count > 0)
            {
                foreach (string message in errorMessages)
                {
                    richTextBox_output.SelectionColor = Color.Red;
                    richTextBox_output.AppendText(message +"\n");
                }
            } else
            {
                isValidJob = true;
            }

            if (warningMessages.Count > 0)
            {
                foreach (string message in warningMessages)
                {
                    richTextBox_output.SelectionColor = Color.Orange;
                    richTextBox_output.AppendText(message + "\n");
                }

                isValidJob = true;
            }

            if(isValidJob)
            {
                button_test.Enabled = true;
                button_test.BackColor = Color.Gold;
                button_test.ForeColor = Color.Black;
            }
        }

        private void Button_Test_Click(object sender, EventArgs e)
        {
            List<string> outputMessages = new List<string>();

            int numOfValidFiles = Directory.GetFiles(textbox_inputPath.Text, textBox_fileNamePattern.Text).Count();
            outputMessages.Add($"Valid Files found: {numOfValidFiles.ToString()}");
            int totalNumOfFiles = Directory.GetFiles(textbox_inputPath.Text).Count();
            outputMessages.Add($"Total Files in Directory: {totalNumOfFiles.ToString()}");

            outputMessages.Add($"Tested Directory: {textbox_inputPath.Text}\n");
            outputMessages.Add($"Projected Output Directory: {textBox_destinationPath.Text}\n");

            string formattedMessage = "";
            foreach (string message in outputMessages)
            {
                formattedMessage += message + "\n";
            }

            formattedMessage += "\n\n" +
                "Please confirm if this is the expected result.";

            DialogResult validConfirmation = MessageBox.Show( formattedMessage, "Validation Confirmation",MessageBoxButtons.YesNo);

            if (validConfirmation == DialogResult.No) { 
                button_test.Enabled=false;
                button_test.BackColor = Color.LightGray;
            }

            if (validConfirmation == DialogResult.Yes)
            {
                button_submit.Enabled=true;
                button_submit.BackColor = Color.Green;
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {

            XDocument doc = XDocument.Load(configPath);
            XElement jobs = doc.Descendants("Jobs").First();
            int currentID = jobs.Elements("Job").Elements("JobID").Max(x => Int32.Parse(x.Value));

            List<string> windowDays = new List<string>();
            foreach (KeyValuePair<string, bool> item in DaysOpen)
            {
                if(item.Value)
                {
                    windowDays.Add( item.Key.Substring(0,3));
                }
            }

            XElement Job = new XElement("Job",
                    new XElement("JobID", currentID + 1),
                    new XElement("JobName", textBox_jobName.Text),
                    new XElement("JobType", dropdown_JobSelector.Text),
                    new XElement("InputPath", textbox_inputPath.Text),
                    new XElement("DestinationPath", textBox_destinationPath.Text),
                    new XElement("FileNamePattern", textBox_fileNamePattern.Text),
                    new XElement("WindowStart", dateTimePicker_windowStart.Text),
                    new XElement("WindowEnd", dateTimePicker_windowEnd.Text),
                    new XElement("WindowDays", String.Join("|", windowDays))
                );
            jobs.Add(Job);
            doc.Save(configPath);
        }
    }
}
