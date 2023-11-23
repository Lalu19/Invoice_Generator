using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult InvoiceCreate()
        {
            return View();
        }
        public IActionResult Invoice(int invoiceId)
        {
            ViewBag.invoiceId = invoiceId;
            return View();
        }
        public IActionResult InvoiceList()
        {
            return View();
        }
        public IActionResult Invoic(int invoiceId)
        {
            ViewBag.invoiceId = invoiceId;
            return View();
        }
    }
}
