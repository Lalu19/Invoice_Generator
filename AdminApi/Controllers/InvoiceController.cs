using AdminApi.DTO.App.InvoiceDTO;
using AdminApi.Models;
using AdminApi.Models.App;
using AdminApi.Models.App.Invoice;
using AdminApi.Models.Helper;
using EFCore.BulkExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Invoice> _InvoiceRepo;
        private readonly ISqlRepository<SubInvoice> _SubInvoiceRepo;

        public InvoiceController(IConfiguration config,
                               AppDbContext context,
                               ISqlRepository<Invoice> InvoiceRepo,
                               ISqlRepository<SubInvoice> SubInvoiceRepo
                              )
        {
            _config = config;
            _context = context;
            _InvoiceRepo = InvoiceRepo;
            _SubInvoiceRepo = SubInvoiceRepo;

        }


        [HttpPost]
        public IActionResult InvoiceCreate(InvoiceDTO invoiceDTO)
        {
            //var objCheck = _context.PO.SingleOrDefault(opt => opt.PoNo == poDTO.PoNo && opt.IsDeleted == false);
            var list = (from u in _context.Invoice select new { u.InvoiceId }).ToList();
            int SlNo = list.Count + 1;
           // string invoiceNo = "#9348" + SlNo.ToString();
            string qrcode = "INVOICE" + SlNo.ToString();
            try
            {
                //if (objCheck == null)
                //{
                Invoice invoice = new Invoice();
                invoice.InvoiceNo = invoiceDTO.InvoiceNo;
                invoice.InvoiceLogo = invoiceDTO.InvoiceLogo;
                invoice.BillFrom = invoiceDTO.BillFrom;
                invoice.BillTo = invoiceDTO.BillTo;
                invoice.InvoiceDate = invoiceDTO.InvoiceDate;
                invoice.DueDate = invoiceDTO.DueDate;
                invoice.PaymentTerm = invoiceDTO.PaymentTerm;
                invoice.PoNumber = invoiceDTO.PoNumber;
                invoice.SubTotal = invoiceDTO.SubTotal;
                invoice.Discounts = invoiceDTO.Discounts;
                invoice.Vat = invoiceDTO.Vat;
                invoice.GrandTotal = invoiceDTO.GrandTotal;
                invoice.AmountPaid = invoiceDTO.AmountPaid;
                invoice.BalanceDue = invoiceDTO.BalanceDue;
                invoice.Note = invoiceDTO.Note;
                invoice.Terms = invoiceDTO.Terms;
                invoice.QRCode = qrcode;
                invoice.CreatedBy = invoiceDTO.CreatedBy;
                invoice.CreatedOn = System.DateTime.Now;
                var obj = _InvoiceRepo.Insert(invoice);


                for (int i = 0; i < invoiceDTO.SubInvoices.Count; i++)
                {
                    SubInvoice subInvoices = new SubInvoice();
                    subInvoices.InvoiceId = obj.InvoiceId;
                    subInvoices.ItemDetails = invoiceDTO.SubInvoices[i].ItemDetails;
                    subInvoices.Quantity = invoiceDTO.SubInvoices[i].Quantity;
                    subInvoices.Rate = invoiceDTO.SubInvoices[i].Rate;
                    subInvoices.TotalAmount = invoiceDTO.SubInvoices[i].TotalAmount;
                    subInvoices.CreatedBy = invoiceDTO.CreatedBy;
                    subInvoices.CreatedOn = System.DateTime.Now;
                    var detailsplantstatewiseobj = _SubInvoiceRepo.Insert(subInvoices);
                }
                return Ok(obj);

                // }
                //else if (objCheck != null)
                //{
                //return Accepted(new Confirmation { Status = "duplicate", ResponseMsg = "Duplicate Po No!" });
                //}
                //return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [HttpGet("{invoiceId}")]
        public ActionResult GetInvoiceSingleList(int invoiceId)
        {
            try
            {
                var list = (from u in _context.Invoice

                            select new
                            {
                                u.InvoiceId,
                                u.InvoiceNo,
                                u.InvoiceLogo,
                                u.BillFrom,
                                u.BillTo,
                                u.InvoiceDate,
                                u.DueDate,
                                u.PaymentTerm,
                                u.PoNumber,
                                u.SubTotal,
                                u.Discounts,
                                u.Vat,
                                u.GrandTotal,
                                u.AmountPaid,
                                u.BalanceDue,
                                u.Note,
                                u.Terms,
                                u.QRCode,
                                u.CreatedBy,
                                u.CreatedOn,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.InvoiceId == invoiceId).ToList();

                List<ViewInvoiceDTO> ViewInvoiceDTOs = new List<ViewInvoiceDTO>();
                for (int i = 0; i < list.Count; i++)
                {
                    ViewInvoiceDTO viewInvoiceDTO = new ViewInvoiceDTO();
                    viewInvoiceDTO.InvoiceId = list[i].InvoiceId;
                    viewInvoiceDTO.InvoiceNo = list[i].InvoiceNo;
                    viewInvoiceDTO.InvoiceLogo = list[i].InvoiceLogo;
                    viewInvoiceDTO.BillFrom = list[i].BillFrom;
                    viewInvoiceDTO.BillTo = list[i].BillTo;
                    viewInvoiceDTO.InvoiceDate = list[i].InvoiceDate;
                    viewInvoiceDTO.DueDate = list[i].DueDate;
                    viewInvoiceDTO.PaymentTerm = list[i].PaymentTerm;
                    viewInvoiceDTO.PoNumber = list[i].PoNumber;
                    viewInvoiceDTO.SubTotal = list[i].SubTotal;
                    viewInvoiceDTO.Discounts = list[i].Discounts;
                    viewInvoiceDTO.Vat = list[i].Vat;
                    viewInvoiceDTO.GrandTotal = list[i].GrandTotal;
                    viewInvoiceDTO.AmountPaid = list[i].AmountPaid;
                    viewInvoiceDTO.BalanceDue = list[i].BalanceDue;
                    viewInvoiceDTO.Note = list[i].Note;
                    viewInvoiceDTO.Terms = list[i].Terms;
                    viewInvoiceDTO.QRCode = list[i].QRCode;
                    viewInvoiceDTO.CreatedBy = list[i].CreatedBy;
                    viewInvoiceDTO.CreatedOn = list[i].CreatedOn;


                    var transdetails = (from u in _context.SubInvoice
                                        select new
                                        {
                                            u.SubInvoiceId,
                                            u.InvoiceId,
                                            u.ItemDetails,
                                            u.Quantity,
                                            u.Rate,
                                            u.TotalAmount,
                                            u.CreatedBy,
                                            u.CreatedOn,
                                            u.IsDeleted
                                        }).Where(x => x.IsDeleted == false && x.InvoiceId == list[i].InvoiceId).ToList();
                    List<ViewSubInvoiceDTO> ViewSubInvoiceDTOs = new List<ViewSubInvoiceDTO>();
                    for (int j = 0; j < transdetails.Count; j++)
                    {
                        ViewSubInvoiceDTO viewSubInvoiceDTO = new ViewSubInvoiceDTO();
                        viewSubInvoiceDTO.SubInvoiceId = transdetails[j].SubInvoiceId;
                        viewSubInvoiceDTO.InvoiceId = transdetails[j].InvoiceId;
                        viewSubInvoiceDTO.ItemDetails = transdetails[j].ItemDetails;
                        viewSubInvoiceDTO.Quantity = transdetails[j].Quantity;
                        viewSubInvoiceDTO.Rate = transdetails[j].Rate;
                        viewSubInvoiceDTO.TotalAmount = transdetails[j].TotalAmount;
                        viewSubInvoiceDTO.CreatedBy = transdetails[j].CreatedBy;
                        viewSubInvoiceDTO.CreatedOn = transdetails[j].CreatedOn;


                        ViewSubInvoiceDTOs.Add(viewSubInvoiceDTO);
                    }
                    viewInvoiceDTO.ViewSubInvoices = ViewSubInvoiceDTOs;
                    ViewInvoiceDTOs.Add(viewInvoiceDTO);
                }
                int totalRecords = ViewInvoiceDTOs.Count();
                return Ok(new
                {
                    data = ViewInvoiceDTOs,
                    recordsTotal = totalRecords,
                    recordsFiltered = totalRecords
                });

            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "Error", ResponseMsg = ex.Message });
            }
        }


        [HttpGet("{invoiceId}")]
        public ActionResult GetSubInvoiceListbyinvoiceId(int invoiceId)
        {
            try
            {
                var list = (from u in _context.SubInvoice
                            join a in _context.Invoice on u.InvoiceId equals a.InvoiceId

                            select new
                            {
                                u.SubInvoiceId,
                                a.InvoiceId,
                                u.ItemDetails,
                                u.Quantity,
                                u.Rate,
                                u.TotalAmount,
                                u.CreatedBy,
                                u.CreatedOn,
                                u.IsDeleted,
                            }).Where(x => x.IsDeleted == false && x.InvoiceId == invoiceId).ToList();
                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [HttpGet()]
        public ActionResult InvoiceList()
        {
            try
            {
                var list = (from u in _context.Invoice
                            select new
                            {
                                u.InvoiceId,
                                u.InvoiceNo,
                                u.InvoiceLogo,
                                u.BillFrom,
                                u.BillTo,
                                u.InvoiceDate,
                                u.DueDate,
                                u.PaymentTerm,
                                u.PoNumber,
                                u.SubTotal,
                                u.Discounts,
                                u.Vat,
                                u.GrandTotal,
                                u.AmountPaid,
                                u.BalanceDue,
                                u.Note,
                                u.Terms,
                                u.QRCode,
                                u.CreatedBy,
                                u.CreatedOn,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false).ToList();

                List<ViewInvoiceDTO> ViewInvoiceDTOs = new List<ViewInvoiceDTO>();
                for (int i = 0; i < list.Count; i++)
                {
                    ViewInvoiceDTO viewInvoiceDTO = new ViewInvoiceDTO();
                    viewInvoiceDTO.InvoiceId = list[i].InvoiceId;
                    viewInvoiceDTO.InvoiceNo = list[i].InvoiceNo;
                    viewInvoiceDTO.InvoiceLogo = list[i].InvoiceLogo;
                    viewInvoiceDTO.BillFrom = list[i].BillFrom;
                    viewInvoiceDTO.BillTo = list[i].BillTo;
                    viewInvoiceDTO.InvoiceDate = list[i].InvoiceDate;
                    viewInvoiceDTO.DueDate = list[i].DueDate;
                    viewInvoiceDTO.PaymentTerm = list[i].PaymentTerm;
                    viewInvoiceDTO.PoNumber = list[i].PoNumber;
                    viewInvoiceDTO.SubTotal = list[i].SubTotal;
                    viewInvoiceDTO.Discounts = list[i].Discounts;
                    viewInvoiceDTO.Vat = list[i].Vat;
                    viewInvoiceDTO.GrandTotal = list[i].GrandTotal;
                    viewInvoiceDTO.AmountPaid = list[i].AmountPaid;
                    viewInvoiceDTO.BalanceDue = list[i].BalanceDue;
                    viewInvoiceDTO.Note = list[i].Note;
                    viewInvoiceDTO.Terms = list[i].Terms;
                    viewInvoiceDTO.QRCode = list[i].QRCode;
                    viewInvoiceDTO.CreatedBy = list[i].CreatedBy;
                    viewInvoiceDTO.CreatedOn = list[i].CreatedOn;

                    var transdetails = (from u in _context.SubInvoice
                                        join a in _context.Invoice on u.InvoiceId equals a.InvoiceId
                                        select new
                                        {
                                            a.InvoiceId,
                                            u.SubInvoiceId,
                                            u.ItemDetails,
                                            u.Quantity,
                                            u.Rate,
                                            u.TotalAmount,
                                            u.CreatedBy,
                                            u.CreatedOn,
                                            u.IsDeleted
                                        }).Where(x => x.IsDeleted == false && x.InvoiceId == list[i].InvoiceId).ToList();
                    List<ViewSubInvoiceDTO> ViewSubInvoiceDTOs = new List<ViewSubInvoiceDTO>();
                    for (int j = 0; j < transdetails.Count; j++)
                    {
                        ViewSubInvoiceDTO viewSubInvoiceDTO = new ViewSubInvoiceDTO();
                        viewSubInvoiceDTO.SubInvoiceId = transdetails[j].SubInvoiceId;
                        viewSubInvoiceDTO.InvoiceId = transdetails[j].InvoiceId;
                        viewSubInvoiceDTO.ItemDetails = transdetails[j].ItemDetails;
                        viewSubInvoiceDTO.Quantity = transdetails[j].Quantity;
                        viewSubInvoiceDTO.Rate = transdetails[j].Rate;
                        viewSubInvoiceDTO.TotalAmount = transdetails[j].TotalAmount;
                        viewSubInvoiceDTO.CreatedBy = transdetails[j].CreatedBy;
                        viewSubInvoiceDTO.CreatedOn = transdetails[j].CreatedOn;


                        ViewSubInvoiceDTOs.Add(viewSubInvoiceDTO);
                    }
                    viewInvoiceDTO.ViewSubInvoices = ViewSubInvoiceDTOs;
                    ViewInvoiceDTOs.Add(viewInvoiceDTO);
                }
                int totalRecords = ViewInvoiceDTOs.Count();
                return Ok(new
                {
                    data = ViewInvoiceDTOs,
                    recordsTotal = totalRecords,
                    recordsFiltered = totalRecords
                });

            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "Error", ResponseMsg = ex.Message });
            }
        }


        [HttpGet("{userid}")]
        public ActionResult InvoiceListbyuserid(int userid)
        {
            try
            {
                var list = (from u in _context.Invoice
                            join a in _context.Users on u.CreatedBy equals a.UserId
                            select new
                            {
                                a.UserId,
                                u.InvoiceId,
                                u.InvoiceNo,
                                u.InvoiceLogo,
                                u.BillFrom,
                                u.BillTo,
                                u.InvoiceDate,
                                u.DueDate,
                                u.PaymentTerm,
                                u.PoNumber,
                                u.SubTotal,
                                u.Discounts,
                                u.Vat,
                                u.GrandTotal,
                                u.AmountPaid,
                                u.BalanceDue,
                                u.Note,
                                u.Terms,
                                u.QRCode,
                                u.CreatedBy,
                                u.CreatedOn,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.CreatedBy==userid).ToList();
                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });

            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "Error", ResponseMsg = ex.Message });
            }
        }


        [HttpGet("{invoiceId}/{DeletedBy}")]
        public ActionResult DeleteInvoice(int invoiceId, int DeletedBy)
        {
            try
            {
                var purchase = _context.Invoice.SingleOrDefault(opt => opt.InvoiceId == invoiceId);
                purchase.IsDeleted = true;
                purchase.UpdatedBy = DeletedBy;
                purchase.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();

                var purchase1 = _context.SubInvoice.Where(record => record.InvoiceId == invoiceId);
                foreach (var record in purchase1)
                {
                    record.IsDeleted = true;
                    record.UpdatedBy = DeletedBy;
                    record.UpdatedOn = System.DateTime.Now;
                }
                _context.SaveChanges();
                return Ok(purchase);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [HttpPost]
        public async Task<ActionResult> UpdateInvoice(UpdateInvoiceDTO updateInvoiceDTO)
        {
            try
            {
                var invoice = _context.Invoice.SingleOrDefault(opt => opt.InvoiceId == updateInvoiceDTO.InvoiceId);
              //  invoice.InvoiceNo = updateTransportCertificateDTO.InvoiceNo;
                invoice.InvoiceLogo = updateInvoiceDTO.InvoiceLogo;
                invoice.BillFrom = updateInvoiceDTO.BillFrom;
                invoice.BillTo = updateInvoiceDTO.BillTo;
                invoice.InvoiceDate = updateInvoiceDTO.InvoiceDate;
                invoice.DueDate = updateInvoiceDTO.DueDate;
                invoice.PaymentTerm = updateInvoiceDTO.PaymentTerm;
                invoice.PoNumber = updateInvoiceDTO.PoNumber;
                invoice.SubTotal = updateInvoiceDTO.SubTotal;
                invoice.Discounts = updateInvoiceDTO.Discounts;
                invoice.Vat = updateInvoiceDTO.Vat;
                invoice.GrandTotal = updateInvoiceDTO.GrandTotal;
                invoice.AmountPaid = updateInvoiceDTO.AmountPaid;
                invoice.BalanceDue = updateInvoiceDTO.BalanceDue;
                invoice.Note = updateInvoiceDTO.Note;
                invoice.Terms = updateInvoiceDTO.Terms;
                invoice.QRCode = updateInvoiceDTO.QRCode;
                invoice.UpdatedBy = updateInvoiceDTO.UpdatedBy;
                invoice.UpdatedOn = System.DateTime.Now;

                _context.SaveChanges();
                var SubTansportTable = (from u in _context.SubInvoice

                                        select new
                                        {
                                            u.SubInvoiceId,
                                            u.InvoiceId,
                                            u.ItemDetails,
                                            u.Quantity,
                                            u.Rate,
                                            u.TotalAmount,
                                            u.IsDeleted
                                        }).Where(x => x.IsDeleted == false && x.InvoiceId == updateInvoiceDTO.InvoiceId).ToList();

                List<SubInvoice> subInvoices = new List<SubInvoice>();
                for (var i = 0; i < subInvoices.Count; i++)
                {
                    SubInvoice SubInvoicein = new SubInvoice();
                    SubInvoicein.SubInvoiceId = subInvoices[i].SubInvoiceId;
                    SubInvoicein.IsDeleted = true;
                    SubInvoicein.UpdatedBy = updateInvoiceDTO.UpdatedBy;
                    SubInvoicein.UpdatedOn = System.DateTime.Now;
                    subInvoices.Add(SubInvoicein);
                }
                await _context.BulkUpdateAsync(subInvoices);

                for (int i = 0; i < updateInvoiceDTO.UpdateSubInvoices.Count; i++)
                {
                    SubInvoice nSubInvoice = new SubInvoice();
                    nSubInvoice.InvoiceId = updateInvoiceDTO.InvoiceId;
                    nSubInvoice.ItemDetails = updateInvoiceDTO.UpdateSubInvoices[i].ItemDetails;
                    nSubInvoice.Quantity = updateInvoiceDTO.UpdateSubInvoices[i].Quantity;
                    nSubInvoice.Rate = updateInvoiceDTO.UpdateSubInvoices[i].Rate;
                    nSubInvoice.TotalAmount = updateInvoiceDTO.UpdateSubInvoices[i].TotalAmount;
                    nSubInvoice.UpdatedBy = updateInvoiceDTO.UpdatedBy;
                    var detailsfilterTableobj = _SubInvoiceRepo.Insert(nSubInvoice);
                }

                return Ok(invoice);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "Error", ResponseMsg = ex.Message });
            }
        }


        [HttpGet("{subinvoiceId}/{DeletedBy}")]
        public ActionResult DeleteSubInvoice(int subinvoiceId, int DeletedBy)
        {
            try
            {
                var subinvoice = _context.SubInvoice.SingleOrDefault(opt => opt.SubInvoiceId == subinvoiceId);
                subinvoice.IsDeleted = true;
                subinvoice.UpdatedBy = DeletedBy;
                subinvoice.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(subinvoice);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [HttpGet("{subinvoiceId}")]
        public ActionResult GetsubInvoiceSingleList(int subinvoiceId)
        {
            try
            {
                var subinvoice = _SubInvoiceRepo.SelectById(subinvoiceId);

                return Ok(subinvoice);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [HttpPost]
        public ActionResult Updatesubinvoice(UpdateSubInvoiceDTO UpdateSubInvoiceDTO)
        {
            try
            {
                var subinvoice = _context.SubInvoice.SingleOrDefault(opt => opt.SubInvoiceId == UpdateSubInvoiceDTO.SubInvoiceId);
                //subinvoice.InvoiceId = UpdateSubInvoiceDTO.InvoiceId;
                subinvoice.ItemDetails = UpdateSubInvoiceDTO.ItemDetails;
                subinvoice.Quantity = UpdateSubInvoiceDTO.Quantity;
                subinvoice.Rate = UpdateSubInvoiceDTO.Rate;
                subinvoice.TotalAmount = UpdateSubInvoiceDTO.TotalAmount;
                subinvoice.UpdatedBy = UpdateSubInvoiceDTO.UpdatedBy;
                subinvoice.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(subinvoice);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


    }
}
