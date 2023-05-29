using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika2023Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Номер 1.1");

            Console.Write("Введите число: ");
            double number = double.Parse(Console.ReadLine());

            if (number > 0)
            {
                number += 5;
            }
            else if (number < 0)
            {
                number -= 5;
            }

            Console.WriteLine("Результат: " + number);
            Console.ReadKey();

            Console.WriteLine("Номер 1.2");

            Console.WriteLine("Введите три числа:");

            Console.Write("Число 1: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Число 2: ");
            double number2 = double.Parse(Console.ReadLine());

            Console.Write("Число 3: ");
            double number3 = double.Parse(Console.ReadLine());

            double maxNumber = number1;

            if (number2 > maxNumber)
            {
                maxNumber = number2;
            }

            if (number3 > maxNumber)
            {
                maxNumber = number3;
            }

            Console.WriteLine("Наибольшее число: " + maxNumber);
            Console.ReadKey();

            Console.WriteLine("Номер 1.3");

            Console.WriteLine("Введите три числа:");

            Console.Write("Число 1: ");
            double number_1 = double.Parse(Console.ReadLine());

            Console.Write("Число 2: ");
            double number_2 = double.Parse(Console.ReadLine());

            Console.Write("Число 3: ");
            double number_3 = double.Parse(Console.ReadLine());

            double sum = 0;

            if (number_1 > 0)
            {
                sum += number_1;
            }

            if (number_2 > 0)
            {
                sum += number_2;
            }

            if (number_3 > 0)
            {
                sum += number_3;
            }

            Console.WriteLine("Сумма + чисел равна " + sum);
            Console.ReadKey();

            Console.WriteLine("Номер 1.4");

            Console.Write("Введите число: ");
            int x = int.Parse(Console.ReadLine());

            if (x > 10)
            {
                x *= 2;
            }

            Console.WriteLine("Результат: " + x);
            Console.ReadKey();

            Console.WriteLine("Номер 1.5");

            Console.Write("Число от 1 до 7: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("День - ");
            switch (num)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
            }
            Console.ReadKey();

            Console.WriteLine("Номер 2.1");

            int border_number = 200;
            while (border_number % 17 != 0)
            {
                border_number++;
            }
            Console.WriteLine("Минимальное число, >200 и делящееся нацело на 17: " + border_number);
            Console.ReadKey();

            Console.WriteLine("Номер 2.2");

            double distance = 10;
            int day = 1;

            while (distance < 20) // 20
            {
                distance += distance * 0.05; // +5%
                day++;
            }
            Console.WriteLine("День, когда преодолел 20 километров: " + day);

            distance = 10;
            day = 1;

            while (distance < 100) // 100
            {
                distance += distance * 0.05; // +5%
                day++;
            }
            Console.WriteLine("День, когда сумма расстояний больше 100 километров: " + day);

            Console.WriteLine("Номер 2.3");

            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());

            int factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("Факториал числа " + n + " равен: " + factorial);
            Console.ReadKey();

            Console.WriteLine("Номер 2.4");

            Console.Write("Введите натуральное число: ");
            int natural_number = int.Parse(Console.ReadLine());

            int smallestDivisor = FindSmallestDivisor(natural_number);

            Console.WriteLine("Наименьший делитель числа " + natural_number + ", отличный от 1: " + smallestDivisor);
            Console.ReadKey();
        }

        static int FindSmallestDivisor(int number)
        {
            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    return divisor;
                }
            }
            return number;
        }
    }
}
            

