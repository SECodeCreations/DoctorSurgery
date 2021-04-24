using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorSurgery
{
    class PatientDetails
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string NextOfKinName { get; set; }
        public string NextOfKinNumber { get; set; }
        public string PatientNotes { get; set; }
        public string AssignedDoctor { get; set; }

        // TODO: ADD - Current Medications(List<Medication>)
        // TODO: ADD - Medical history(List<MedicalHistory>)


    }
