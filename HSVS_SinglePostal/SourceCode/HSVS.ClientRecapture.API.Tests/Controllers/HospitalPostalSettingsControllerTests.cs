using HSVS.SinglePostal.Data;
using HSVS.SinglePostal.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Web.Http;
using System.Web.Http.Results;

namespace HSVS.SinglePostal.API.Controllers.Tests
{
    [TestClass()]
    public class HospitalPostalSettingsControllerTests
    {
        [TestMethod()]
        public void HospitalPostalSettingsControllerGet()
        {
            // Arrange
            var mockRepository = new Mock<IHostipalPostalSettingsRepository>();
            mockRepository.Setup(x => x.GetHospitalById(42))
                .Returns(new HospitalPostalSettingsResponse { Id = 1,  PostalMessage1="Test1", PostalMessage2="Test2", TargetClientLimit=12,
                    HospitalDetails = new Hospital { Id = 42, Address1 = "testAddress" } });

            var controller = new HospitalPostalSettingsController(mockRepository.Object);
            
            // Act
            IHttpActionResult actionResult = controller.Get(42);
            var contentResult = actionResult as OkNegotiatedContentResult<HospitalPostalSettingsResponse>;

            // Assert
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.AreEqual(42, contentResult.Content.HospitalDetails.Id);
        }

        [TestMethod]
        public void HospitalPostalSettingsControllerGetReturnsNotFound()
        {
            // Arrange
            var mockRepository = new Mock<IHostipalPostalSettingsRepository>();
            var controller = new HospitalPostalSettingsController(mockRepository.Object);

            // Act
            IHttpActionResult actionResult = controller.Get(10);

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(NotFoundResult));
        }


        [TestMethod()]
        public void HospitalPostalSettingsControllerPostHospitalPostalSettings()
        {
            // Arrange
            var mockRepository = new Mock<IHostipalPostalSettingsRepository>();
            var controller = new HospitalPostalSettingsController(mockRepository.Object);

            // Act
            IHttpActionResult actionResult = controller.Post(new HospitalPostalSettings { Id = 10, HospitalId=12, PostalMessage1 = "Product1", PostalMessage2="Product2", TargetClientLimit=42 });
            var createdResult = actionResult as CreatedAtRouteNegotiatedContentResult<HospitalPostalSettings>;

            // Assert
            Assert.IsNotNull(createdResult);
            Assert.AreEqual("DefaultApi", createdResult.RouteName);
            Assert.AreEqual(10, createdResult.RouteValues["id"]);
        }

    }
}
