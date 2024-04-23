using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace expense_tracker_api.Models;

public class Transaction
{
    [Key]
    public Guid TransactionId { get; set; }
    
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }

    public int TransactionAmount { get; set; }
    
    [Column(TypeName = "char(75)")]
    public string? TransactionNote { get; set; }
    
    public DateTime TransactionDate { get; set; } = DateTime.Now;
}