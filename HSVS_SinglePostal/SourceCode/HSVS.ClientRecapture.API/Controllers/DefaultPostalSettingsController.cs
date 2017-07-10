using HSVS.ClientRecapture.Repository;
using HSVS.ClientRecapture.Repository.Model;
using System.Collections.Generic;
using System.Web.Http;

namespace HSVS.ClientRecapture.API.Controllers
{
    public class DefaultPostalSettingsController : ApiController
    {
        private IGenericRepository<DefaultPostalSettings> _repository { get; set; }

        public DefaultPostalSettingsController(IGenericRepository<DefaultPostalSettings> repository)
        {
            _repository = repository;
        }

        // GET api/defaultPostalSettings
        public IHttpActionResult Get()
        {
            var defaultPostalSettings = _repository.Get();
            if (defaultPostalSettings == null)
            {
                return NotFound();
            }

            return Ok(defaultPostalSettings);
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