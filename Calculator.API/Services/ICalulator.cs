namespace Calculator.API.Services
{
    public interface ICalulator
    {
        double Calculate(Coordinate coordinateA, Coordinate coordinateB, string unitOfMeasure);
    }
}
