namespace SoftwareLibrary.Interfaces
{
    public interface IStaffDetails
    {
        string Address { get; set; }
        string ContactNumber { get; set; }
        string DateOfBirth { get; set; }
        string FirstName { get; set; }
        string JobTitle { get; set; }
        string LastName { get; set; }
        string Password { get; set; }
        string Username { get; set; }
    }
}