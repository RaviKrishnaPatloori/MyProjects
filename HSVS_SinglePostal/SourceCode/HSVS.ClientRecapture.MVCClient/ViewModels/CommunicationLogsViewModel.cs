using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HSVS.SinglePostal.WebApp.ViewModels
{
    public class CommunicationLogsViewModel : ViewModelBase
    {
        public CommunicationLogsViewModel()
        {
            HospitalId = 1234;
            HospitalLongName = "Hospital Name";
        }
    }
}