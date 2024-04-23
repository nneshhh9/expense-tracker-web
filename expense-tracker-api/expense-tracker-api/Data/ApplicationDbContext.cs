using expense_tracker_api.Models;
using Microsoft.EntityFrameworkCore;
using Transaction = System.Transactions.Transaction;

namespace expense_tracker_api.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options): base(options) {}
    
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<Category> Categories { get; set; }
    
}