namespace Calculator.API.Dtos
{
    public class PointsDto
    {
        public CoordinateDto CoordinateA { get; set; }
        public CoordinateDto CoordinateB { get; set; }
        public string UnitOfMeasure { get; set; }
    }
}
