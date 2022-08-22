using Calculator.Domain;

namespace Calculator.API.Services
{
    public class PointsDistanceCalculator : ICalulator
    {        
        private const double ONE_METER_IN_NAUTICALMILE = 0.000539957;
        public double Calculate(Coordinate coordinateA, Coordinate coordinateB, string unitOfMeasure)
        {
            Point pointA = GetPoint(coordinateA);
            Point pointB = GetPoint(coordinateB);

            // apply the pythagoras and ignoring that the earth is a sphere
            // D = (difference in latitude)^2 + (difference in longitude)^2
            var distance = Math.Sqrt(
                    (pointB.Latitude.GetValue() - pointA.Latitude.GetValue()) + 
                    (pointB.Longitude.GetValue() - pointA.Longitude.GetValue())
                );

            if (double.IsNaN(distance)) 
                throw new Exception("Distance__Cannot__Be__Negative");

            switch (unitOfMeasure)
            {
                case "N":
                    distance = ToNauticalMiles(distance);
                    break;
                default:
                    break;
            }

            return distance;
        }

        public double ToNauticalMiles(double distance)
        {
            return distance * ONE_METER_IN_NAUTICALMILE;
        }

        public Point GetPoint(Coordinate coordinate)
        {
            var point = new Point
            {
                Latitude = Latitude.FromDouble(coordinate.Latitude),
                Longitude = Longitude.FromDouble(coordinate.Longitude)
            };

            return point;
        }
    }
}
