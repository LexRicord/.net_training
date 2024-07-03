using System;
using staticClassesPractice;
//Создать статический класс Calculator, с методами для выполнения основных арифметических операций.
//Написать программу, которая выводит на экран основные арифметические операции. +

namespace Program
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine(Calculator.Add(1, 3, 4, 5));
            Console.WriteLine(Calculator.Subtract(6, 2));
            Console.WriteLine(Calculator.Multiply(6, 2));
            Console.WriteLine(Calculator.Division(6, 2));
        }
    }
}
