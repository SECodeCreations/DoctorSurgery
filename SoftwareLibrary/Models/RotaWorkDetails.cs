using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareLibrary.Interfaces;

namespace SoftwareLibrary.Models
{
    class RotaWorkDetails : IRotaWorkDetails
    {
        public string EmployeeName { get; set; }
        public string EmployeeJobTitle { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime ScheduledFinishTime { get; set; }
        public DateTime ActualFinishTime { get; set; }
        public double OvertTimeWorked { get; set; }
    }
}