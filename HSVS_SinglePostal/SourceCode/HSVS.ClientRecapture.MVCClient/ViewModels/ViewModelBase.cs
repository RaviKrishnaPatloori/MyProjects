using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HSVS.SinglePostal.WebApp.ViewModels
{
    public abstract class ViewModelBase
    {
        public int HospitalId { get; set; }
        public string HospitalLongName { get; set; }
        public bool IsRapportUser { get; set; }
    }
}