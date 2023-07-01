using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BankTransaction.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        public string AcccountNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string BeneficiaryName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string BankName { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        public string SWIFTCode { get; set; }

        public int Amount { get; set; }

        public DateTime Date { get; set; }
    }
}