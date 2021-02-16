using System;

namespace Lesson002
{
    class Program
    {
        [Flags]
        enum MaDays
        {
            Понедельник = 0b0_000_001,
            Вторник =     0b0_000_010,
            Среда =       0b0_000_100,
            Четверг =     0b0_001_000,
            Пятница =     0b0_010_000,
            Суббота =     0b0_100_000,
            Воскресенье = 0b1_000_000
        }

        static void Main(string[] args)
        {
            Executor();
        }


        public static void Executor()
        {
            //Средняя температура, номер выполняемой части, номер выводимого задания, количество частей-заданий
            int Avaragou = 0, Monthou = 0, CountPars = 7;
            string[] Denuntiatio = new string[] { "Средняя температура за сутки", "Название месяца по номеру", "Определение чётности числа", "Отображение чека", "Итог по температуре и месяцам", "Универсальнуая структура расписания недели", "Определение високосности года" };
            //Цикл-обработчик каждого задания
            for (int i = 0; i < CountPars; ++i)
            {
                //Вывод части и названия задания
                Console.WriteLine($"Часть {i + 1}: {Denuntiatio[i]}");

                switch (i)
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
                if (i == 6)
                {
                    CheckYear();

                    Console.WriteLine();
                    Console.WriteLine("Все части пройдены");
                    Console.WriteLine("Для выхода нажмите любую клавишу");
                    Console.ReadKey();

                    break;
                }

                Console.WriteLine();
                Console.WriteLine("Для перехода к следующей части нажмите любую клавишу");
                Console.ReadKey();
                Console.Clear();
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

            if (TMin > TMax)
            {
                int Swapperou = TMin;
                TMin = TMax;
                TMax = Swapperou;
            }

            TAverage = (TMin + TMax) / 2;
            Console.WriteLine("Средняя температура за день равна: " + TAverage);
            return TAverage;
        }
        
        //Выдать по числу название месяца с проверками на выход за пределы, в случае которого выдаёт название предельного
        public static int NameMonth()
        {
            string[] Months = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            Console.WriteLine("Введите номер месяца ");
            int ENM = GetNumberFromString();
            --ENM;

            LeadToBoundaries(ref ENM, 0, 11);

            Console.WriteLine(Months[ENM]);
            return ENM;
        }
        //Проверка чётности числа
        public static void DetermineTheNumber()
        {
            Console.WriteLine("Введите число");
            int SomeNumber = GetNumberFromString();

            if ((SomeNumber %= 2) == 0)
            {
                Console.WriteLine("Чётное");
                return;
            }
            Console.WriteLine("Нечётное");
        }
        //Печать подобия чека в консоль
        public static void ShowCheck()
        {
            string LeftPad = "| ", RightPad = " |", Ce = " A";
            string ChTop = "#-------------------------------------#";
            string EmptyLine = "|                                     |";

            int PMCe = 15, SKCe = 3, CFCe = 9, CountItems = 3;

            Console.WriteLine(ChTop);
            Console.WriteLine(EmptyLine);
            Console.WriteLine("{0, -30} {1, 8}", LeftPad + "FORESTOUWAWA MORKOTTO", RightPad);
            Console.WriteLine(EmptyLine);
            Console.WriteLine("{0, -30} {1, 8}", LeftPad + "3015 Adoms Ovonou", RightPad);
            Console.WriteLine("{0, -30} {1, 8}", LeftPad + "Soun Douegou, CA 45657", RightPad);
            Console.WriteLine("{0, -30} {1, 8}", LeftPad + "(564) 8762 - 345", RightPad);
            Console.WriteLine(EmptyLine);
            Console.WriteLine("{0, -30} {1, 8}", LeftPad + "Pocca Mocorolla", PMCe + Ce + RightPad);
            Console.WriteLine("{0, -30} {1, 8}", LeftPad + "Sokkow Ksovwollu", SKCe + Ce + RightPad);
            Console.WriteLine("{0, -30} {1, 8}", LeftPad + "Capsicum Frutum", CFCe + Ce + RightPad);
            Console.WriteLine(EmptyLine);
            Console.WriteLine("{0, -30} {1, 8}", LeftPad + "Et Exitus", (PMCe + SKCe + CFCe) + Ce + RightPad);
            Console.WriteLine("{0, -30} {1, 8}", LeftPad + "40 % HDC", Math.Round(((PMCe + SKCe + CFCe) * 1.4)) + Ce + RightPad);
            Console.WriteLine(EmptyLine);
            Console.WriteLine("{0, -30} {1, 8}", LeftPad + "Quantitas", CountItems + RightPad);
            Console.WriteLine(EmptyLine);
            Console.WriteLine("{0, -30} {1, 8}", LeftPad + "ARIGATOUKOSAMUMASU", RightPad);
            Console.WriteLine(EmptyLine);
            Console.WriteLine(ChTop);
        }
        //Проверка тёплости зимы, при условии, что до этого был введён номер одного из зимних месяцев
        public static void ReprehendoHieme(ref int Avaragou001, ref int Monthou001)
        {
            if (Avaragou001 > 0)
            {
                if (Monthou001 > -1 && Monthou001 < 1 || Monthou001 == 11)
                {
                    Console.WriteLine("Дождливая зима");
                    return;
                }
            }
            Console.WriteLine("Был введён не зимний месяц");
        }
        //Расписание работы чего-то
        public static void OfficiumCompages()
        {
            Console.WriteLine("Ведите номер одного из трёх офисов для просмотра режма его работы");
            MaDays SomeDays = (MaDays)0b_0000_000;

            int NumberOffice = GetNumberFromString();
            --NumberOffice;

            LeadToBoundaries(ref NumberOffice, 0, 2);
            switch (NumberOffice)
            {
                case 0:
                    SomeDays = (MaDays)0b_01001_001;
                    break;
                case 1:
                    SomeDays = MaDays.Понедельник | MaDays.Среда | MaDays.Воскресенье;
                    break;
                case 2:
                    SomeDays = (MaDays)0b_0011_001;
                    break;
            }

            Console.WriteLine($"Рабочие дни офиса номер {NumberOffice + 1} : {SomeDays}");
        }
        //Проверка года на високосность
        public static void CheckYear()
        {
            int SomeYear = GetNumberFromString();

            if (Checkerreiro(ref SomeYear))
            {
                Console.WriteLine("Указанный год високосный");
                return;
            }
            Console.WriteLine("Указанный год НЕ високосный");
        }
        //Дополнительная функция для удобного определения високосности с выходом из функции
        public static bool Checkerreiro(ref int SomeYear001)
        {
            if ((SomeYear001 % 4 == 0))
            {
                if (SomeYear001 % 400 == 0)
                {
                    return true;
                }
                if (SomeYear001 % 100 == 0)
                {
                    return false;
                }
                return true;
            }
            return false;
        }
        //Получение числа из строки с проверками на неверные значения, по умолчанию выдаёт ноль
        public static int GetNumberFromString()
        {
            string TempoString;
            int SomeValue;
            //Получаем символы в строке
            TempoString = Console.ReadLine();
            //Проверяем на соответствие типу int
            if (!int.TryParse(TempoString, out SomeValue))
            {
                SomeValue = 0;
            }
            return SomeValue;
        }
        //Проверка некого числа на нахождение в указанных границах
        public static void LeadToBoundaries(ref int Value001, int Min, int Max)
        {
            if (Value001 < Min)
            {
                Value001 = Min;
            }
            if (Value001 > Max)
            {
                Value001 = Max;
            }
        }
    }
}
