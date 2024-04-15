using ConfigManipulator.src;
using ConfigManipulator.src.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ConfigManipulator
{
    public partial class Form1 : Form
    {

        private List<TabPage> formTabs = new List<TabPage>();

        private string configPath = @"../../../FileSystemWatcher/Config/FileSystemWatcher.config";

        public Form1()
        {
            InitializeComponent();

            RemoveJobCreationFormTab("tabPage_createFileMover");
            RemoveJobCreationFormTab("tabPage_createCommandRunner");
        }

        private void RemoveJobCreationFormTab(string toBeRemovedName)
        {
            if (!formTabs.Where(x => x.Name == toBeRemovedName).Any())
            {
                formTabs.Add(tabControl_jobCreationFields.TabPages[toBeRemovedName]);
            }

            tabControl_jobCreationFields.TabPages.Remove(tabControl_jobCreationFields.TabPages[toBeRemovedName]);

        }

        private void InsertJobCreationFormTab(string toBeInsertedName)
        {

            foreach (TabPage page in  tabControl_jobCreationFields.TabPages)
            {
                RemoveJobCreationFormTab(page.Name);
            }

            tabControl_jobCreationFields.TabPages.Insert(0, formTabs.First(x => x.Name == toBeInsertedName));
        }

            private void TextBox_InputPath_FolderSelector(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                textBox_FM_inputPath.Text = dialog.SelectedPath;
            }
        }

        private void TextBox_DestinationPath_FolderSelector(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox_FM_destinationPath.Text = dialog.SelectedPath;
            }
        }

        private void Dropdown_JobSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_submit.Enabled = false;
            button_submit.BackColor = Color.LightGray;
            richTextBox_output.Text = String.Empty;
            switch(dropdown_JobSelector.Text) {
                case "FileMover":
                    InsertJobCreationFormTab("tabPage_createFileMover");
                    button_test.Visible = true;
                    break;
                case "CommandRunner":
                    InsertJobCreationFormTab("tabPage_createCommandRunner");
                    button_test.Visible = false;
                    break;
                default:
                    tabControl_jobCreationFields.Controls.Clear();
                    break;
            }
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            switch (dropdown_JobSelector.Text)
            {
                case "FileMover":
                    textBox_FM_jobName.Text = string.Empty;
                    textBox_FM_inputPath.Text = string.Empty;
                    textBox_FM_destinationPath.Text = string.Empty;
                    textBox_FM_fileNamePattern.Text = string.Empty;
                    dateTimePicker_FM_windowStart.Text = DateTime.Now.ToLongTimeString();
                    dateTimePicker_FM_windowEnd.Text = DateTime.Now.ToLongTimeString();
                    groupBox_FM_windowDays.Controls.OfType<CheckBox>().ToList().ForEach(c => c.Checked = false);
                    richTextBox_output.Text = string.Empty;
                    break;
                case "CommandRunner":
                    textBox_CR_jobName.Text = string.Empty;
                    textBox_CR_command.Text = string.Empty;
                    textBox_CR_arguments.Text = string.Empty;
                    checkBox_CR_adminPermissionsNeeded.Checked = false;
                    checkBox_CR_retryOnFailure.Checked = false;
                    numericUpDown_CR_retryCount.Text = "0";
                    dateTimePicker_CR_CommandRunTime.Text = DateTime.Now.ToLongTimeString();
                    groupBox_FM_windowDays.Controls.OfType<CheckBox>().ToList().ForEach(c => c.Checked = false);
                    richTextBox_output.Text = string.Empty;
                    break;
            }
            dropdown_JobSelector.SelectedItem = null;
            dropdown_JobSelector.Text = "-- Select Job Type --";
        }

        private void Button_Validate_Click(object sender, EventArgs e)
        {
            bool isValidJob = false;
            List<string> errorMessages = new List<string>();
            List<string> warningMessages = new List<string>();

            switch (dropdown_JobSelector.Text)
            {
                case "FileMover":
                    errorMessages.AddRange(FileMoverMethods.ValidateFileMoverFields(tabPage_createFileMover)["error"]);
                    warningMessages.AddRange(FileMoverMethods.ValidateFileMoverFields(tabPage_createFileMover)["warning"]);
                    break;
                case "CommandRunner":
                    errorMessages.AddRange(CommandRunnerMethods.ValidateCommandRunnerFields(tabPage_createCommandRunner)["error"]);
                    warningMessages.AddRange(CommandRunnerMethods.ValidateCommandRunnerFields(tabPage_createCommandRunner)["warning"]);
                    break;
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
                    DialogResult userInput = MessageBox.Show(message, "Warning", MessageBoxButtons.YesNo);
                    if (userInput == DialogResult.No)
                    {
                        isValidJob = false;
                    }
                }
            }

            if(isValidJob)
            {
                richTextBox_output.SelectionColor = Color.Green;
                richTextBox_output.AppendText("Validation Complete. All necessary fields filled and in the correct format\n");

                switch (dropdown_JobSelector.Text)
                {
                    case "FileMover":
                        button_test.Enabled = true;
                        button_test.BackColor = Color.Gold;
                        button_test.ForeColor = Color.Black;
                        break;
                    case "CommandRunner":
                        button_submit.Enabled = true;
                        button_submit.BackColor = Color.Green;
                        break;
                }
            }
        }



        private void Button_Test_Click(object sender, EventArgs e)
        {
            List<string> outputMessages = new List<string>();

            int numOfValidFiles = Directory.GetFiles(textBox_FM_inputPath.Text, textBox_FM_fileNamePattern.Text).Count();
            outputMessages.Add($"Valid Files found: {numOfValidFiles.ToString()}");
            int totalNumOfFiles = Directory.GetFiles(textBox_FM_inputPath.Text).Count();
            outputMessages.Add($"Total Files in Directory: {totalNumOfFiles.ToString()}");

            outputMessages.Add($"Tested Directory: {textBox_FM_inputPath.Text}\n");
            outputMessages.Add($"Projected Output Directory: {textBox_FM_destinationPath.Text}\n");

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

            switch (dropdown_JobSelector.Text)
            {
                case "FileMover":

                    foreach (CheckBox box in groupBox_FM_windowDays.Controls)
                    {
                        if (box.Checked)
                        {
                            windowDays.Add(box.Text.Substring(0, 3));
                        }
                    }

                    FileMover newFileMover = new FileMover()
                    {
                        JobID = currentID + 1,
                        JobName = textBox_FM_jobName.Text,
                        JobType = dropdown_JobSelector.Text,
                        InputPath = textBox_FM_inputPath.Text,
                        DestinationPath = textBox_FM_destinationPath.Text,
                        WindowStart = dateTimePicker_FM_windowStart.Text,
                        WindowEnd = dateTimePicker_FM_windowEnd.Text,
                        DaysRun = windowDays
                    };

                    jobs.Add(FileMoverMethods.GenerateConfigXML(newFileMover));
                    break;
                case "CommandRunner":


                    foreach (CheckBox box in groupBox_CR_DayCommandIsRun.Controls)
                    {
                        if (box.Checked)
                        {
                            windowDays.Add(box.Text.Substring(0, 3));
                        }
                    }
                    CommandRunner newCommandRunner = new CommandRunner() {
                        JobID = currentID + 1,
                        JobName = textBox_FM_jobName.Text,
                        JobType = dropdown_JobSelector.Text,
                        Command = textBox_CR_command.Text,
                        Arguments = textBox_CR_arguments.Text,
                        AdminNeeded = checkBox_CR_adminPermissionsNeeded.Checked,
                        RetryOnFailure = checkBox_CR_retryOnFailure.Checked,
                        RetryCount = (int)numericUpDown_CR_retryCount.Value,
                        CommandRunTime = dateTimePicker_CR_CommandRunTime.Text,
                        DaysRun = windowDays
                    };

                    jobs.Add(CommandRunnerMethods.GenerateConfigXML(newCommandRunner));
                    break;
            }


            doc.Save(configPath);
        }

        private void checkBox_CR_retryOnFailure_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown_CR_retryCount.Enabled = !numericUpDown_CR_retryCount.Enabled;

            label_CR_retryCount.Visible = !label_CR_retryCount.Visible;
            numericUpDown_CR_retryCount.Visible = !numericUpDown_CR_retryCount.Visible;
        }
    }
}
