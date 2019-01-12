using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] modelOfHonda = new string[] { "Honda CBR 250 RR",
                                                   "Honda DN - 01",
                                                   "Honda NSF250R",
                                                   "Honda RC212V",
                                                   "Honda ST 1300 P ABS" };

            const int modelNumber = 5;

            MotorcycleHonda[] honda = new MotorcycleHonda[modelNumber];

            for (int i = 0; i < honda.Length; i++)
            {
                honda[i] = new MotorcycleHonda(modelOfHonda[i]);
            }

            Console.WriteLine("             Колекция мотоциклов");

            for (int i = 0; i < honda.Length; i++)
            {
                honda[i].ShowTechnicalSpecifications();
            }

            string nameMotorcycle;

            int maximumSpeed;

            double lengthMotorcycle;

            double wigthMotorcycle;

            double heightMotorcycle;

            int enginePower;

            bool selectionСycle = true;

            while (selectionСycle)
            {

                Console.WriteLine("По какому из нинжеуказанных параметров мотоцикла хотели бы осуществить поиск?");

                Console.WriteLine("1. По наименование модели мотоцикла Honda");

                Console.WriteLine("2. По максимально развиваемой скорости");

                Console.WriteLine("3. По габаритам");

                Console.WriteLine("4. По виду запуска двигателя");

                Console.WriteLine("5. По мощности двигателя");

                int searchByParameter;

                searchByParameter = int.Parse(Console.ReadLine());

                switch (searchByParameter)
                {
                    case 1:

                        Console.WriteLine("Выберите из указанных ниже моделей необходимую Вам: ");

                        Console.WriteLine("1. Honda CBR 250 RR");

                        Console.WriteLine("2. Honda DN - 01");

                        Console.WriteLine("3. Honda NSF250R");

                        Console.WriteLine("4. Honda RC212V");

                        Console.WriteLine("5. Honda ST 1300 P ABS");

                        int searchByMotorcycleModel;

                        searchByMotorcycleModel = int.Parse(Console.ReadLine());

                        switch (searchByMotorcycleModel)
                        {
                            case 1:

                                nameMotorcycle = modelOfHonda[0];

                                for (int i = 0; i < honda.Length; i++)
                                {
                                    honda[i].SearchMotorcycleByParameter(nameMotorcycle);
                                }

                                break;

                            case 2:

                                nameMotorcycle = modelOfHonda[1];

                                for (int i = 0; i < honda.Length; i++)
                                {
                                    honda[i].SearchMotorcycleByParameter(nameMotorcycle);
                                }

                                break;

                            case 3:

                                nameMotorcycle = modelOfHonda[2];

                                for (int i = 0; i < honda.Length; i++)
                                {
                                    honda[i].SearchMotorcycleByParameter(nameMotorcycle);
                                }

                                break;

                            case 4:

                                nameMotorcycle = modelOfHonda[3];

                                for (int i = 0; i < honda.Length; i++)
                                {
                                    honda[i].SearchMotorcycleByParameter(nameMotorcycle);
                                }

                                break;

                            case 5:

                                nameMotorcycle = modelOfHonda[4];

                                for (int i = 0; i < honda.Length; i++)
                                {
                                    honda[i].SearchMotorcycleByParameter(nameMotorcycle);
                                }

                                break;

                            default: Console.WriteLine("Мотоцикла с таким параметром нет"); break;
                        }

                        break;

                    case 2:

                        Console.WriteLine("Введите желаемую максимальную скорость:");

                        maximumSpeed = int.Parse(Console.ReadLine());

                        for (int i = 0; i < honda.Length; i++)
                        {
                            honda[i].SearchMotorcycleByParameter(maximumSpeed);
                        }

                        break;

                    case 3:

                        Console.WriteLine("По какому из нижеперечисленных параметров хотели бы выбрать мотоцикл?");

                        Console.WriteLine("1. Высота");

                        Console.WriteLine("2. Ширина");

                        Console.WriteLine("3. Длина");

                        int searchBySize;

                        searchBySize = int.Parse(Console.ReadLine());

                        switch (searchBySize)
                        {
                            case 1:

                                Console.WriteLine("Введите желаемую высоту: ");

                                heightMotorcycle = double.Parse(Console.ReadLine());

                                for (int i = 0; i < honda.Length; i++)

                                {
                                    honda[i].SearchMotorcycleByParameter(heightMotorcycle);
                                }

                                break;

                            case 2:

                                Console.WriteLine("Введите желаемую ширину: ");

                                wigthMotorcycle = double.Parse(Console.ReadLine());

                                for (int i = 0; i < honda.Length; i++)
                                {
                                    honda[i].SearchMotorcycleByParameter(wigthMotorcycle);
                                }

                                break;

                            case 3:

                                Console.WriteLine("Введите желаемую длину: ");

                                lengthMotorcycle = double.Parse(Console.ReadLine());

                                for (int i = 0; i < honda.Length; i++)
                                {
                                    honda[i].SearchMotorcycleByParameter(lengthMotorcycle);
                                }

                                break;

                            default: Console.WriteLine("Мотоцикла с таким параметром нет"); break;
                        }

                        break;

                    case 4:

                        Console.WriteLine("у всех мотоциклов тип пуска _Электростартер_");

                        break;

                    case 5:

                        Console.WriteLine("Введите желаемую мощность двигателя:");

                        enginePower = int.Parse(Console.ReadLine());

                        for (int i = 0; i < honda.Length; i++)
                        {
                            honda[i].SearchMotorcycleByParameter(enginePower);
                        }

                        break;

                    default: Console.WriteLine("Мотоцикла с таким параметром нет"); break;
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Желаете продолжить?");
                Console.WriteLine("1 - ДА");
                Console.WriteLine("0 - НЕТ");

                int loopRepeatCondition;

                loopRepeatCondition = int.Parse(Console.ReadLine());

                switch (loopRepeatCondition)
                {
                    case 0:

                        selectionСycle = false;

                        break;
                    case 1:

                        System.Console.Clear();

                        break;
                }
            }

            string [] motorcycleСolor=null;

            MotorcycleHonda.clarificationOfTheColorsOfTheBike(ref motorcycleСolor);

            Console.WriteLine();

            Console.WriteLine("Предназначение всех байков: " + MotorcycleHonda.purposeOfTheMotorcycle);

            Console.WriteLine("Год выпуска всех байков: " + MotorcycleHonda.yearOfMotorcycleProduction);

            Console.WriteLine("Количество мест: " + MotorcycleHonda.numberOfplaces);

            Console.WriteLine();

            Console.WriteLine("Из городских моторолеров рекомендовано: ");

            Console.WriteLine();

            string newNameMotorcycle = "Honda Mobimoba";

            lengthMotorcycle = 1.680;

            wigthMotorcycle = 0.568;

            heightMotorcycle = 1.03;

            string typeOfEngineStart = "Электростартер";

            enginePower = 5000;

            maximumSpeed = 120;

            MotorcycleHonda instanceOfTheMotorcycle = new MotorcycleHonda(newNameMotorcycle, maximumSpeed,
                                                            lengthMotorcycle, wigthMotorcycle, heightMotorcycle,
                                                            typeOfEngineStart, enginePower);

            instanceOfTheMotorcycle.ShowTechnicalSpecifications();

            Console.ReadLine();
        }
    }
}
