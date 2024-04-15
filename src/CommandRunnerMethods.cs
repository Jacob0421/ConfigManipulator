using ConfigManipulator.src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ConfigManipulator.src
{
    internal class CommandRunnerMethods : Form1
    {
        public static Dictionary<string, List<string>> ValidateCommandRunnerFields(TabPage CommandRunnerForm)
        {
            Dictionary<string, List<string>> messages = new Dictionary<string, List<string>>();
            messages.Add("error", new List<string>());
            messages.Add("warning", new List<string>());
            messages.Add("info", new List<string>());

            string jobName = CommandRunnerForm.Controls["textBox_CR_jobName"].Text;
            string command = CommandRunnerForm.Controls["textBox_CR_command"].Text;
            string arguments = CommandRunnerForm.Controls["textBox_CR_arguments"].Text;
            List<string> daysCommandRun = new List<string>();

            foreach (CheckBox box in CommandRunnerForm.Controls["groupBox_CR_DayCommandIsRun"].Controls)
            {
                if (box.Checked)
                {
                    daysCommandRun.Add((box.Text).Substring(0,3));
                }
            }

            if (string.IsNullOrEmpty(jobName))
            {
                messages["error"].Add($"{DateTime.Now.ToLongDateString()}: Parameter \"JobName\" is empty. Please check and complete with a valid value.");
            }

            if (string.IsNullOrEmpty(command))
            {
                messages["error"].Add($"{DateTime.Now.ToLongDateString()}: Parameter \"Command\" is empty. Please check and complete with a valid value.");
            }

            if (string.IsNullOrEmpty(arguments))
            {
                messages["error"].Add($"{DateTime.Now.ToLongDateString()}: Parameter \"arguments\" is empty. Please check and complete with a valid value.");
            }

            if (!daysCommandRun.Any())
            {
                messages["error"].Add($"{DateTime.Now.ToLongDateString()}: Parameter \"arguments\" is empty. Please select the days you would like this command to run.");
            }

            return messages;
        }

        public static XElement GenerateConfigXML(CommandRunner newCommandRunner)
        {


            XElement Job = new XElement("Job",
                    new XElement("JobID", newCommandRunner.JobID),
                    new XElement("JobName", newCommandRunner.JobName),
                    new XElement("JobType", newCommandRunner.JobType),
                    new XElement("Command", newCommandRunner.Command),
                    new XElement("Arguments", newCommandRunner.Arguments),
                    new XElement("IsAdminNeeded", newCommandRunner.AdminNeeded),
                    new XElement("RetryOnFailure", newCommandRunner.RetryOnFailure),
                    new XElement("RetryCount", newCommandRunner.RetryCount),
                    new XElement("CommandRunTime", newCommandRunner.CommandRunTime),
                    new XElement("WindowDays", String.Join("|", newCommandRunner.DaysRun))
                );
            return Job;
        }
    }
}
