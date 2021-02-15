using System;

namespace Lesson002
{
    class Program
    {
        static void Main(string[] args)
        {
            Executor();
        }
        public static void Executor()
        {
            int Avaragou, Monthou, Number = 1, Index = 0;
            string Pars = "Часть";
            char Locus = ' ';
            string[] Denuntiatio = new string[] { "Средняя температура за сутки", "Название месяца по номеру", "Определение чётности числа", "Итог по температуре и месяцам" };
                       
            Console.WriteLine( Pars + Locus + Number + Locus + Denuntiatio[ Index ] );
            Avaragou = CalculateAverageTempe();
            Update( ref Number, ref Index );

            Console.WriteLine( Pars + Locus + Number + Locus + Denuntiatio[ Index ] );
            Monthou = NameMonth();
            Console.WriteLine();

            Console.WriteLine( Pars + Locus + Number + Locus + Denuntiatio[ Index ] );
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

        public static void Update( ref int Value001, ref int Value002 )
        {
            ++Value001;
            ++Value002;

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую клавишу");            
            Console.ReadKey();
            Console.Clear();
        }
    }
}
