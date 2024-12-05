using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookBoo.Models;

[Table("AUTHOR")]
[PrimaryKey(nameof(ISBN), nameof(OrderingNumber))]
public class Author
{
    [ForeignKey("PrintedBook")]
    [Column("BOOK_ISBN")]
    public string ISBN { get; set; }

    [Column("ORDERING_NUMBER")]
    public string OrderingNumber { get; set; }

    [Column("NAME")]
    public string Name { get; set; }

    [Column("AFFILIATION")]
    public string? Affiliation { get; set; }
}
