using System.Text.Json.Serialization;

namespace RS.Companies.Data.Entity;

public class Company
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Address { get; set; } = null!; 
    public string City { get; set; } = null!;
    public string State { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    
    public ICollection<Order> History { get; set; } = null!;
    
    [JsonIgnore]
    public ICollection<Note> Notes { get; set; } = null!;
    public ICollection<Person> Employees { get; set; } = null!;
}