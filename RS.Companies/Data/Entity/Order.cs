namespace RS.Companies.Data.Entity;

public class Order
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string StoreCity { get; set; } = null!;
    
    public int CompanyId { get; set; }
    public Company Company { get; set; } = null!;
}