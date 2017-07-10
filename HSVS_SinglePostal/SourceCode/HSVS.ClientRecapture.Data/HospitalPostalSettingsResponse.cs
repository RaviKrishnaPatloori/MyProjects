
﻿namespace HSVS.SinglePostal.Data
{
    public class HospitalPostalSettingsResponse
    { 
        public int Id { get; set; }

        public string PostalMessage1 { get; set; }
        
        public string PostalMessage2 { get; set; }
       
        public int TargetClientLimit { get; set; }

        public Hospital HospitalDetails { get; set; }

        public bool IsRapportUser { get; set; }

    }
}
