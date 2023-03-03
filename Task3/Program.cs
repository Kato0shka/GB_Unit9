//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//m = 2, n = 3->A(m, n) = 9
//m = 3, n = 2->A(m, n) = 29
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа вычисления функции Аккермана");
            Console.Write("Введите число m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (m <= 0 || n <= 0)
            {
                Console.Write("Введено не натуральное число!!!   ");
                return;
            }
            int result = AckermanFunction(m, n);
            Console.Write($"Результат функции = {result} ");
            int AckermanFunction(int firstNumber, int secondNumber)
            {
                if (firstNumber == 0) return secondNumber + 1;
                else if (secondNumber == 0) return AckermanFunction(firstNumber - 1, 1);
                else return AckermanFunction(firstNumber - 1, AckermanFunction(firstNumber,secondNumber - 1));
            }
        }
    }
}