using System;

namespace AdminApi.Models.App.Invoice
{
    public class SubInvoice
    {
        public int SubInvoiceId { get; set; }
        public int InvoiceId { get; set; }
        public string ItemDetails { get; set; }
        public int Quantity { get; set; }
        public double Rate { get; set; }
        public double TotalAmount { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }

    }
}
