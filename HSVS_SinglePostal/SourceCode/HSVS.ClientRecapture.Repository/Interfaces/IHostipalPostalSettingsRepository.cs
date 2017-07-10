using HSVS.SinglePostal.Data;

namespace HSVS.SinglePostal.Repository
{
    public interface IHostipalPostalSettingsRepository : IGenericRepository<HospitalPostalSettings>
    {
        HospitalPostalSettingsResponse GetHospitalById(int hospitalId);
    }
}
