namespace WebProject.API.DomainModels;

public class DoStudent
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Email { get; set; }
    public long Mobile { get; set; }
    public string ProfileImageURL { get; set; }
    public Guid GenderId { get; set; }
    public DoGender Gender { get; set; }
    public DoAddress Address { get; set; }
}