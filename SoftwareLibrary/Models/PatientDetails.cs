namespace SoftwareLibrary.Interfaces
{
    class PatientDetails : IPatientDetails
    {
        public string Address { get; set; }
        public string AssignedDoctor { get; set; }
        public string ContactNumber { get; set; }
        public string DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NextOfKinName { get; set; }
        public string NextOfKinNumber { get; set; }
        public string PatientNotes { get; set; }
    }
}