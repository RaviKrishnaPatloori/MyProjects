using HSVS.SinglePostal.Data;
using HSVS.SinglePostal.Repository;
using System.Web.Http;
using System.Web.Http.Description;

namespace HSVS.SinglePostal.API.Controllers
{
    [CustomExceptionFilter]
    public class HospitalPostalSettingsController : ApiController
    {
        private IHostipalPostalSettingsRepository _repository { get; set; }

        public HospitalPostalSettingsController(IHostipalPostalSettingsRepository repository)
        {
            _repository = repository;
        }

        // GET api/defaultPostalSettings
        [Route("api/HospitalPostalSettings/{Id}")]
        [ResponseType(typeof(HospitalPostalSettingsResponse))]
        public IHttpActionResult Get(int id)
        {
          
                var postalSettings = _repository.GetHospitalById(id);
                if (postalSettings == null)
                {
                    return NotFound();
                }

                return Ok(postalSettings);
        }

        // POST: api/hospitalPostalSettings
        [Route("api/HospitalPostalSettings")]
        [ResponseType(typeof(HospitalPostalSettings))]
        public IHttpActionResult Post([FromBody]HospitalPostalSettings hospitalPostalSettings)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (hospitalPostalSettings == null)
            {
                return null;
            }

            var exists = _repository.GetByID(hospitalPostalSettings.HospitalId);

            if (exists != null)
            {
                exists.PostalMessage1 = hospitalPostalSettings.PostalMessage1;
                exists.PostalMessage2 = hospitalPostalSettings.PostalMessage2;
                exists.TargetClientLimit = hospitalPostalSettings.TargetClientLimit;
                _repository.Update(exists);
            }
            else
            {
                _repository.Insert(hospitalPostalSettings);
            }

            _repository.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { controller = "HospitalPostalSettings", id = hospitalPostalSettings.Id }, hospitalPostalSettings);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _repository.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}