using SoftwareLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareLibrary.Models
{
    class StaffDetails : IStaffDetails
    {
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public string JobTitle { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
    }
}