using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigManipulator.src.Models
{
    internal class FileMover : Job
    {
        public string InputPath { get; set; }
        public string DestinationPath { get; set; }
        public string FileNamePattern { get; set; }
        public string WindowStart { get; set; }
        public string WindowEnd { get; set; }
    }
}
