namespace Calculator.API.Services
{
    public interface ICalulator
    {
        double CalculateDistance(Coordinate coordinateA, Coordinate coordinateB, string unitOfMeasure);
    }
}
