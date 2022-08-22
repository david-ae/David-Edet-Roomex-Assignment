using AutoMapper;
using Calculator.API.Dtos;
using Calculator.API.Extensions;
using Calculator.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.API.Controllers
{
    [Route("api/[controller]")]
    public class CalculatorController : Controller
    {
        private readonly ICalulator _calculator;
        private readonly IMapper _mapper;

        public CalculatorController(ICalulator calulator, IMapper mapper)
        {
            _calculator = calulator;
            _mapper = mapper;
        }

        [HttpPost("calculate-distance")]
        public IActionResult Calculate([FromBody] PointsDto points)
        {
            try
            {
                var coordinatesA = this._mapper.Map<Coordinate>(points.CoordinateA);
                var coordinatesB = this._mapper.Map<Coordinate>(points.CoordinateB);

                var distance = this._calculator.Calculate(coordinatesA, coordinatesB, points.UnitOfMeasure);

                return Ok(distance);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message );
            }
        }
    }
}
