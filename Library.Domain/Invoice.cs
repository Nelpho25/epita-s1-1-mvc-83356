using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime InvoiceDate { get; set; } = DateTime.UtcNow;

        // FK to Customer
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        public List<InvoiceLine> Lines { get; set; } = new();
    }
}
