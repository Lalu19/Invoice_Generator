using System;
using System.Collections.Generic;

namespace AdminApi.DTO.App.InvoiceDTO
{
    //CREATE
    public class InvoiceDTO
    {
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
        public List<SubInvoiceDTO> SubInvoices { get; set; }
    }
    public class SubInvoiceDTO
    {
        public string ItemDetails { get; set; }
        public int Quantity { get; set; }
        public double Rate { get; set; }
        public double TotalAmount { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }

    //UPDATE
    public class UpdateInvoiceDTO
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
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public List<UpdateSubInvoiceDTO> UpdateSubInvoices { get; set; }
    }
    public class UpdateSubInvoiceDTO
    {
        public int SubInvoiceId { get; set; }
        public int InvoiceId { get; set; }
        public string ItemDetails { get; set; }
        public int Quantity { get; set; }
        public double Rate { get; set; }
        public double TotalAmount { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }

    //LIST

    public class ViewInvoiceDTO
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
        public List<ViewSubInvoiceDTO> ViewSubInvoices { get; set; }
    }
    public class ViewSubInvoiceDTO
    {
        public int SubInvoiceId { get; set; }
        public int InvoiceId { get; set; }
        public string ItemDetails { get; set; }
        public int Quantity { get; set; }
        public double Rate { get; set; }
        public double TotalAmount { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }



}

