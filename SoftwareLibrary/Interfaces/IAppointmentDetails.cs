using System;

namespace SoftwareLibrary.Interfaces
{
    public interface IAppointmentDetails
    {
        string AppointmentBookedBy { get; set; }
        DateTime AppointmentDateTime { get; set; }
        string AssignedDoctor { get; set; }
        string AssignedNurse { get; set; }
        bool FollowUpAppointmentNeeded { get; set; }
        string OutcomeOfAppointment { get; set; }
        string ReasonForAppointment { get; set; }
        DateTime WhenAppointmentWasBooked { get; set; }
    }
}