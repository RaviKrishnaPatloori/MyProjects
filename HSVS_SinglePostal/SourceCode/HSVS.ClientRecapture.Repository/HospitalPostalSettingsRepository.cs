using HSVS.SinglePostal.Data;
using System.Linq;

namespace HSVS.SinglePostal.Repository
{
    public class HospitalPostalSettingsRepository : GenericRepository<HospitalPostalSettings>, IHostipalPostalSettingsRepository
    {
        public HospitalPostalSettingsRepository()
        {
        }

        public HospitalPostalSettingsResponse GetHospitalById(int hospitalId)
        {
            HospitalPostalSettingsResponse result;
            var hospitalPostalSetting = context.HospitalPostalSettings.FirstOrDefault(i => i.HospitalId == hospitalId);
            if (hospitalPostalSetting == null)
            {
                var defaultSettings = context.DefaultPostalSettings.FirstOrDefault();
                result = new HospitalPostalSettingsResponse
                {
                    Id = defaultSettings.Id,
                    PostalMessage1 = defaultSettings.PostalMessage1,
                    PostalMessage2 = defaultSettings.PostalMessage2,
                    TargetClientLimit = defaultSettings.TargetClientLimit
                };
            }
            else
            {
                result = new HospitalPostalSettingsResponse
                {
                    Id = hospitalPostalSetting.Id,
                    PostalMessage1 = hospitalPostalSetting.PostalMessage1,
                    PostalMessage2 = hospitalPostalSetting.PostalMessage2,
                    TargetClientLimit = hospitalPostalSetting.TargetClientLimit
                };
            }

            result.HospitalDetails = context.Hospitals.SingleOrDefault(x => x.Id == hospitalId);
            result.IsRapportUser = context.RapportMappings.Any(x => x.HospitalId == hospitalId);

            return result;
        }
            
          
        

        public override HospitalPostalSettings GetByID(object id)
        {
            var hospitalPostalSetting = context.HospitalPostalSettings.FirstOrDefault(i => i.HospitalId == (int)id);
            return hospitalPostalSetting;
        }

    }
}
