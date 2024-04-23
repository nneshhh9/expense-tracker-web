using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace expense_tracker_api.Models;

public class Category
{
    [Key]
    public Guid CategoryId { get; set; }
    
    [Column(TypeName = "char(50)")]
    public string CategoryTitle { get; set; }
    
    [Column(TypeName = "char(5)")]
    public string CategoryIcon { get; set; } = "";

    [Column(TypeName = "char(10)")] 
    public string CategoryType { get; set; } = "Expense";
}