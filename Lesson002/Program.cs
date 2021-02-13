using System;

namespace Lesson002
{
    class Program
    {
        static void Main(string[] args)
        {
            int Avaragou, Monthou;
            
            Console.WriteLine("Часть первая - Средняя температура за сутки");            
            Avaragou = CalculateAverageTempe();
            Console.WriteLine();
            
            Console.WriteLine("Часть вторая - Название месяца по номеру");
            Monthou = NameMonth();
            Console.WriteLine();
            
            Console.WriteLine("Часть третья - Определение чётности числа");
            DetermineTheNumber();
            Console.WriteLine();

            
            if (Avaragou > 0)
            {
                if (Monthou > -1 && Monthou < 1 || Monthou == 11)
                {
                    Console.WriteLine("Часть четвёртая - Итог по температуре и месяцам");
                    Console.WriteLine("Дождливая зима");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }

        public static int CalculateAverageTempe()
        {            
            string Tempo;
            int TMin = 0, TMax = 0, TAverage = 0;
            

            Console.WriteLine("Введите минимальную температуру за сутки ");
            TMin = GetNumberFromString();

            Console.WriteLine("Введите максимальную температуру за сутки ");
            TMax = GetNumberFromString();

            if( TMin > TMax)
            {
                int Swapperou = TMin;
                TMin = TMax;
                TMax = Swapperou;
            }

            TAverage = ( TMin + TMax ) / 2;
            Console.WriteLine( "Средняя температура за день равна: " + TAverage );
            return TAverage;
        }

        public static int GetNumberFromString()
        {
            string TempoString;
            int SomeValue;
            //Получаем символы в строке
            TempoString = Console.ReadLine();
            //Проверяем на соответствие типу int
            if( !int.TryParse(TempoString, out SomeValue) )
            {
                SomeValue = 0;
            }
            return SomeValue;
        }

        public static int NameMonth()
        {
            string[] Months = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            Console.WriteLine("Введите номер месяца ");
            int ENM = GetNumberFromString();
            --ENM;

            if (ENM < 0)
            {
                ENM = 0;
            }               
            if (ENM > 11)
            {
                ENM = 11;
            }

            Console.WriteLine( Months[ ENM ] );
            return ENM;
        }

        public static void DetermineTheNumber()
        {
            Console.WriteLine("Введите число ");
            int SomeNumber = GetNumberFromString();

            if( ( SomeNumber %= 2 ) == 0 )
            {
                Console.WriteLine("Чётное");
                return;
            }
            Console.WriteLine("Нечётное");
        }

        public static void Fourero()
        {

        }
    }
}
