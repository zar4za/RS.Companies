using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RS.Companies.Data.Entity;

public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Title { get; set; } = null!;
    public DateTime BirthDate { get; set; }
    public string Position { get; set; } = null!;

    public int CompanyId { get; set; }
    public Company Company { get; set; } = null!;
}