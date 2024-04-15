using ConfigManipulator.src.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ConfigManipulator
{
    internal class FileMoverMethods
    {
        public static Dictionary<string, List<string>> ValidateFileMoverFields(TabPage FileMoverForm)
        {

            Dictionary<string, List<string>> messages = new Dictionary<string, List<string>>();
            messages.Add("error", new List<string>());
            messages.Add("warning", new List<string>());
            messages.Add("info", new List<string>());

            string inputText = FileMoverForm.Controls["textbox_FM_inputPath"].Text;
            string destinationText = FileMoverForm.Controls["textbox_FM_destinationPath"].Text;
            TimeSpan windowStart = TimeSpan.Parse(FileMoverForm.Controls["dateTimePicker_FM_windowStart"].Text);
            TimeSpan windowEnd = TimeSpan.Parse(FileMoverForm.Controls["dateTimePicker_FM_windowEnd"].Text);
              
            List<string> windowDays = new List<string>();

            foreach (CheckBox box in FileMoverForm.Controls["groupBox_FM_windowDays"].Controls)
            {
                if (box.Checked)
                {
                    windowDays.Add((box.Text).Substring(0, 3));
                }
            }

            if (!windowDays.Any()) {
                messages["error"].Add($"{DateTime.Now.ToLongTimeString()}: Parameter \"Window Days\" is empty. Please check and select the days you would like this command run.");
            }

            if (inputText == String.Empty || !Directory.Exists(inputText))
            {
                messages["error"].Add($"{DateTime.Now.ToLongTimeString()}: Parameter \"Input Path\" is empty. Please check and complete with a valid value.");
            }

            if (destinationText == String.Empty || !Directory.Exists(destinationText))
            {
                messages["error"].Add($"{DateTime.Now.ToLongTimeString()}: Parameter \"Destination Path\" is empty. Please check and complete with a valid value.");
            }

            if(windowStart > windowEnd)
            {
                messages["warning"].Add($"{DateTime.Now.ToLongTimeString()}: Window Start is after the Window End. Please confirm if this is expected.");
            }

            return messages;
        }

        public static XElement GenerateConfigXML(FileMover newMover)
        {


            XElement Job = new XElement("Job",
                    new XElement("JobID", newMover.JobID),
                    new XElement("JobName", newMover.JobName),
                    new XElement("JobType", newMover.JobType),
                    new XElement("InputPath", newMover.InputPath),
                    new XElement("DestinationPath", newMover.DestinationPath),
                    new XElement("FileNamePattern", newMover.FileNamePattern),
                    new XElement("WindowStart", newMover.WindowStart),
                    new XElement("WindowEnd", newMover.WindowEnd),
                    new XElement("WindowDays", String.Join("|", newMover.DaysRun))
                );
            return Job;
        }
    }
}
