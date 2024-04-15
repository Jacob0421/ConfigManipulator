using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigManipulator.src.Models
{
    internal class Job
    {
        public int JobID { get; set; }
        public string JobName { get; set; }
        public string JobType { get; set; }
        public List<string> DaysRun { get; set; }
    }
}
