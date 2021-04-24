using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorSurgery
{
    class StaffDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string JobTitle { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        // Username and Password will need to be moved to a "Credentials" window where their login details can be amended.
    }
}
