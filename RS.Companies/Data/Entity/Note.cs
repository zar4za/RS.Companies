namespace RS.Companies.Data.Entity;

public class Note
{
    public int Id { get; set; }
    public int InvoiceNumber { get; set; }
    
    public int CompanyId { get; set; }
    public Company Company { get; set; } = null!;
}