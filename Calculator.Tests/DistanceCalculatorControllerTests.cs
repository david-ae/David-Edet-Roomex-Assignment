using AutoMapper;
using Calculator.API.Controllers;
using Calculator.API.Dtos;
using Calculator.API.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Calculator.Tests
{
    public class DistanceCalculatorControllerTests
    {
        [Fact]
        public void GetDistance_Between_Points_Returns_Distance()
        {
            // Arrange 
            var pointsDistanceCalculatorStub = new Mock<ICalulator>();
            var mapper = new Mock<IMapper>();

            pointsDistanceCalculatorStub.Setup(service => service
            .CalculateDistance(It.IsAny<Coordinate>(), It.IsAny<Coordinate>(), "")).Returns(0.0);

            var controller = new CalculatorController(pointsDistanceCalculatorStub.Object, mapper.Object);

            var points = CreatePoints();

            var result = controller.Calculate(points);

            Assert.IsType<OkObjectResult>(result);
        }

        public PointsDto CreatePoints()
        {
            return new PointsDto
            {
                CoordinateA = new CoordinateDto
                {
                    Latitude = -6.7,
                    Longitude = 40.6
                },
                CoordinateB = new CoordinateDto
                {
                    Latitude = -9.8,
                    Longitude = 90.3
                }
            };
        }
    }
}