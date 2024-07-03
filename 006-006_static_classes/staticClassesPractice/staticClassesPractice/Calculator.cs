using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticClassesPractice
{
    static class Calculator
    {
        internal static int Add(params int[] a)        //with variable number of params
        {
            int sum = 0;
            foreach (int i in a)
            {
                sum += i;
            }
            return sum;
        }
        internal static int Subtract(int a, int b) => a - b;   //lambda func
        internal static int Multiply(int a, int b) => a * b;
        internal static int Division(int a, int b) => a / b;
    }
}
