using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BankTransaction.Models
{
    public class TransactionDbContext : DbContext
    {
       public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options)
       { } 


       public DbSet<Transaction> Transactions { get; set; }
    }
}