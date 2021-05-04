using SoftwareLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareLibrary.Models
{
    class AppointmentDetails : IAppointmentDetails
    {
        public string AppointmentBookedBy { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public string AssignedDoctor { get; set; }
        public string AssignedNurse { get; set; }
        public bool FollowUpAppointmentNeeded { get; set; }
        public string OutcomeOfAppointment { get; set; }
        public string ReasonForAppointment { get; set; }
        public DateTime WhenAppointmentWasBooked { get; set; }
    }
}