using DataService.Service;
using Microsoft.AspNetCore.Mvc;
using Moq;
using PulpoLineTest.Controllers;

namespace TestAPIController
{
    public class UnitTest1
    {
        private readonly Mock<ICarbonEmission> _mockService;
        private readonly CarbonEmissionController _controller;

        public UnitTest1()
        {
            _mockService = new Mock<ICarbonEmission>();
            _controller = new CarbonEmissionController(_mockService.Object);
        }

        [Fact]
        public async Task Create_ReturnsOkResult_WithInteger()
        {
            // Mock de data test !que no exista en el Seeder
            var mockData = new CarbonEmissionModel
            {
                Id = 101,
                CompanyId = 99,
                Description = "Initial Data 1",
                CarbonEmissionValues = 100,
                DateCarbonEmission = DateTime.Now,
                TypeCarbonEmission = "Type1",
                IsDeleted = false
            };

            _mockService.Setup(service => service.CreateCarbonEmission(mockData))
                .ReturnsAsync(101); 

            var result = await _controller.Create(mockData);

            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsType<int>(okResult.Value);
            Assert.Equal(101, returnValue); 
        }
    }
}
