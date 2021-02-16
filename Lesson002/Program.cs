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
            for (int i = 0; i < CountPars; ++i)
            {
                //Вывод части и названия задания
                Console.WriteLine(Pars + Locus + Number + Locus + Denuntiatio[Index]);

                switch (Index)
                {
                    case 0:
                        //Avaragou = CalculateAverageTempe();
                        break;
                    case 1:
                        //Monthou = NameMonth();
                        break;
                    case 2:
                        //DetermineTheNumber();
                        break;
                    case 3:
                        ShowCheck();
                        break;
                    case 4:
                        //ReprehendoHieme( ref Avaragou, ref Monthou );
                        break;
                    case 5:
                        //OfficiumCompages();
                        break;
                }
                if (Index == 6)
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
            int IntraSize = 37;
            char EdgeBorder = '|', VertBorder = '-', AngleBorder = '#', Locus = ' ';
            string LeftPad = "| ", RightPad = " |", Ce = " A";
            string Tempo = "";

            string ChTop = AngleBorder + Tempo.PadLeft(IntraSize, VertBorder) + AngleBorder;
            string EmptyLine = EdgeBorder + Tempo.PadLeft(IntraSize, Locus) + EdgeBorder;

            int PMCe = 15, SKCe = 3, CFCe = 9, CountItems = 3 ;

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
        //Обновление счётчика частей и инекса списка
        //Объявление и очистка консоли
        public static void Update(ref int Value001, ref int Value002)
        {
            ++Value001;
            ++Value002;

            Console.WriteLine();
            Console.WriteLine("Для перехода к следующей части нажмите любую клавишу");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
