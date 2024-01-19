using Microsoft.AspNetCore.Http;

namespace AdminClient.DTO
{
    public class MobileUploadDTO
    {
        public int BeatId { get; set; }
        public int AgentId { get; set; }
        public string StoreName { get; set; }
        public string OwnerName { get; set; }
        public string ContactPersonName { get; set; }
        public string Adress { get; set; }
        public string PinCode { get; set; }
        public string PhoneNumber { get; set; }
        public string WhatsAppNumber { get; set; }
        public string Landmark { get; set; }
        public string Image { get; set; }
        public string CreditBalance { get; set; }
        public int CreatedBy { get; set; }
        public IFormFile file { get; set; }

    }
    public class MobileUploadViewModel
    {
        public int StoreId { get; set; }
        public int BeatId { get; set; }
        public int AgentId { get; set; }
        public string StoreName { get; set; }
        public string OwnerName { get; set; }
        public string ContactPersonName { get; set; }
        public string Adress { get; set; }
        public string PinCode { get; set; }
        public string PhoneNumber { get; set; }
        public string WhatsAppNumber { get; set; }
        public string Landmark { get; set; }
        public string Image { get; set; }
        public string CreditBalance { get; set; }
        public int CreatedBy { get; set; }
    }
    public class MobileUploadNewDTO
    {
        public int BeatId { get; set; }
        public int AgentId { get; set; }
        public string StoreName { get; set; }
        public string OwnerName { get; set; }
        public string ContactPersonName { get; set; }
        public string Adress { get; set; }
        public string PinCode { get; set; }
        public string PhoneNumber { get; set; }
        public string WhatsAppNumber { get; set; }
        public string Landmark { get; set; }
        public string Image { get; set; }
        public string CreditBalance { get; set; }
        public int CreatedBy { get; set; }
    }
}
