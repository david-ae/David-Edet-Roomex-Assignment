using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Domain
{
    public class Longitude
    {
        private const double MIN_LONGITUDE = -180;
        private const double MAX_LONGITUDE = 180;
        private readonly double _value;

        public static Longitude FromDouble(double longitude) => new Longitude(longitude);

        public Longitude(double longitude)
        {
            if (longitude < MIN_LONGITUDE) throw new Exception("Longitude__Should__Not__Be__Less__Than__" + MIN_LONGITUDE);
            if (longitude > MAX_LONGITUDE) throw new Exception("Longitude__Should__Not__Be__More__Than__" + MAX_LONGITUDE);

            _value = longitude;
        }

        public double GetValue()
        {
            return _value;
        }
    }
}
