namespace WebProject.API.DataModels;

public class Address
{
    public Guid Id { get; set; }
    public string PhysicalAddress { get; set; }
    public string PostalAddress { get; set; }
    
    //Navigational Properties
    public Guid StudentId { get; set; }
}