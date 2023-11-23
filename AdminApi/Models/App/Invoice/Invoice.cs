using System;

namespace AdminApi.Models.App.Invoice
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public string InvoiceNo { get; set; }
        public string InvoiceLogo { get; set; }
        public string BillFrom { get; set; }
        public string BillTo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string PaymentTerm { get; set; }
        public string PoNumber { get; set; }
        public double SubTotal { get; set; }
        public double? Discounts { get; set; }
        public double? Vat { get; set; }
        public double GrandTotal { get; set; }
        public double? AmountPaid { get; set; }
        public double BalanceDue { get; set; }
        public string Note { get; set; }
        public string Terms { get; set; }
        public string QRCode { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }

    }
}
