using AdminClient.DTO;
using AdminClient.Model.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace AdminClient.Model.MobileUpload
{
    public class MobileUploadProvider : IMobileUpload
    {
        IHttpWebClients _objIHttpWebClients;
        public MobileUploadProvider(IHttpWebClients objIHttpWebClients)
        {
            _objIHttpWebClients = objIHttpWebClients;
        }

        public MobileUploadViewModel CreateMobileUpload(MobileUploadNewDTO MobileUploadNewDTO)
        {
            try
            {
                MobileUploadViewModel objupdateResults = new MobileUploadViewModel();
                objupdateResults = JsonConvert.DeserializeObject<MobileUploadViewModel>(_objIHttpWebClients.PostRequest("/api/Store/StoreRepoCreate", JsonConvert.SerializeObject(MobileUploadNewDTO), true));
                return objupdateResults;
            }
            catch (Exception)
            {
                throw;

            }
        }
    }
}
