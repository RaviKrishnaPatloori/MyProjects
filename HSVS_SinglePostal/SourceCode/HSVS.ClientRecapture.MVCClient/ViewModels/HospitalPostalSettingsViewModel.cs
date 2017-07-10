using HSVS.SinglePostal.Data;
using System.ComponentModel.DataAnnotations;

namespace HSVS.SinglePostal.WebApp.ViewModels
{
    public class HospitalPostalSettingsViewModel : ViewModelBase
    {
        public HospitalPostalSettingsViewModel(HospitalPostalSettingsResponse postalSettingsResponse)
        {           
            PostalMessage1 = postalSettingsResponse.PostalMessage1;
            PostalMessage2 = postalSettingsResponse.PostalMessage2;
            TargetClients = postalSettingsResponse.TargetClientLimit;
            HospitalLongName = postalSettingsResponse.HospitalDetails.HospitalLongName;
            Address1 = postalSettingsResponse.HospitalDetails.Address1;
            Address2 = postalSettingsResponse.HospitalDetails.Address2;
            Address3 = postalSettingsResponse.HospitalDetails.Address3;
            City = postalSettingsResponse.HospitalDetails.City;
            State = postalSettingsResponse.HospitalDetails.State;
            Zip = postalSettingsResponse.HospitalDetails.Zip;
            Url = postalSettingsResponse.HospitalDetails.Url;
            Phone = postalSettingsResponse.HospitalDetails.Phone;
            HospitalId = postalSettingsResponse.HospitalDetails.Id;
            IsRapportUser = postalSettingsResponse.IsRapportUser;
        }

        public HospitalPostalSettingsViewModel()
        {
            PostalMessage1 = "Message1";
            PostalMessage2 = "Message2";
            TargetClients = 75;
            HospitalLongName = "HospitalName";
            Address1 = "Address1";
            Address2 = "Address2";
            Address3 = "Address3";
            City = "City";
            State = "State";
            Zip = "Zip";
            Url = "www.url.com";
            HospitalId = 1234;
            Phone = "xxx xxx xxx";
        }

        [Required(ErrorMessage = "Please enter the message")]
        [StringLength(321)]
        public string PostalMessage1 { get; set; }

        [Required(ErrorMessage = "Please enter the message")]
        [StringLength(321)]
        public string PostalMessage2 { get; set; }

        [Required(ErrorMessage = "Number of Target clients is required.")]
        [Range(25, 1000, ErrorMessage = "Enter number between 25 to 1000.")]
        public int TargetClients { get; set; }

        public string Phone { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string Address3 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string Url { get; set; }
    }
}