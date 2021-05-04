using System;

namespace SoftwareLibrary.Interfaces
{
    public interface IRotaWorkDetails
    {
        DateTime ActualFinishTime { get; set; }
        string EmployeeJobTitle { get; set; }
        string EmployeeName { get; set; }
        double OvertTimeWorked { get; set; }
        DateTime ScheduledFinishTime { get; set; }
        DateTime StartTime { get; set; }
    }
}