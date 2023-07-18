using Microsoft.EntityFrameworkCore;
using RS.Companies.Data.Entity;
using RS.Companies.Shared;

namespace RS.Companies.Data;

public sealed class CompaniesContext : DbContext
{
    private const string DatabaseName = "companies";

    public DbSet<Company> Companies { get; init; } = null!;

    public DbSet<Note> Notes { get; init; } = null!;

    public DbSet<Person> Persons { get; init; } = null!;

    public CompaniesContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase(DatabaseName);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Person>()
            .HasOne(p => p.Company)
            .WithMany(c => c.Employees)
            .HasForeignKey(p => p.CompanyId);

        modelBuilder.Entity<Note>()
            .HasOne(n => n.Company)
            .WithMany(c => c.Notes)
            .HasForeignKey(n => n.CompanyId);

        modelBuilder.Entity<Order>()
            .HasOne(o => o.Company)
            .WithMany(c => c.History)
            .HasForeignKey(o => o.CompanyId);
        
        modelBuilder.Entity<Company>().HasData(
            new Company
            {
                Id = 1,
                Name = "Company 1",
                Address = "Address 1",
                City = "City 1",
                State = "State 1",
                PhoneNumber = "123-456-7890"
            },
            new Company
            {
                Id = 2,
                Name = "Company 2",
                Address = "Address 2",
                City = "City 3",
                State = "State 2",
                PhoneNumber = "987-654-3210"
            }
        );

        modelBuilder.Entity<Person>().HasData(
            new Person
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Title = "Mr.",
                BirthDate = new DateTime(1985, 5, 10),
                Position = "CEO",
                CompanyId = 1
            },
            new Person
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Smith",
                Title = "Mrs.",
                BirthDate = new DateTime(1990, 8, 20),
                Position = "CFO",
                CompanyId = 1
            },
            new Person
            {
                Id = 3,
                FirstName = "Michael",
                LastName = "Johnson",
                Title = "Mr.",
                BirthDate = new DateTime(1978, 3, 25),
                Position = "Manager",
                CompanyId = 2
            }
        );

        modelBuilder.Entity<Note>().HasData(
            new Note
            {
                Id = 1,
                InvoiceNumber = 10000,
                CompanyId = 1
            },
            new Note
            {
                Id = 2,
                InvoiceNumber = 12345,
                CompanyId = 1
            },
            new Note
            {
                Id = 3,
                InvoiceNumber = 15023,
                CompanyId = 2
            }
        );

        modelBuilder.Entity<Order>().HasData(
            new Order
            {
                Id = 1,
                Date = new DateTime(2023, 7, 1),
                StoreCity = "City 1",
                CompanyId = 1
            },
            new Order
            {
                Id = 2,
                Date = new DateTime(2023, 7, 15),
                StoreCity = "City 2",
                CompanyId = 1
            },
            new Order
            {
                Id = 3,
                Date = new DateTime(2023, 7, 5),
                StoreCity = "City 3",
                CompanyId = 2
            }
        );
        
        base.OnModelCreating(modelBuilder);
    }
}