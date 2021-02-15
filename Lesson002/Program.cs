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
            //Средняя температура, номер выполняемой части, номер выводимого задания, количество частей-заданий
            int Avaragou = 0, Monthou = 0, Number = 1, Index = 0, CountPars = 7;
            string Pars = "Часть";
            char Locus = ' ';
            string[] Denuntiatio = new string[] { "Средняя температура за сутки", "Название месяца по номеру", "Определение чётности числа", "Отображение чека", "Итог по температуре и месяцам", "Универсальнуая структура расписания недели", "Определение високосности года" };
            //Цикл-обработчик каждого задания
            for( int i = 0; i < CountPars; ++i )
            {
                //Вывод части и названия задания
                Console.WriteLine( Pars + Locus + Number + Locus + Denuntiatio[ Index ] );

                switch ( Index )
                {
                    case 0:
                        Avaragou = CalculateAverageTempe();
                        break;
                    case 1:
                        Monthou = NameMonth();
                        break;
                    case 2:
                        DetermineTheNumber();
                        break;
                    case 3:
                        ShowCheck();
                        break;
                    case 4:
                        ReprehendoHieme( ref Avaragou, ref Monthou );
                        break;
                    case 5:
                        OfficiumCompages();
                        break;
                }
                if ( Index == 6 )
                {
                    CheckYear();
                    
                    Console.WriteLine();
                    Console.WriteLine("Все части пройдены");
                    Console.WriteLine("Для выхода нажмите любую клавишу");
                    Console.ReadKey();

                    break;
                }

                Update(ref Number, ref Index);
            }
        }
        //Вычисление средней темературы за день
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
        //Получение числа из строки с проверками на неверные значения, по умолчанию выдаёт ноль
        public static int GetNumberFromString()
        {
            string TempoString;
            int SomeValue;
            //Получаем символы в строке
            TempoString = Console.ReadLine();
            //Проверяем на соответствие типу int
            if( !int.TryParse( TempoString, out SomeValue ) )
            {
                SomeValue = 0;
            }
            return SomeValue;
        }
        //Выдать по числу название месяца с проверками на выход за пределы, в случае которого выдаёт название предельного
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
        //Проверка чётности числа
        public static void DetermineTheNumber()
        {
            Console.WriteLine( "Введите число" );
            int SomeNumber = GetNumberFromString();

            if( ( SomeNumber %= 2 ) == 0 )
            {
                Console.WriteLine( "Чётное" );
                return;
            }
            Console.WriteLine( "Нечётное" );
        }
        //Печать подобия чека в консоль
        public static void ShowCheck()
        {
            int Width = 39, Height = 23, MoneyPlace = Width - 6, Solum = Height - 2, BaseWidth = 2, StartHeight = 2;

            char[,] Checkimage = new char[Height, Width];
            //Заполняем массив пробелами и границами
            PrepareArray(ref Checkimage);

            //Записываем содержание чека
            CopyStringToArray( StartHeight, BaseWidth, "FOESTOUA MORKOT", ref Checkimage );
            StartHeight += 2;

            CopyStringToArray( StartHeight, BaseWidth, "3015 Adoms Ovonou", ref Checkimage );
            ++StartHeight;
            CopyStringToArray( StartHeight, BaseWidth, "Soun Douegou, CA 45657", ref Checkimage );
            ++StartHeight;
            CopyStringToArray( StartHeight, BaseWidth, "(564) 8762 - 345", ref Checkimage );
            StartHeight += 2;

            CopyStringToArray( StartHeight, BaseWidth, "Pocca Mocorolla", ref Checkimage );
            CopyStringToArray( StartHeight, MoneyPlace, "15 A", ref Checkimage );
            ++StartHeight;
            CopyStringToArray( StartHeight, BaseWidth, "Sokkow Ksovwollu", ref Checkimage );
            CopyStringToArray( StartHeight, MoneyPlace, " 3 A", ref Checkimage );
            ++StartHeight;
            CopyStringToArray( StartHeight, BaseWidth, "Capsicum Frutum", ref Checkimage );
            CopyStringToArray( StartHeight, MoneyPlace, " 9 A", ref Checkimage );
            StartHeight += 2;

            CopyStringToArray( StartHeight, BaseWidth, "Et Exitus", ref Checkimage );
            CopyStringToArray( StartHeight, MoneyPlace, "27 A", ref Checkimage );
            ++StartHeight;
            CopyStringToArray( StartHeight, BaseWidth, "40 % HDC", ref Checkimage );
            CopyStringToArray( StartHeight, MoneyPlace, "38 A", ref Checkimage );
            StartHeight += 2;

            CopyStringToArray( StartHeight, BaseWidth, "Quantitas", ref Checkimage );
            CopyStringToArray( StartHeight, MoneyPlace, "3", ref Checkimage );

            CopyStringToArray( Solum, BaseWidth, "ARIGATOUKOSAMUMASU", ref Checkimage );

            //Отображаем
            ShowArray( ref Checkimage );
        }
        public static void PrepareArray( ref char[,] SomeArray )
        {
            int Height = SomeArray.GetUpperBound(0) + 1;
            int Width = SomeArray.Length / Height;

            for (int i = 0; i < Height; ++i)
            {
                for (int j = 0; j < Width; ++j)
                {
                    if (i == 0 || i == (Height - 1))
                    {
                        SomeArray[i, j] = '-';
                        continue;
                    }
                    if (j == 0 || j == (Width - 1))
                    {
                        SomeArray[i, j] = '|';
                        continue;
                    }
                    SomeArray[i, j] = ' ';
                }
            }

            SomeArray[0, 0] = '#';
            SomeArray[0, Width - 1] = '#';
            SomeArray[Height - 1, 0] = '#';
            SomeArray[Height - 1, Width - 1] = '#';
        }
        public static void CopyStringToArray(int i001, int j001, string SomeString, ref char[,] SomeArray )
        {
            for  (int i = 0; i < SomeString.Length; ++i )
            {
                SomeArray[i001, j001] = SomeString[i];
                ++j001;
            }
        }
        public static void ShowArray(ref char[,] SomeArray)
        {
            int Height = SomeArray.GetUpperBound(0) + 1;
            int Width = SomeArray.Length / Height;
            string Tempo = "";

            for (int i = 0; i < Height; ++i)
            {
                for (int j = 0; j < Width; ++j)
                {
                    Tempo += SomeArray[i, j];
                }
                Console.WriteLine(Tempo);
                Tempo = "";
            }
        }
        //Проверка тёплости зимы, при условии, что до этого был введён номер одного из зимних месяцев
        public static void ReprehendoHieme( ref int Avaragou001, ref int Monthou001)
        {
            if ( Avaragou001 > 0 )
            {
                if ( Monthou001 > -1 && Monthou001 < 1 || Monthou001 == 11 )
                {
                    Console.WriteLine( "Дождливая зима" );
                    return;
                }
            }
            Console.WriteLine("Был введён не зимний месяц");
        }
        //Расписание работы чего-то
        public static void OfficiumCompages()
        {

        }
        //Проверка года на високосность
        public static void CheckYear()
        {
            int SomeYear = GetNumberFromString();

            if( Checkerreiro( ref SomeYear ) )
            {
                Console.WriteLine( "Указанный год високосный" );
                return;
            }
            Console.WriteLine( "Указанный год НЕ високосный" );
        }
        //Дополнительная функция для удобного определения високосности с выходом из функции
        public static bool Checkerreiro( ref int SomeYear001 )
        {
            if ( ( SomeYear001 % 4 == 0 ) )
            {
                if ( SomeYear001 % 400 == 0)
                {
                    return true;
                }
                if ( SomeYear001 % 100 == 0)
                {
                    return false;
                }
                return true;
            }
            return false;
        }
        //Обновление счётчика частей и инекса списка
        //Объявление и очистка консоли
        public static void Update( ref int Value001, ref int Value002 )
        {
            ++Value001;
            ++Value002;

            Console.WriteLine();
            Console.WriteLine( "Для перехода к следующей части нажмите любую клавишу" );            
            Console.ReadKey();
            Console.Clear();
        }
    }
}
