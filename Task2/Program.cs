//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальное число M:");
            int numberM = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите начальное число M:");
            int numberN = int.Parse(Console.ReadLine());

            ///Метод нахождения суммы натуральных элементов в промежутке от M до N
            void GapNumberSum(int firstNumber, int secondNumber, int sum)
            {
                if (firstNumber > secondNumber)
                {
                    Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
                    return;
                }
                sum = sum + (firstNumber++);
                GapNumberSum(firstNumber, secondNumber, sum);
            }

            GapNumberSum(numberM, numberN, 0);
        }
                }
            }