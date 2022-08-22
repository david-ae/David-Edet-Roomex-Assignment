using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Domain
{
    public class Latitude
    {
        private const double MIN_LATITUDE = -90;
        private const double MAX_LATITUDE = 90;
        private readonly double _value;

        public static Latitude FromDouble(double latitude) => new Latitude(latitude);

        public Latitude(double latitude)
        {
            if (latitude < MIN_LATITUDE) throw new Exception("Latitude__Should__Not__Be__Less__Than__" + MIN_LATITUDE);
            if (latitude > MAX_LATITUDE) throw new Exception("Latitude__Should__Not__Be__More__Than__" + MAX_LATITUDE);

            _value = latitude;
        }

        public double GetValue()
        {
            return _value;
        }
    }
}
