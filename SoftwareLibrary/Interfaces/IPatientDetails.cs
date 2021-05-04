namespace SoftwareLibrary.Interfaces
{
    public interface IPatientDetails
    {
        string Address { get; set; }
        string AssignedDoctor { get; set; }
        string ContactNumber { get; set; }
        string DateOfBirth { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string NextOfKinName { get; set; }
        string NextOfKinNumber { get; set; }
        string PatientNotes { get; set; }
    }
}