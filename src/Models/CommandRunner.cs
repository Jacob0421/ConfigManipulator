using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigManipulator.src.Models
{
    internal class CommandRunner : Job
    {
        public string Command {  get; set; }
        public string Arguments { get; set; }
        public bool AdminNeeded { get; set; }
        public bool RetryOnFailure { get; set; }
        public int RetryCount { get; set; }
        public string CommandRunTime { get; set; }
    }
}
