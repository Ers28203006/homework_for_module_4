using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    partial class MotorcycleHonda
    {
        /* поля */
        #region
        private string _nameMotorcycle;
        private int _maximumSpeed;
        private struct DimensionsLengthWidthHeight
        {
            public double _length;
            public double _wigth;
            public double _height;
        }

        private DimensionsLengthWidthHeight _dimension = new DimensionsLengthWidthHeight();

        private string _typeOfEngineStart;

        private int _enginePower;


        public static string purposeOfTheMotorcycle;

        public static int yearOfMotorcycleProduction;

        public static  int numberOfplaces;

        #endregion

        /* Конструктор по умолчанию */

        public MotorcycleHonda()
        {

        }

        /* Конструкторы с параметрами */

        public MotorcycleHonda(string nameMotorcycle)
        {
            _nameMotorcycle = nameMotorcycle;
            _typeOfEngineStart = "Электростартер";
            if (_nameMotorcycle== "Honda CBR 250 RR")
            {
                _dimension._height = 1.08;
                _dimension._wigth = 0.675;
                _dimension._length = 1.975;
                _enginePower = 15000;
                _maximumSpeed = 230;
            }
            else if (_nameMotorcycle == "Honda DN - 01")
            {
                _dimension._height = 1.12;
                _dimension._wigth = 0.837;
                _dimension._length = 2.343;
                _enginePower = 7500;
                _maximumSpeed = 250;

            }
            else if (_nameMotorcycle == "Honda NSF250R")
            {
                _dimension._height = 1.037; 
                _dimension._wigth = 0.560;
                _dimension._length = 1.809;
                _enginePower = 13000;
                _maximumSpeed = 300;

            }

            else if (_nameMotorcycle == "Honda RC212V")
            {
                _dimension._height = 1.11;
                _dimension._wigth = 0.645;
                _dimension._length = 2.052;
                _enginePower = 15500;
                _maximumSpeed = 260;
            }
            else if (_nameMotorcycle == "Honda ST 1300 P ABS")
            {
                _dimension._height = 1.485;
                _dimension._wigth = 0.86;
                _dimension._length = 2.270;
                _enginePower = 8000;
                _maximumSpeed = 230;

            }

        }

        /* Статический конструктор */

        static MotorcycleHonda()
        {
            purposeOfTheMotorcycle = "Спортбайк";
            yearOfMotorcycleProduction = 2019;
            numberOfplaces = 2;
        }
        
        /* свойства */
        #region

        public string GetNameMotorcycle()
        {
            return _nameMotorcycle;
        }

        public void SetNameMotorcycle(string nameMotorcycle)
        {
            _nameMotorcycle = nameMotorcycle;
        }

        public int GetMaximumSpeed()
        {
            return _maximumSpeed;
        }

        public void SetMaximumSpeed(int maximumSpeed)
        {
            _maximumSpeed = maximumSpeed;
        }

        public double GetDimensionHeight()
        {
            return _dimension._height;
        }

        public void SetDimensionHeight(double heightOfTheBike)
        {
            _dimension._height = heightOfTheBike;
        }

        public double GetDimensionWigth()
        {
            return _dimension._wigth;
        }

        public void SetDimensionWigth(double wigthOfTheBike)
        {
            _dimension._wigth = wigthOfTheBike;
        }

        public double GetDimensionLength()
        {
            return _dimension._length;
        }

        public void SetDimensionLength(double lengthOfTheBike)
        {
            _dimension._length = lengthOfTheBike;
        }

        public string GetTypeOfEngineStart()
        {
            return _typeOfEngineStart;
        }

        public void SetTypeOfEngineStart(string typeOfEngineStart)
        {
            _typeOfEngineStart = typeOfEngineStart;
        }

        public int GetEnginePower()
        {
            return _enginePower;
        }

        public void SetEnginePower(int enginePower)
        {
            _enginePower = enginePower;
        }
        #endregion

        public void ShowTechnicalSpecifications()
        {
            Console.WriteLine("*********************");
            Console.Write("1. Модель Honda: ");
            Console.WriteLine(_nameMotorcycle);

            Console.WriteLine("2. Габариты модели Honda:");
            Console.Write("     высота - ");
            Console.WriteLine(_dimension._height);
            Console.Write("     ширина - ");
            Console.WriteLine(_dimension._wigth);
            Console.Write("     длина - ");
            Console.WriteLine(_dimension._length);

            Console.Write("3. Пуск: ");
            Console.WriteLine(_typeOfEngineStart);

            Console.Write("4. Мощность двигателя: ");
            Console.WriteLine(_enginePower);

            Console.Write("5. Максимаольно развиваемая скорость: ");
            Console.WriteLine(_maximumSpeed);
            Console.WriteLine();
            Console.WriteLine("*********************");
        }

        public void SearchMotorcycleByParameter(string stringParametr)
        {
            if(_nameMotorcycle==stringParametr || _typeOfEngineStart == stringParametr)
            {
                ShowTechnicalSpecifications();
            }
        }

        public void SearchMotorcycleByParameter(int intParametr)
        {
            if (_maximumSpeed == intParametr || _enginePower == intParametr)
            {
                ShowTechnicalSpecifications();
            }
        }

        public void SearchMotorcycleByParameter(double doubleParametr)
        {
            if (_dimension._height == doubleParametr || _dimension._length == doubleParametr ||
                _dimension._wigth==doubleParametr || _enginePower==doubleParametr)
            {
                ShowTechnicalSpecifications();
            }
        }

        public static void clarificationOfTheColorsOfTheBike(ref string [] motorcycleСolor)
        {
            motorcycleСolor = new string[]       { "синий",
                                                   "желтый",
                                                   "зеленый",
                                                   "серый",
                                                   "белый" };

            Console.WriteLine("На все модели мотоцилов имеются следующие цвета: ");
            for (int i = 0; i < motorcycleСolor.Length; i++)
            {
                Console.WriteLine(motorcycleСolor[i]);
            }
        }
    }

}
