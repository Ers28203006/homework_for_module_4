using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    partial class MotorcycleHonda
    {
        public MotorcycleHonda(string nameMotorcycle, int maximumSpeed, double lengthMotorcycle,
                               double wigthMotorcycle, double heightMotorcycle,
                               string typeOfEngineStart, int enginePower)

        {

            _nameMotorcycle = nameMotorcycle;

            _maximumSpeed = maximumSpeed;

            _dimension._height = heightMotorcycle;

            _dimension._wigth = wigthMotorcycle;

            _dimension._length = lengthMotorcycle;

            _typeOfEngineStart = typeOfEngineStart;

            _enginePower = enginePower;
        }
    }
}
