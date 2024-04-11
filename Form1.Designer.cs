using System.Windows.Forms;

namespace ConfigManipulator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.button_test = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_validate = new System.Windows.Forms.Button();
            this.button_submit = new System.Windows.Forms.Button();
            this.fileMoverFields = new System.Windows.Forms.GroupBox();
            this.groupBox_WindowDays = new System.Windows.Forms.GroupBox();
            this.checkBox_tuesday = new System.Windows.Forms.CheckBox();
            this.checkBox_wednesday = new System.Windows.Forms.CheckBox();
            this.checkBox_thursday = new System.Windows.Forms.CheckBox();
            this.checkBox_friday = new System.Windows.Forms.CheckBox();
            this.checkBox_saturday = new System.Windows.Forms.CheckBox();
            this.checkBox_sunday = new System.Windows.Forms.CheckBox();
            this.checkBox_monday = new System.Windows.Forms.CheckBox();
            this.btn_folderSelector_destinationPath = new System.Windows.Forms.Button();
            this.btn_folderSelector_inputPath = new System.Windows.Forms.Button();
            this.textbox_inputPath = new System.Windows.Forms.TextBox();
            this.textBox_destinationPath = new System.Windows.Forms.TextBox();
            this.textBox_fileNamePattern = new System.Windows.Forms.TextBox();
            this.label_windowEnd = new System.Windows.Forms.Label();
            this.dateTimePicker_windowEnd = new System.Windows.Forms.DateTimePicker();
            this.label_windowStart = new System.Windows.Forms.Label();
            this.dateTimePicker_windowStart = new System.Windows.Forms.DateTimePicker();
            this.label_fileNamePattern = new System.Windows.Forms.Label();
            this.label_destinationPath = new System.Windows.Forms.Label();
            this.label_inputPath = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_jobName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dropdown_JobSelector = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.richTextBox_output = new System.Windows.Forms.RichTextBox();
            this.MainTabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.fileMoverFields.SuspendLayout();
            this.groupBox_WindowDays.SuspendLayout();
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
            this.tabPage2.Controls.Add(this.button_test);
            this.tabPage2.Controls.Add(this.button_cancel);
            this.tabPage2.Controls.Add(this.button_validate);
            this.tabPage2.Controls.Add(this.button_submit);
            this.tabPage2.Controls.Add(this.fileMoverFields);
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
            // fileMoverFields
            // 
            this.fileMoverFields.Controls.Add(this.groupBox_WindowDays);
            this.fileMoverFields.Controls.Add(this.btn_folderSelector_destinationPath);
            this.fileMoverFields.Controls.Add(this.btn_folderSelector_inputPath);
            this.fileMoverFields.Controls.Add(this.textbox_inputPath);
            this.fileMoverFields.Controls.Add(this.textBox_destinationPath);
            this.fileMoverFields.Controls.Add(this.textBox_fileNamePattern);
            this.fileMoverFields.Controls.Add(this.label_windowEnd);
            this.fileMoverFields.Controls.Add(this.dateTimePicker_windowEnd);
            this.fileMoverFields.Controls.Add(this.label_windowStart);
            this.fileMoverFields.Controls.Add(this.dateTimePicker_windowStart);
            this.fileMoverFields.Controls.Add(this.label_fileNamePattern);
            this.fileMoverFields.Controls.Add(this.label_destinationPath);
            this.fileMoverFields.Controls.Add(this.label_inputPath);
            this.fileMoverFields.Controls.Add(this.label2);
            this.fileMoverFields.Controls.Add(this.textBox_jobName);
            this.fileMoverFields.Location = new System.Drawing.Point(32, 125);
            this.fileMoverFields.Name = "fileMoverFields";
            this.fileMoverFields.Size = new System.Drawing.Size(635, 679);
            this.fileMoverFields.TabIndex = 2;
            this.fileMoverFields.TabStop = false;
            this.fileMoverFields.Text = "Create File Mover";
            // 
            // groupBox_WindowDays
            // 
            this.groupBox_WindowDays.Controls.Add(this.checkBox_tuesday);
            this.groupBox_WindowDays.Controls.Add(this.checkBox_wednesday);
            this.groupBox_WindowDays.Controls.Add(this.checkBox_thursday);
            this.groupBox_WindowDays.Controls.Add(this.checkBox_friday);
            this.groupBox_WindowDays.Controls.Add(this.checkBox_saturday);
            this.groupBox_WindowDays.Controls.Add(this.checkBox_sunday);
            this.groupBox_WindowDays.Controls.Add(this.checkBox_monday);
            this.groupBox_WindowDays.Location = new System.Drawing.Point(22, 308);
            this.groupBox_WindowDays.Name = "groupBox_WindowDays";
            this.groupBox_WindowDays.Size = new System.Drawing.Size(205, 351);
            this.groupBox_WindowDays.TabIndex = 15;
            this.groupBox_WindowDays.TabStop = false;
            this.groupBox_WindowDays.Text = "WindowDays";
            // 
            // checkBox_tuesday
            // 
            this.checkBox_tuesday.AutoSize = true;
            this.checkBox_tuesday.Location = new System.Drawing.Point(43, 83);
            this.checkBox_tuesday.Name = "checkBox_tuesday";
            this.checkBox_tuesday.Size = new System.Drawing.Size(95, 24);
            this.checkBox_tuesday.TabIndex = 1;
            this.checkBox_tuesday.Text = "Tuesday";
            this.checkBox_tuesday.UseVisualStyleBackColor = true;
            // 
            // checkBox_wednesday
            // 
            this.checkBox_wednesday.AutoSize = true;
            this.checkBox_wednesday.Location = new System.Drawing.Point(43, 126);
            this.checkBox_wednesday.Name = "checkBox_wednesday";
            this.checkBox_wednesday.Size = new System.Drawing.Size(119, 24);
            this.checkBox_wednesday.TabIndex = 2;
            this.checkBox_wednesday.Text = "Wednesday";
            this.checkBox_wednesday.UseVisualStyleBackColor = true;
            // 
            // checkBox_thursday
            // 
            this.checkBox_thursday.AutoSize = true;
            this.checkBox_thursday.Location = new System.Drawing.Point(43, 170);
            this.checkBox_thursday.Name = "checkBox_thursday";
            this.checkBox_thursday.Size = new System.Drawing.Size(100, 24);
            this.checkBox_thursday.TabIndex = 3;
            this.checkBox_thursday.Text = "Thursday";
            this.checkBox_thursday.UseVisualStyleBackColor = true;
            // 
            // checkBox_friday
            // 
            this.checkBox_friday.AutoSize = true;
            this.checkBox_friday.Location = new System.Drawing.Point(43, 212);
            this.checkBox_friday.Name = "checkBox_friday";
            this.checkBox_friday.Size = new System.Drawing.Size(78, 24);
            this.checkBox_friday.TabIndex = 4;
            this.checkBox_friday.Text = "Friday";
            this.checkBox_friday.UseVisualStyleBackColor = true;
            // 
            // checkBox_saturday
            // 
            this.checkBox_saturday.AutoSize = true;
            this.checkBox_saturday.Location = new System.Drawing.Point(43, 253);
            this.checkBox_saturday.Name = "checkBox_saturday";
            this.checkBox_saturday.Size = new System.Drawing.Size(99, 24);
            this.checkBox_saturday.TabIndex = 5;
            this.checkBox_saturday.Text = "Saturday";
            this.checkBox_saturday.UseVisualStyleBackColor = true;
            // 
            // checkBox_sunday
            // 
            this.checkBox_sunday.AutoSize = true;
            this.checkBox_sunday.Location = new System.Drawing.Point(43, 297);
            this.checkBox_sunday.Name = "checkBox_sunday";
            this.checkBox_sunday.Size = new System.Drawing.Size(89, 24);
            this.checkBox_sunday.TabIndex = 6;
            this.checkBox_sunday.Text = "Sunday";
            this.checkBox_sunday.UseVisualStyleBackColor = true;
            // 
            // checkBox_monday
            // 
            this.checkBox_monday.AutoSize = true;
            this.checkBox_monday.Checked = true;
            this.checkBox_monday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_monday.Location = new System.Drawing.Point(43, 40);
            this.checkBox_monday.Name = "checkBox_monday";
            this.checkBox_monday.Size = new System.Drawing.Size(91, 24);
            this.checkBox_monday.TabIndex = 0;
            this.checkBox_monday.Text = "Monday";
            this.checkBox_monday.UseVisualStyleBackColor = true;
            // 
            // btn_folderSelector_destinationPath
            // 
            this.btn_folderSelector_destinationPath.Location = new System.Drawing.Point(559, 120);
            this.btn_folderSelector_destinationPath.Name = "btn_folderSelector_destinationPath";
            this.btn_folderSelector_destinationPath.Size = new System.Drawing.Size(30, 25);
            this.btn_folderSelector_destinationPath.TabIndex = 14;
            this.btn_folderSelector_destinationPath.Text = "...";
            this.btn_folderSelector_destinationPath.UseVisualStyleBackColor = true;
            this.btn_folderSelector_destinationPath.Click += new System.EventHandler(this.TextBox_DestinationPath_FolderSelector);
            // 
            // btn_folderSelector_inputPath
            // 
            this.btn_folderSelector_inputPath.Location = new System.Drawing.Point(559, 82);
            this.btn_folderSelector_inputPath.Name = "btn_folderSelector_inputPath";
            this.btn_folderSelector_inputPath.Size = new System.Drawing.Size(30, 25);
            this.btn_folderSelector_inputPath.TabIndex = 13;
            this.btn_folderSelector_inputPath.Text = "...";
            this.btn_folderSelector_inputPath.UseVisualStyleBackColor = true;
            this.btn_folderSelector_inputPath.Click += new System.EventHandler(this.TextBox_InputPath_FolderSelector);
            // 
            // textbox_inputPath
            // 
            this.textbox_inputPath.Location = new System.Drawing.Point(217, 82);
            this.textbox_inputPath.Name = "textbox_inputPath";
            this.textbox_inputPath.Size = new System.Drawing.Size(326, 26);
            this.textbox_inputPath.TabIndex = 12;
            this.textbox_inputPath.Text = "C:\\Users\\Jacob\\Documents\\C# Projects\\FileWatcher\\FileSystemWatcher\\TestDirectory\\" +
    "InputDirectory";
            // 
            // textBox_destinationPath
            // 
            this.textBox_destinationPath.Location = new System.Drawing.Point(217, 120);
            this.textBox_destinationPath.Name = "textBox_destinationPath";
            this.textBox_destinationPath.Size = new System.Drawing.Size(326, 26);
            this.textBox_destinationPath.TabIndex = 11;
            this.textBox_destinationPath.Text = "C:\\Users\\Jacob\\Documents\\C# Projects\\FileWatcher\\FileSystemWatcher\\TestDirectory\\" +
    "OutputDirectory";
            // 
            // textBox_fileNamePattern
            // 
            this.textBox_fileNamePattern.Location = new System.Drawing.Point(217, 156);
            this.textBox_fileNamePattern.Name = "textBox_fileNamePattern";
            this.textBox_fileNamePattern.Size = new System.Drawing.Size(326, 26);
            this.textBox_fileNamePattern.TabIndex = 10;
            this.textBox_fileNamePattern.Text = "*.*";
            // 
            // label_windowEnd
            // 
            this.label_windowEnd.AutoSize = true;
            this.label_windowEnd.Location = new System.Drawing.Point(20, 262);
            this.label_windowEnd.Name = "label_windowEnd";
            this.label_windowEnd.Size = new System.Drawing.Size(140, 20);
            this.label_windowEnd.TabIndex = 8;
            this.label_windowEnd.Text = "Window End Time:";
            // 
            // dateTimePicker_windowEnd
            // 
            this.dateTimePicker_windowEnd.CustomFormat = "HH:mm:ss";
            this.dateTimePicker_windowEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_windowEnd.Location = new System.Drawing.Point(217, 262);
            this.dateTimePicker_windowEnd.Name = "dateTimePicker_windowEnd";
            this.dateTimePicker_windowEnd.ShowUpDown = true;
            this.dateTimePicker_windowEnd.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker_windowEnd.TabIndex = 7;
            this.dateTimePicker_windowEnd.Value = new System.DateTime(2024, 4, 11, 23, 59, 59, 0);
            // 
            // label_windowStart
            // 
            this.label_windowStart.AutoSize = true;
            this.label_windowStart.Location = new System.Drawing.Point(20, 217);
            this.label_windowStart.Name = "label_windowStart";
            this.label_windowStart.Size = new System.Drawing.Size(146, 20);
            this.label_windowStart.TabIndex = 6;
            this.label_windowStart.Text = "Window Start Time:";
            // 
            // dateTimePicker_windowStart
            // 
            this.dateTimePicker_windowStart.CustomFormat = "HH:mm:ss";
            this.dateTimePicker_windowStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_windowStart.Location = new System.Drawing.Point(217, 217);
            this.dateTimePicker_windowStart.Name = "dateTimePicker_windowStart";
            this.dateTimePicker_windowStart.ShowUpDown = true;
            this.dateTimePicker_windowStart.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker_windowStart.TabIndex = 5;
            this.dateTimePicker_windowStart.Value = new System.DateTime(2024, 4, 11, 0, 0, 0, 0);
            // 
            // label_fileNamePattern
            // 
            this.label_fileNamePattern.AutoSize = true;
            this.label_fileNamePattern.Location = new System.Drawing.Point(20, 162);
            this.label_fileNamePattern.Name = "label_fileNamePattern";
            this.label_fileNamePattern.Size = new System.Drawing.Size(140, 20);
            this.label_fileNamePattern.TabIndex = 4;
            this.label_fileNamePattern.Text = "File Name Pattern:";
            // 
            // label_destinationPath
            // 
            this.label_destinationPath.AutoSize = true;
            this.label_destinationPath.Location = new System.Drawing.Point(20, 126);
            this.label_destinationPath.Name = "label_destinationPath";
            this.label_destinationPath.Size = new System.Drawing.Size(131, 20);
            this.label_destinationPath.TabIndex = 3;
            this.label_destinationPath.Text = "Destination Path:";
            // 
            // label_inputPath
            // 
            this.label_inputPath.AutoSize = true;
            this.label_inputPath.Location = new System.Drawing.Point(18, 85);
            this.label_inputPath.Name = "label_inputPath";
            this.label_inputPath.Size = new System.Drawing.Size(87, 20);
            this.label_inputPath.TabIndex = 2;
            this.label_inputPath.Text = "Input Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Job Name:";
            // 
            // textBox_jobName
            // 
            this.textBox_jobName.Location = new System.Drawing.Point(217, 35);
            this.textBox_jobName.Name = "textBox_jobName";
            this.textBox_jobName.Size = new System.Drawing.Size(387, 26);
            this.textBox_jobName.TabIndex = 0;
            this.textBox_jobName.Text = "Text";
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
            "CommandJob",
            "SQLJob",
            "PowerShellJob"});
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
            this.fileMoverFields.ResumeLayout(false);
            this.fileMoverFields.PerformLayout();
            this.groupBox_WindowDays.ResumeLayout(false);
            this.groupBox_WindowDays.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox dropdown_JobSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox fileMoverFields;
        private System.Windows.Forms.Button button_test;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_validate;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Label label_destinationPath;
        private System.Windows.Forms.Label label_inputPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_jobName;
        private System.Windows.Forms.Label label_fileNamePattern;
        private System.Windows.Forms.DateTimePicker dateTimePicker_windowStart;
        private Label label_windowStart;
        private Label label_windowEnd;
        private DateTimePicker dateTimePicker_windowEnd;
        private TextBox textBox_destinationPath;
        private TextBox textBox_fileNamePattern;
        private TextBox textbox_inputPath;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btn_folderSelector_destinationPath;
        private Button btn_folderSelector_inputPath;
        private TabPage tabPage2;
        private GroupBox groupBox_WindowDays;
        private CheckBox checkBox_tuesday;
        private CheckBox checkBox_wednesday;
        private CheckBox checkBox_thursday;
        private CheckBox checkBox_friday;
        private CheckBox checkBox_saturday;
        private CheckBox checkBox_sunday;
        private CheckBox checkBox_monday;
        private RichTextBox richTextBox_output;
    }
}

#endregion