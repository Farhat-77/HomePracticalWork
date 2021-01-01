using System;

namespace HomePracticalWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // Дано расстояние в сантиметрах.Найти число полных метров в нем
            public Program()
            {
                Console.WriteLine("Введите расстояние в см :");
                int i = int.Parse(Console.ReadLine());
                Console.Write("Полных м: ");
                Console.WriteLine(i / 100);
            }
            // С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?
            static void Main(string[] args)
            {
                const int daysInWeek = 7;
                int days = 234;
                int weeks = days / daysInWeek;
                Console.WriteLine("дней: {0}\nнедель: {1}", days, weeks);
                Console.ReadLine();
            }
            /* Дано двузначное число. Найти:
               a.	число десятков в нем;
               b.	число единиц в нем;
               c.	сумму его цифр;
               d.	произведение его цифр
               */
            static void Main(string[] args)
            {
                Console.WriteLine("Введите двух значное число: ");
                int number = Int32.Parse(Console.ReadLine());
                int dec = number / 10;
                int unt = number % 10;
                int sum = dec + unt;
                int mult = dec * unt;
                Console.WriteLine("Число десяток: " + dec);
                Console.WriteLine("Число единиц: " + unt);
                Console.WriteLine("Сумма цифр: " + sum);
                Console.WriteLine("Произведение цифр: " + mult);
                Console.ReadLine();
            }
            /*6.	Дано четырехзначное число. Найти:
              a.	сумму его цифр;
              b.	произведение его цифр.
              */
            static void Main(string[] args)
            {
                int number = Int32.Parse(Console.ReadLine());
                int sum = dec + unt;
                int mult = dec * unt;
                Console.WriteLine("Сумма цифр: " + sum);
                Console.WriteLine("Произведение цифр: " + mult);
                Console.ReadLine();
            }
            /*
             7.	В трехзначном числе x зачеркнули его вторую цифру. 
            Когда к образованному при этом двузначному числу справа приписали вторую цифру числа x, 
            то получилось число 456. Найти число x.*/
            static void Main(string[] args)
            {
                int a;
                Console.Write("Введите трехзначное число ()");
                Console.WriteLine("Ответ: {0}", 456 % 100 / 10 * 100 + 546 / 100 * 10 + 456 % 10);
                Console.WriteLine();
            }
            /*
             8.	Вычислить значение логического выражения при всех возможных значениях логических величин X и Y:
             a.	не X и не Y;
             b.	X или (не X и Y);
             c.	(не X и Y) или Y.
             */
            bool A, B, C, X, Y, result_A, result_B, result_C;
            result_A = !X && !Y;
            result_B = X || !X && Y;
            result_C = !X && Y || Y;
        }
    }
}
