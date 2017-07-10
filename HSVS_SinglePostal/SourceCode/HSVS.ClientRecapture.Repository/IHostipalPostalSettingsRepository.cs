using HSVS.ClientRecapture.Data;

namespace HSVS.ClientRecapture.Repository
{
    public interface IHostipalPostalSettingsRepository : IGenericRepository<HospitalPostalSettings>
    {
        HospitalPostalSettingsResponse GetHospitalById(int hospitalId);
    }
}
