using HSVS.SinglePostal.Data;
using HSVS.SinglePostal.WebApp.Helpers;
using HSVS.SinglePostal.WebApp.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace HSVS.SinglePostal.WebApp.Controllers
{
    [RoutePrefix("HospitalPostalSettings")]
    public class HospitalPostalSettingsController : Controller
    {
        public HospitalPostalSettingsController()
        {

        }

        public ActionResult Index()
        {
            HospitalPostalSettingsViewModel hospitalPostalSettingsViewModel = new HospitalPostalSettingsViewModel();
            return View(hospitalPostalSettingsViewModel);
        }
        // GET: HospitalPostalSettings
        [Route("{hospitalID}")]
        public async Task<ActionResult> Index(string hospitalID)
        {

            if (!ModelState.IsValid)
                return View();

            var httpClient = SinglePostalHttpClient.GetClient();

            var postalSettings = await httpClient.GetAsync("api/HospitalPostalSettings/" + hospitalID).ConfigureAwait(false);


            if (postalSettings.IsSuccessStatusCode)
            {
                var postalSettingsAsString = await postalSettings.Content.ReadAsStringAsync().ConfigureAwait(false);
                HospitalPostalSettingsViewModel postalSettingsViewModel = new HospitalPostalSettingsViewModel(JsonConvert.DeserializeObject<HospitalPostalSettingsResponse>(postalSettingsAsString)) { HospitalLongName = "Bacon" };
                return View(postalSettingsViewModel);
            }
            else
            {
                return View("Error",
                           new HandleErrorInfo(ExceptionHelper.GetExceptionFromResponse(postalSettings),
                           "HospitalPostalSettings", "Index"));
            }
        }

        [HttpPost]
        [Route("{hospitalID}")]
        public async Task<ActionResult> Save(HospitalPostalSettingsViewModel postalSettingsViewModel)
        {
            try
            {
                if(!ModelState.IsValid)
                    return RedirectToAction("Index", "HospitalPostalSettings", new { hospitalId = postalSettingsViewModel.HospitalId.ToString() });


                HospitalPostalSettings hospitalPostalSettings = new HospitalPostalSettings()
                {
                    HospitalId = postalSettingsViewModel.HospitalId,

                    PostalMessage1 = postalSettingsViewModel.PostalMessage1,
                    PostalMessage2 = postalSettingsViewModel.PostalMessage2,
                    TargetClientLimit = postalSettingsViewModel.TargetClients
                };

                var httpClient = SinglePostalHttpClient.GetClient();

                string jsonResult = JsonConvert.SerializeObject(hospitalPostalSettings);

                var response = await httpClient.PostAsync("api/HospitalPostalSettings/",
                     new StringContent(jsonResult, Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "HospitalPostalSettings", new { hospitalId = postalSettingsViewModel.HospitalId.ToString() });
                }
                else
                {
                    return View("Error",
                           new HandleErrorInfo(ExceptionHelper.GetExceptionFromResponse(response),
                           "HospitalPostalSettings", "Save"));                    
                }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "HospitalPostalSettings", "Save"));               
            }

        }
    }
}