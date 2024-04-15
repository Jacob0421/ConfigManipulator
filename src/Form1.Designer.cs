using System.Windows.Forms;

namespace ConfigManipulator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl_jobCreationFields = new System.Windows.Forms.TabControl();
            this.tabPage_createFileMover = new System.Windows.Forms.TabPage();
            this.groupBox_FM_windowDays = new System.Windows.Forms.GroupBox();
            this.checkBox_FM_tuesday = new System.Windows.Forms.CheckBox();
            this.checkBox_FM_wednesday = new System.Windows.Forms.CheckBox();
            this.checkBox_FM_thursday = new System.Windows.Forms.CheckBox();
            this.checkBox_FM_friday = new System.Windows.Forms.CheckBox();
            this.checkBox_FM_saturday = new System.Windows.Forms.CheckBox();
            this.checkBox_FM_sunday = new System.Windows.Forms.CheckBox();
            this.checkBox_FM_monday = new System.Windows.Forms.CheckBox();
            this.button_FM_folderBrowserDialog_destinationPath = new System.Windows.Forms.Button();
            this.button_FM_folderBrowserDialog_inputPath = new System.Windows.Forms.Button();
            this.textBox_FM_inputPath = new System.Windows.Forms.TextBox();
            this.textBox_FM_destinationPath = new System.Windows.Forms.TextBox();
            this.textBox_FM_fileNamePattern = new System.Windows.Forms.TextBox();
            this.label_windowEnd = new System.Windows.Forms.Label();
            this.dateTimePicker_FM_windowEnd = new System.Windows.Forms.DateTimePicker();
            this.label_windowStart = new System.Windows.Forms.Label();
            this.dateTimePicker_FM_windowStart = new System.Windows.Forms.DateTimePicker();
            this.label_fileNamePattern = new System.Windows.Forms.Label();
            this.label_destinationPath = new System.Windows.Forms.Label();
            this.label_inputPath = new System.Windows.Forms.Label();
            this.label_jobName = new System.Windows.Forms.Label();
            this.textBox_FM_jobName = new System.Windows.Forms.TextBox();
            this.tabPage_createCommandRunner = new System.Windows.Forms.TabPage();
            this.checkBox_CR_adminPermissionsNeeded = new System.Windows.Forms.CheckBox();
            this.label_CR_adminPermissionsNeeded = new System.Windows.Forms.Label();
            this.numericUpDown_CR_retryCount = new System.Windows.Forms.NumericUpDown();
            this.label_CR_retryCount = new System.Windows.Forms.Label();
            this.checkBox_CR_retryOnFailure = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_CR_arguments = new System.Windows.Forms.TextBox();
            this.label_CR_command = new System.Windows.Forms.Label();
            this.textBox_CR_command = new System.Windows.Forms.TextBox();
            this.groupBox_CR_DayCommandIsRun = new System.Windows.Forms.GroupBox();
            this.checkBox_CR_tuesday = new System.Windows.Forms.CheckBox();
            this.checkBox_CR_wednesday = new System.Windows.Forms.CheckBox();
            this.checkBox_CR_thursday = new System.Windows.Forms.CheckBox();
            this.checkBox_CR_friday = new System.Windows.Forms.CheckBox();
            this.checkBox_CR_saturday = new System.Windows.Forms.CheckBox();
            this.checkBox_CR_sunday = new System.Windows.Forms.CheckBox();
            this.checkBox_CR_monday = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_CR_CommandRunTime = new System.Windows.Forms.DateTimePicker();
            this.label_CR_jobName = new System.Windows.Forms.Label();
            this.textBox_CR_jobName = new System.Windows.Forms.TextBox();
            this.button_test = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_validate = new System.Windows.Forms.Button();
            this.button_submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dropdown_JobSelector = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.richTextBox_output = new System.Windows.Forms.RichTextBox();
            this.MainTabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl_jobCreationFields.SuspendLayout();
            this.tabPage_createFileMover.SuspendLayout();
            this.groupBox_FM_windowDays.SuspendLayout();
            this.tabPage_createCommandRunner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CR_retryCount)).BeginInit();
            this.groupBox_CR_DayCommandIsRun.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.tabPage1);
            this.MainTabControl.Controls.Add(this.tabPage2);
            this.MainTabControl.Location = new System.Drawing.Point(42, 42);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(707, 924);
            this.MainTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(699, 891);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Alter Existing";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl_jobCreationFields);
            this.tabPage2.Controls.Add(this.button_test);
            this.tabPage2.Controls.Add(this.button_cancel);
            this.tabPage2.Controls.Add(this.button_validate);
            this.tabPage2.Controls.Add(this.button_submit);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dropdown_JobSelector);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(699, 891);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Create New";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl_jobCreationFields
            // 
            this.tabControl_jobCreationFields.Controls.Add(this.tabPage_createFileMover);
            this.tabControl_jobCreationFields.Controls.Add(this.tabPage_createCommandRunner);
            this.tabControl_jobCreationFields.Location = new System.Drawing.Point(21, 113);
            this.tabControl_jobCreationFields.Name = "tabControl_jobCreationFields";
            this.tabControl_jobCreationFields.SelectedIndex = 0;
            this.tabControl_jobCreationFields.Size = new System.Drawing.Size(648, 691);
            this.tabControl_jobCreationFields.TabIndex = 7;
            // 
            // tabPage_createFileMover
            // 
            this.tabPage_createFileMover.Controls.Add(this.groupBox_FM_windowDays);
            this.tabPage_createFileMover.Controls.Add(this.button_FM_folderBrowserDialog_destinationPath);
            this.tabPage_createFileMover.Controls.Add(this.button_FM_folderBrowserDialog_inputPath);
            this.tabPage_createFileMover.Controls.Add(this.textBox_FM_inputPath);
            this.tabPage_createFileMover.Controls.Add(this.textBox_FM_destinationPath);
            this.tabPage_createFileMover.Controls.Add(this.textBox_FM_fileNamePattern);
            this.tabPage_createFileMover.Controls.Add(this.label_windowEnd);
            this.tabPage_createFileMover.Controls.Add(this.dateTimePicker_FM_windowEnd);
            this.tabPage_createFileMover.Controls.Add(this.label_windowStart);
            this.tabPage_createFileMover.Controls.Add(this.dateTimePicker_FM_windowStart);
            this.tabPage_createFileMover.Controls.Add(this.label_fileNamePattern);
            this.tabPage_createFileMover.Controls.Add(this.label_destinationPath);
            this.tabPage_createFileMover.Controls.Add(this.label_inputPath);
            this.tabPage_createFileMover.Controls.Add(this.label_jobName);
            this.tabPage_createFileMover.Controls.Add(this.textBox_FM_jobName);
            this.tabPage_createFileMover.Location = new System.Drawing.Point(4, 29);
            this.tabPage_createFileMover.Name = "tabPage_createFileMover";
            this.tabPage_createFileMover.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_createFileMover.Size = new System.Drawing.Size(640, 658);
            this.tabPage_createFileMover.TabIndex = 0;
            this.tabPage_createFileMover.Text = "Create FileMover";
            this.tabPage_createFileMover.UseVisualStyleBackColor = true;
            // 
            // groupBox_FM_windowDays
            // 
            this.groupBox_FM_windowDays.Controls.Add(this.checkBox_FM_tuesday);
            this.groupBox_FM_windowDays.Controls.Add(this.checkBox_FM_wednesday);
            this.groupBox_FM_windowDays.Controls.Add(this.checkBox_FM_thursday);
            this.groupBox_FM_windowDays.Controls.Add(this.checkBox_FM_friday);
            this.groupBox_FM_windowDays.Controls.Add(this.checkBox_FM_saturday);
            this.groupBox_FM_windowDays.Controls.Add(this.checkBox_FM_sunday);
            this.groupBox_FM_windowDays.Controls.Add(this.checkBox_FM_monday);
            this.groupBox_FM_windowDays.Location = new System.Drawing.Point(29, 288);
            this.groupBox_FM_windowDays.Name = "groupBox_FM_windowDays";
            this.groupBox_FM_windowDays.Size = new System.Drawing.Size(205, 351);
            this.groupBox_FM_windowDays.TabIndex = 22;
            this.groupBox_FM_windowDays.TabStop = false;
            this.groupBox_FM_windowDays.Text = "WindowDays";
            // 
            // checkBox_FM_tuesday
            // 
            this.checkBox_FM_tuesday.AutoSize = true;
            this.checkBox_FM_tuesday.Location = new System.Drawing.Point(43, 83);
            this.checkBox_FM_tuesday.Name = "checkBox_FM_tuesday";
            this.checkBox_FM_tuesday.Size = new System.Drawing.Size(95, 24);
            this.checkBox_FM_tuesday.TabIndex = 1;
            this.checkBox_FM_tuesday.Text = "Tuesday";
            this.checkBox_FM_tuesday.UseVisualStyleBackColor = true;
            // 
            // checkBox_FM_wednesday
            // 
            this.checkBox_FM_wednesday.AutoSize = true;
            this.checkBox_FM_wednesday.Location = new System.Drawing.Point(43, 126);
            this.checkBox_FM_wednesday.Name = "checkBox_FM_wednesday";
            this.checkBox_FM_wednesday.Size = new System.Drawing.Size(119, 24);
            this.checkBox_FM_wednesday.TabIndex = 2;
            this.checkBox_FM_wednesday.Text = "Wednesday";
            this.checkBox_FM_wednesday.UseVisualStyleBackColor = true;
            // 
            // checkBox_FM_thursday
            // 
            this.checkBox_FM_thursday.AutoSize = true;
            this.checkBox_FM_thursday.Location = new System.Drawing.Point(43, 170);
            this.checkBox_FM_thursday.Name = "checkBox_FM_thursday";
            this.checkBox_FM_thursday.Size = new System.Drawing.Size(100, 24);
            this.checkBox_FM_thursday.TabIndex = 3;
            this.checkBox_FM_thursday.Text = "Thursday";
            this.checkBox_FM_thursday.UseVisualStyleBackColor = true;
            // 
            // checkBox_FM_friday
            // 
            this.checkBox_FM_friday.AutoSize = true;
            this.checkBox_FM_friday.Location = new System.Drawing.Point(43, 212);
            this.checkBox_FM_friday.Name = "checkBox_FM_friday";
            this.checkBox_FM_friday.Size = new System.Drawing.Size(78, 24);
            this.checkBox_FM_friday.TabIndex = 4;
            this.checkBox_FM_friday.Text = "Friday";
            this.checkBox_FM_friday.UseVisualStyleBackColor = true;
            // 
            // checkBox_FM_saturday
            // 
            this.checkBox_FM_saturday.AutoSize = true;
            this.checkBox_FM_saturday.Location = new System.Drawing.Point(43, 253);
            this.checkBox_FM_saturday.Name = "checkBox_FM_saturday";
            this.checkBox_FM_saturday.Size = new System.Drawing.Size(99, 24);
            this.checkBox_FM_saturday.TabIndex = 5;
            this.checkBox_FM_saturday.Text = "Saturday";
            this.checkBox_FM_saturday.UseVisualStyleBackColor = true;
            // 
            // checkBox_FM_sunday
            // 
            this.checkBox_FM_sunday.AutoSize = true;
            this.checkBox_FM_sunday.Location = new System.Drawing.Point(43, 297);
            this.checkBox_FM_sunday.Name = "checkBox_FM_sunday";
            this.checkBox_FM_sunday.Size = new System.Drawing.Size(89, 24);
            this.checkBox_FM_sunday.TabIndex = 6;
            this.checkBox_FM_sunday.Text = "Sunday";
            this.checkBox_FM_sunday.UseVisualStyleBackColor = true;
            // 
            // checkBox_FM_monday
            // 
            this.checkBox_FM_monday.AutoSize = true;
            this.checkBox_FM_monday.Checked = true;
            this.checkBox_FM_monday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_FM_monday.Location = new System.Drawing.Point(43, 40);
            this.checkBox_FM_monday.Name = "checkBox_FM_monday";
            this.checkBox_FM_monday.Size = new System.Drawing.Size(91, 24);
            this.checkBox_FM_monday.TabIndex = 0;
            this.checkBox_FM_monday.Text = "Monday";
            this.checkBox_FM_monday.UseVisualStyleBackColor = true;
            // 
            // button_FM_folderBrowserDialog_destinationPath
            // 
            this.button_FM_folderBrowserDialog_destinationPath.Location = new System.Drawing.Point(566, 100);
            this.button_FM_folderBrowserDialog_destinationPath.Name = "button_FM_folderBrowserDialog_destinationPath";
            this.button_FM_folderBrowserDialog_destinationPath.Size = new System.Drawing.Size(30, 25);
            this.button_FM_folderBrowserDialog_destinationPath.TabIndex = 16;
            this.button_FM_folderBrowserDialog_destinationPath.Text = "...";
            this.button_FM_folderBrowserDialog_destinationPath.UseVisualStyleBackColor = true;
            // 
            // button_FM_folderBrowserDialog_inputPath
            // 
            this.button_FM_folderBrowserDialog_inputPath.Location = new System.Drawing.Point(566, 62);
            this.button_FM_folderBrowserDialog_inputPath.Name = "button_FM_folderBrowserDialog_inputPath";
            this.button_FM_folderBrowserDialog_inputPath.Size = new System.Drawing.Size(30, 25);
            this.button_FM_folderBrowserDialog_inputPath.TabIndex = 12;
            this.button_FM_folderBrowserDialog_inputPath.Text = "...";
            this.button_FM_folderBrowserDialog_inputPath.UseVisualStyleBackColor = true;
            // 
            // textBox_FM_inputPath
            // 
            this.textBox_FM_inputPath.Location = new System.Drawing.Point(224, 62);
            this.textBox_FM_inputPath.Name = "textBox_FM_inputPath";
            this.textBox_FM_inputPath.Size = new System.Drawing.Size(326, 26);
            this.textBox_FM_inputPath.TabIndex = 10;
            this.textBox_FM_inputPath.Text = "C:\\Users\\Jacob\\Documents\\C# Projects\\FileWatcher\\FileSystemWatcher\\TestDirectory\\" +
    "InputDirectory";
            // 
            // textBox_FM_destinationPath
            // 
            this.textBox_FM_destinationPath.Location = new System.Drawing.Point(224, 100);
            this.textBox_FM_destinationPath.Name = "textBox_FM_destinationPath";
            this.textBox_FM_destinationPath.Size = new System.Drawing.Size(326, 26);
            this.textBox_FM_destinationPath.TabIndex = 14;
            this.textBox_FM_destinationPath.Text = "C:\\Users\\Jacob\\Documents\\C# Projects\\FileWatcher\\FileSystemWatcher\\TestDirectory\\" +
    "OutputDirectory";
            // 
            // textBox_FM_fileNamePattern
            // 
            this.textBox_FM_fileNamePattern.Location = new System.Drawing.Point(224, 136);
            this.textBox_FM_fileNamePattern.Name = "textBox_FM_fileNamePattern";
            this.textBox_FM_fileNamePattern.Size = new System.Drawing.Size(326, 26);
            this.textBox_FM_fileNamePattern.TabIndex = 18;
            this.textBox_FM_fileNamePattern.Text = "*.*";
            // 
            // label_windowEnd
            // 
            this.label_windowEnd.AutoSize = true;
            this.label_windowEnd.Location = new System.Drawing.Point(27, 242);
            this.label_windowEnd.Name = "label_windowEnd";
            this.label_windowEnd.Size = new System.Drawing.Size(140, 20);
            this.label_windowEnd.TabIndex = 23;
            this.label_windowEnd.Text = "Window End Time:";
            // 
            // dateTimePicker_FM_windowEnd
            // 
            this.dateTimePicker_FM_windowEnd.CustomFormat = "HH:mm:ss";
            this.dateTimePicker_FM_windowEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_FM_windowEnd.Location = new System.Drawing.Point(224, 242);
            this.dateTimePicker_FM_windowEnd.Name = "dateTimePicker_FM_windowEnd";
            this.dateTimePicker_FM_windowEnd.ShowUpDown = true;
            this.dateTimePicker_FM_windowEnd.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker_FM_windowEnd.TabIndex = 21;
            this.dateTimePicker_FM_windowEnd.Value = new System.DateTime(2024, 4, 11, 23, 59, 59, 0);
            // 
            // label_windowStart
            // 
            this.label_windowStart.AutoSize = true;
            this.label_windowStart.Location = new System.Drawing.Point(27, 197);
            this.label_windowStart.Name = "label_windowStart";
            this.label_windowStart.Size = new System.Drawing.Size(146, 20);
            this.label_windowStart.TabIndex = 19;
            this.label_windowStart.Text = "Window Start Time:";
            // 
            // dateTimePicker_FM_windowStart
            // 
            this.dateTimePicker_FM_windowStart.CustomFormat = "HH:mm:ss";
            this.dateTimePicker_FM_windowStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_FM_windowStart.Location = new System.Drawing.Point(224, 197);
            this.dateTimePicker_FM_windowStart.Name = "dateTimePicker_FM_windowStart";
            this.dateTimePicker_FM_windowStart.ShowUpDown = true;
            this.dateTimePicker_FM_windowStart.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker_FM_windowStart.TabIndex = 20;
            this.dateTimePicker_FM_windowStart.Value = new System.DateTime(2024, 4, 11, 0, 0, 0, 0);
            // 
            // label_fileNamePattern
            // 
            this.label_fileNamePattern.AutoSize = true;
            this.label_fileNamePattern.Location = new System.Drawing.Point(27, 142);
            this.label_fileNamePattern.Name = "label_fileNamePattern";
            this.label_fileNamePattern.Size = new System.Drawing.Size(140, 20);
            this.label_fileNamePattern.TabIndex = 17;
            this.label_fileNamePattern.Text = "File Name Pattern:";
            // 
            // label_destinationPath
            // 
            this.label_destinationPath.AutoSize = true;
            this.label_destinationPath.Location = new System.Drawing.Point(27, 106);
            this.label_destinationPath.Name = "label_destinationPath";
            this.label_destinationPath.Size = new System.Drawing.Size(131, 20);
            this.label_destinationPath.TabIndex = 15;
            this.label_destinationPath.Text = "Destination Path:";
            // 
            // label_inputPath
            // 
            this.label_inputPath.AutoSize = true;
            this.label_inputPath.Location = new System.Drawing.Point(25, 65);
            this.label_inputPath.Name = "label_inputPath";
            this.label_inputPath.Size = new System.Drawing.Size(87, 20);
            this.label_inputPath.TabIndex = 13;
            this.label_inputPath.Text = "Input Path:";
            // 
            // label_jobName
            // 
            this.label_jobName.AutoSize = true;
            this.label_jobName.Location = new System.Drawing.Point(27, 18);
            this.label_jobName.Name = "label_jobName";
            this.label_jobName.Size = new System.Drawing.Size(85, 20);
            this.label_jobName.TabIndex = 11;
            this.label_jobName.Text = "Job Name:";
            // 
            // textBox_FM_jobName
            // 
            this.textBox_FM_jobName.Location = new System.Drawing.Point(224, 15);
            this.textBox_FM_jobName.Name = "textBox_FM_jobName";
            this.textBox_FM_jobName.Size = new System.Drawing.Size(387, 26);
            this.textBox_FM_jobName.TabIndex = 9;
            this.textBox_FM_jobName.Text = "Text";
            // 
            // tabPage_createCommandRunner
            // 
            this.tabPage_createCommandRunner.Controls.Add(this.checkBox_CR_adminPermissionsNeeded);
            this.tabPage_createCommandRunner.Controls.Add(this.label_CR_adminPermissionsNeeded);
            this.tabPage_createCommandRunner.Controls.Add(this.numericUpDown_CR_retryCount);
            this.tabPage_createCommandRunner.Controls.Add(this.label_CR_retryCount);
            this.tabPage_createCommandRunner.Controls.Add(this.checkBox_CR_retryOnFailure);
            this.tabPage_createCommandRunner.Controls.Add(this.label6);
            this.tabPage_createCommandRunner.Controls.Add(this.label5);
            this.tabPage_createCommandRunner.Controls.Add(this.textBox_CR_arguments);
            this.tabPage_createCommandRunner.Controls.Add(this.label_CR_command);
            this.tabPage_createCommandRunner.Controls.Add(this.textBox_CR_command);
            this.tabPage_createCommandRunner.Controls.Add(this.groupBox_CR_DayCommandIsRun);
            this.tabPage_createCommandRunner.Controls.Add(this.label3);
            this.tabPage_createCommandRunner.Controls.Add(this.dateTimePicker_CR_CommandRunTime);
            this.tabPage_createCommandRunner.Controls.Add(this.label_CR_jobName);
            this.tabPage_createCommandRunner.Controls.Add(this.textBox_CR_jobName);
            this.tabPage_createCommandRunner.Location = new System.Drawing.Point(4, 29);
            this.tabPage_createCommandRunner.Name = "tabPage_createCommandRunner";
            this.tabPage_createCommandRunner.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_createCommandRunner.Size = new System.Drawing.Size(640, 658);
            this.tabPage_createCommandRunner.TabIndex = 1;
            this.tabPage_createCommandRunner.Text = "Create CommandRunner";
            this.tabPage_createCommandRunner.UseVisualStyleBackColor = true;
            // 
            // checkBox_CR_adminPermissionsNeeded
            // 
            this.checkBox_CR_adminPermissionsNeeded.AutoSize = true;
            this.checkBox_CR_adminPermissionsNeeded.Location = new System.Drawing.Point(251, 142);
            this.checkBox_CR_adminPermissionsNeeded.Name = "checkBox_CR_adminPermissionsNeeded";
            this.checkBox_CR_adminPermissionsNeeded.Size = new System.Drawing.Size(22, 21);
            this.checkBox_CR_adminPermissionsNeeded.TabIndex = 38;
            this.checkBox_CR_adminPermissionsNeeded.UseVisualStyleBackColor = true;
            // 
            // label_CR_adminPermissionsNeeded
            // 
            this.label_CR_adminPermissionsNeeded.AutoSize = true;
            this.label_CR_adminPermissionsNeeded.Location = new System.Drawing.Point(28, 141);
            this.label_CR_adminPermissionsNeeded.Name = "label_CR_adminPermissionsNeeded";
            this.label_CR_adminPermissionsNeeded.Size = new System.Drawing.Size(204, 20);
            this.label_CR_adminPermissionsNeeded.TabIndex = 39;
            this.label_CR_adminPermissionsNeeded.Text = "Admin Permisions Needed?";
            // 
            // numericUpDown_CR_retryCount
            // 
            this.numericUpDown_CR_retryCount.Enabled = false;
            this.numericUpDown_CR_retryCount.Location = new System.Drawing.Point(224, 216);
            this.numericUpDown_CR_retryCount.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_CR_retryCount.Name = "numericUpDown_CR_retryCount";
            this.numericUpDown_CR_retryCount.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_CR_retryCount.TabIndex = 37;
            this.numericUpDown_CR_retryCount.Visible = false;
            // 
            // label_CR_retryCount
            // 
            this.label_CR_retryCount.AutoSize = true;
            this.label_CR_retryCount.Location = new System.Drawing.Point(74, 222);
            this.label_CR_retryCount.Name = "label_CR_retryCount";
            this.label_CR_retryCount.Size = new System.Drawing.Size(98, 20);
            this.label_CR_retryCount.TabIndex = 35;
            this.label_CR_retryCount.Text = "Retry Count:";
            this.label_CR_retryCount.Visible = false;
            // 
            // checkBox_CR_retryOnFailure
            // 
            this.checkBox_CR_retryOnFailure.AutoSize = true;
            this.checkBox_CR_retryOnFailure.Location = new System.Drawing.Point(225, 185);
            this.checkBox_CR_retryOnFailure.Name = "checkBox_CR_retryOnFailure";
            this.checkBox_CR_retryOnFailure.Size = new System.Drawing.Size(22, 21);
            this.checkBox_CR_retryOnFailure.TabIndex = 7;
            this.checkBox_CR_retryOnFailure.UseVisualStyleBackColor = true;
            this.checkBox_CR_retryOnFailure.CheckedChanged += new System.EventHandler(this.checkBox_CR_retryOnFailure_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Retry on Failure?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Arguments:";
            // 
            // textBox_CR_arguments
            // 
            this.textBox_CR_arguments.Location = new System.Drawing.Point(205, 97);
            this.textBox_CR_arguments.Name = "textBox_CR_arguments";
            this.textBox_CR_arguments.Size = new System.Drawing.Size(387, 26);
            this.textBox_CR_arguments.TabIndex = 32;
            this.textBox_CR_arguments.Text = "Text";
            // 
            // label_CR_command
            // 
            this.label_CR_command.AutoSize = true;
            this.label_CR_command.Location = new System.Drawing.Point(28, 56);
            this.label_CR_command.Name = "label_CR_command";
            this.label_CR_command.Size = new System.Drawing.Size(86, 20);
            this.label_CR_command.TabIndex = 31;
            this.label_CR_command.Text = "Command:";
            // 
            // textBox_CR_command
            // 
            this.textBox_CR_command.Location = new System.Drawing.Point(205, 53);
            this.textBox_CR_command.Name = "textBox_CR_command";
            this.textBox_CR_command.Size = new System.Drawing.Size(387, 26);
            this.textBox_CR_command.TabIndex = 30;
            this.textBox_CR_command.Text = "Text";
            // 
            // groupBox_CR_DayCommandIsRun
            // 
            this.groupBox_CR_DayCommandIsRun.Controls.Add(this.checkBox_CR_tuesday);
            this.groupBox_CR_DayCommandIsRun.Controls.Add(this.checkBox_CR_wednesday);
            this.groupBox_CR_DayCommandIsRun.Controls.Add(this.checkBox_CR_thursday);
            this.groupBox_CR_DayCommandIsRun.Controls.Add(this.checkBox_CR_friday);
            this.groupBox_CR_DayCommandIsRun.Controls.Add(this.checkBox_CR_saturday);
            this.groupBox_CR_DayCommandIsRun.Controls.Add(this.checkBox_CR_sunday);
            this.groupBox_CR_DayCommandIsRun.Controls.Add(this.checkBox_CR_monday);
            this.groupBox_CR_DayCommandIsRun.Location = new System.Drawing.Point(30, 290);
            this.groupBox_CR_DayCommandIsRun.Name = "groupBox_CR_DayCommandIsRun";
            this.groupBox_CR_DayCommandIsRun.Size = new System.Drawing.Size(205, 351);
            this.groupBox_CR_DayCommandIsRun.TabIndex = 29;
            this.groupBox_CR_DayCommandIsRun.TabStop = false;
            this.groupBox_CR_DayCommandIsRun.Text = "Days Command is Run";
            // 
            // checkBox_CR_tuesday
            // 
            this.checkBox_CR_tuesday.AutoSize = true;
            this.checkBox_CR_tuesday.Location = new System.Drawing.Point(43, 83);
            this.checkBox_CR_tuesday.Name = "checkBox_CR_tuesday";
            this.checkBox_CR_tuesday.Size = new System.Drawing.Size(95, 24);
            this.checkBox_CR_tuesday.TabIndex = 1;
            this.checkBox_CR_tuesday.Text = "Tuesday";
            this.checkBox_CR_tuesday.UseVisualStyleBackColor = true;
            // 
            // checkBox_CR_wednesday
            // 
            this.checkBox_CR_wednesday.AutoSize = true;
            this.checkBox_CR_wednesday.Location = new System.Drawing.Point(43, 126);
            this.checkBox_CR_wednesday.Name = "checkBox_CR_wednesday";
            this.checkBox_CR_wednesday.Size = new System.Drawing.Size(119, 24);
            this.checkBox_CR_wednesday.TabIndex = 2;
            this.checkBox_CR_wednesday.Text = "Wednesday";
            this.checkBox_CR_wednesday.UseVisualStyleBackColor = true;
            // 
            // checkBox_CR_thursday
            // 
            this.checkBox_CR_thursday.AutoSize = true;
            this.checkBox_CR_thursday.Location = new System.Drawing.Point(43, 170);
            this.checkBox_CR_thursday.Name = "checkBox_CR_thursday";
            this.checkBox_CR_thursday.Size = new System.Drawing.Size(100, 24);
            this.checkBox_CR_thursday.TabIndex = 3;
            this.checkBox_CR_thursday.Text = "Thursday";
            this.checkBox_CR_thursday.UseVisualStyleBackColor = true;
            // 
            // checkBox_CR_friday
            // 
            this.checkBox_CR_friday.AutoSize = true;
            this.checkBox_CR_friday.Location = new System.Drawing.Point(43, 212);
            this.checkBox_CR_friday.Name = "checkBox_CR_friday";
            this.checkBox_CR_friday.Size = new System.Drawing.Size(78, 24);
            this.checkBox_CR_friday.TabIndex = 4;
            this.checkBox_CR_friday.Text = "Friday";
            this.checkBox_CR_friday.UseVisualStyleBackColor = true;
            // 
            // checkBox_CR_saturday
            // 
            this.checkBox_CR_saturday.AutoSize = true;
            this.checkBox_CR_saturday.Location = new System.Drawing.Point(43, 253);
            this.checkBox_CR_saturday.Name = "checkBox_CR_saturday";
            this.checkBox_CR_saturday.Size = new System.Drawing.Size(99, 24);
            this.checkBox_CR_saturday.TabIndex = 5;
            this.checkBox_CR_saturday.Text = "Saturday";
            this.checkBox_CR_saturday.UseVisualStyleBackColor = true;
            // 
            // checkBox_CR_sunday
            // 
            this.checkBox_CR_sunday.AutoSize = true;
            this.checkBox_CR_sunday.Location = new System.Drawing.Point(43, 297);
            this.checkBox_CR_sunday.Name = "checkBox_CR_sunday";
            this.checkBox_CR_sunday.Size = new System.Drawing.Size(89, 24);
            this.checkBox_CR_sunday.TabIndex = 6;
            this.checkBox_CR_sunday.Text = "Sunday";
            this.checkBox_CR_sunday.UseVisualStyleBackColor = true;
            // 
            // checkBox_CR_monday
            // 
            this.checkBox_CR_monday.AutoSize = true;
            this.checkBox_CR_monday.Checked = true;
            this.checkBox_CR_monday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_CR_monday.Location = new System.Drawing.Point(43, 40);
            this.checkBox_CR_monday.Name = "checkBox_CR_monday";
            this.checkBox_CR_monday.Size = new System.Drawing.Size(91, 24);
            this.checkBox_CR_monday.TabIndex = 0;
            this.checkBox_CR_monday.Text = "Monday";
            this.checkBox_CR_monday.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Command Run Time:";
            // 
            // dateTimePicker_CR_CommandRunTime
            // 
            this.dateTimePicker_CR_CommandRunTime.CustomFormat = "HH:mm:ss";
            this.dateTimePicker_CR_CommandRunTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_CR_CommandRunTime.Location = new System.Drawing.Point(225, 258);
            this.dateTimePicker_CR_CommandRunTime.Name = "dateTimePicker_CR_CommandRunTime";
            this.dateTimePicker_CR_CommandRunTime.ShowUpDown = true;
            this.dateTimePicker_CR_CommandRunTime.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker_CR_CommandRunTime.TabIndex = 27;
            this.dateTimePicker_CR_CommandRunTime.Value = new System.DateTime(2024, 4, 11, 0, 0, 0, 0);
            // 
            // label_CR_jobName
            // 
            this.label_CR_jobName.AutoSize = true;
            this.label_CR_jobName.Location = new System.Drawing.Point(28, 16);
            this.label_CR_jobName.Name = "label_CR_jobName";
            this.label_CR_jobName.Size = new System.Drawing.Size(85, 20);
            this.label_CR_jobName.TabIndex = 25;
            this.label_CR_jobName.Text = "Job Name:";
            // 
            // textBox_CR_jobName
            // 
            this.textBox_CR_jobName.Location = new System.Drawing.Point(205, 10);
            this.textBox_CR_jobName.Name = "textBox_CR_jobName";
            this.textBox_CR_jobName.Size = new System.Drawing.Size(387, 26);
            this.textBox_CR_jobName.TabIndex = 24;
            this.textBox_CR_jobName.Text = "Text";
            // 
            // button_test
            // 
            this.button_test.BackColor = System.Drawing.Color.LightGray;
            this.button_test.Enabled = false;
            this.button_test.ForeColor = System.Drawing.SystemColors.Control;
            this.button_test.Location = new System.Drawing.Point(154, 810);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(78, 41);
            this.button_test.TabIndex = 6;
            this.button_test.Text = "Test";
            this.button_test.UseVisualStyleBackColor = false;
            this.button_test.Click += new System.EventHandler(this.Button_Test_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.OrangeRed;
            this.button_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cancel.Location = new System.Drawing.Point(558, 810);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(78, 41);
            this.button_cancel.TabIndex = 5;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // button_validate
            // 
            this.button_validate.BackColor = System.Drawing.Color.Green;
            this.button_validate.ForeColor = System.Drawing.SystemColors.Control;
            this.button_validate.Location = new System.Drawing.Point(54, 810);
            this.button_validate.Name = "button_validate";
            this.button_validate.Size = new System.Drawing.Size(78, 41);
            this.button_validate.TabIndex = 4;
            this.button_validate.Text = "Validate";
            this.button_validate.UseVisualStyleBackColor = false;
            this.button_validate.Click += new System.EventHandler(this.Button_Validate_Click);
            // 
            // button_submit
            // 
            this.button_submit.BackColor = System.Drawing.Color.LightGray;
            this.button_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_submit.Enabled = false;
            this.button_submit.ForeColor = System.Drawing.SystemColors.Control;
            this.button_submit.Location = new System.Drawing.Point(461, 810);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(78, 41);
            this.button_submit.TabIndex = 3;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = false;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "What type of Batch Job would you like to create?";
            // 
            // dropdown_JobSelector
            // 
            this.dropdown_JobSelector.FormattingEnabled = true;
            this.dropdown_JobSelector.Items.AddRange(new object[] {
            "FileMover",
            "CommandRunner",
            "SQLRunner",
            "PowershellRunner"});
            this.dropdown_JobSelector.Location = new System.Drawing.Point(28, 64);
            this.dropdown_JobSelector.Name = "dropdown_JobSelector";
            this.dropdown_JobSelector.Size = new System.Drawing.Size(233, 28);
            this.dropdown_JobSelector.TabIndex = 0;
            this.dropdown_JobSelector.Text = "-- Select Job Type --";
            this.dropdown_JobSelector.SelectedIndexChanged += new System.EventHandler(this.Dropdown_JobSelector_SelectedIndexChanged);
            // 
            // richTextBox_output
            // 
            this.richTextBox_output.Location = new System.Drawing.Point(790, 71);
            this.richTextBox_output.Name = "richTextBox_output";
            this.richTextBox_output.ReadOnly = true;
            this.richTextBox_output.Size = new System.Drawing.Size(417, 891);
            this.richTextBox_output.TabIndex = 1;
            this.richTextBox_output.Text = "";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1249, 997);
            this.Controls.Add(this.richTextBox_output);
            this.Controls.Add(this.MainTabControl);
            this.Name = "Form1";
            this.MainTabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl_jobCreationFields.ResumeLayout(false);
            this.tabPage_createFileMover.ResumeLayout(false);
            this.tabPage_createFileMover.PerformLayout();
            this.groupBox_FM_windowDays.ResumeLayout(false);
            this.groupBox_FM_windowDays.PerformLayout();
            this.tabPage_createCommandRunner.ResumeLayout(false);
            this.tabPage_createCommandRunner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CR_retryCount)).EndInit();
            this.groupBox_CR_DayCommandIsRun.ResumeLayout(false);
            this.groupBox_CR_DayCommandIsRun.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox dropdown_JobSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_test;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_validate;
        private System.Windows.Forms.Button button_submit;
        private FolderBrowserDialog folderBrowserDialog1;
        private TabPage tabPage2;
        private RichTextBox richTextBox_output;
        private TabControl tabControl_jobCreationFields;
        private TabPage tabPage_createFileMover;
        private GroupBox groupBox_FM_windowDays;
        private CheckBox checkBox_FM_tuesday;
        private CheckBox checkBox_FM_wednesday;
        private CheckBox checkBox_FM_thursday;
        private CheckBox checkBox_FM_friday;
        private CheckBox checkBox_FM_saturday;
        private CheckBox checkBox_FM_sunday;
        private CheckBox checkBox_FM_monday;
        private Button button_FM_folderBrowserDialog_destinationPath;
        private Button button_FM_folderBrowserDialog_inputPath;
        private TextBox textBox_FM_inputPath;
        private TextBox textBox_FM_destinationPath;
        private TextBox textBox_FM_fileNamePattern;
        private Label label_windowEnd;
        private DateTimePicker dateTimePicker_FM_windowEnd;
        private Label label_windowStart;
        private DateTimePicker dateTimePicker_FM_windowStart;
        private Label label_fileNamePattern;
        private Label label_destinationPath;
        private Label label_inputPath;
        private Label label_jobName;
        private TextBox textBox_FM_jobName;
        private TabPage tabPage_createCommandRunner;
        private GroupBox groupBox_CR_DayCommandIsRun;
        private CheckBox checkBox_CR_tuesday;
        private CheckBox checkBox_CR_wednesday;
        private CheckBox checkBox_CR_thursday;
        private CheckBox checkBox_CR_friday;
        private CheckBox checkBox_CR_saturday;
        private CheckBox checkBox_CR_sunday;
        private CheckBox checkBox_CR_monday;
        private Label label3;
        private DateTimePicker dateTimePicker_CR_CommandRunTime;
        private Label label_CR_jobName;
        private TextBox textBox_CR_jobName;
        private Label label5;
        private TextBox textBox_CR_arguments;
        private Label label_CR_command;
        private TextBox textBox_CR_command;
        private Label label_CR_retryCount;
        private CheckBox checkBox_CR_retryOnFailure;
        private Label label6;
        private NumericUpDown numericUpDown_CR_retryCount;
        private CheckBox checkBox_CR_adminPermissionsNeeded;
        private Label label_CR_adminPermissionsNeeded;
    }
}

#endregion