using System;
using System.ComponentModel.DataAnnotations;

namespace AdminApi.DTO.App.UserAssignDTO
{
    public class UserAssignCreateDTO
    {
        
        public int CityId { get; set; }
        public int AreaId { get; set; }
        public int BeatId { get; set; }
        public int BeatCoadId { get; set; }
        public DateTime AssignDate { get; set; }
        public int CreatedBy { get; set; }
    }

    public class UserAssignUpdateDTO
    {
        public int UserAssignId { get; set; }
        public int CityId { get; set; }
        public int AreaId { get; set; }
        public int BeatId { get; set; }
        public int BeatCoadId { get; set; }
        public DateTime AssignDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
