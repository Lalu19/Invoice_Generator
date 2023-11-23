using AdminClient.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminClient.Model.MobileUpload
{
    public interface IMobileUpload
    {
        public MobileUploadViewModel CreateMobileUpload(MobileUploadNewDTO MobileUploadNewDTO);
    }
}
