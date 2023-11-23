using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AdminClient.DTO;
using AdminClient.Model.MobileUpload;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class MobileUploadController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IMobileUpload _MobileUpload;
        public MobileUploadController(IWebHostEnvironment hostingEnvironment,
                                            IMobileUpload MobileUploadP)
        {
            _hostingEnvironment = hostingEnvironment;
            _MobileUpload = MobileUploadP;
        }
        [HttpPost]
        public IActionResult MobileUploadCreate(MobileUploadDTO MobileUploadDTO)
        {

            string filename = ContentDispositionHeaderValue.Parse(MobileUploadDTO.file.ContentDisposition).FileName.Trim('"');
            filename = EnsureCorrectFilename(filename);

            string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
            string uniqueFileName = Guid.NewGuid().ToString() + "_" + filename;
            string imagePath = Path.Combine(uploadsFolder, uniqueFileName);
            MobileUploadDTO.file.CopyTo(new FileStream(imagePath, FileMode.Create));
            string photopath = "/images/" + uniqueFileName;
            MobileUploadNewDTO MobileUpload = new MobileUploadNewDTO();
            MobileUpload.BeatId = MobileUploadDTO.BeatId;
            MobileUpload.AgentId = MobileUploadDTO.AgentId;
            MobileUpload.StoreName = MobileUploadDTO.StoreName;
            MobileUpload.OwnerName = MobileUploadDTO.OwnerName;
            MobileUpload.ContactPersonName = MobileUploadDTO.ContactPersonName;
            MobileUpload.Adress = MobileUploadDTO.Adress;
            MobileUpload.PinCode = MobileUploadDTO.PinCode;
            MobileUpload.PhoneNumber = MobileUploadDTO.PhoneNumber;
            MobileUpload.WhatsAppNumber = MobileUploadDTO.WhatsAppNumber;
            MobileUpload.Landmark = MobileUploadDTO.Landmark;
            MobileUpload.Image = photopath;
            MobileUpload.CreditBalance = MobileUploadDTO.CreditBalance;
            MobileUpload.CreatedBy = MobileUploadDTO.CreatedBy;

            var a = _MobileUpload.CreateMobileUpload(MobileUpload);

            return Ok(a);
        }
        private string EnsureCorrectFilename(string filename)
        {
            if (filename.Contains("\\"))
                filename = filename.Substring(filename.LastIndexOf("\\") + 1);

            return filename;
        }
    }
}
