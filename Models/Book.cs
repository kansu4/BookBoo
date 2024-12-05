using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookBoo.Models;

[Table("printed_book")]
public class Book
{
    [Key]
    public required string ISBN { get; set; }
    public string Name { get; set; }
    public string Book_ID {get; set;}
    [Column("publisher_name")]
    public string publisher {get; set;}

    public string description {get; set;}

    public int page_number {get; set;}

    public double price {get; set;}

    public double weight {get; set;}

    public string dimension {get; set;}

    public string binding_type {get; set;}

}

// update your database schema after adding a new property
// dotnet ef migrations add <MigrationName>
// dotnet ef database update