﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complexity_exercises_and_running_time
{
    internal class RecurrsionExercises
    {
        public static int Ex1Multiply(int a, int b)
        {
            if (b == 0)
                return 0;
            return a + Ex1Multiply(a, b - 1);
        }

        public static int Ex2sumOfDigits(int num)
        {
            if (num < 10)
                return num;

            return num % 10 + Ex2sumOfDigits(num / 10);
        }

        public static int Ex3Power(int a, int b)
        {
            if (b == 0)
                return 1;
            return a * Ex3Power(a, b - 1);
        }

        public static int Ex4Reversed(int a)
        {
            int p = -1;
            int b = a;
            while (b > 0)
            {
                p++;
                b /= 10;
            }
            if (a / 10 == 0)
                return a;
            return Ex4Reversed(a / 10) + a % 10 * (int)Math.Pow(10, p);
        }

        public static int Ex5findSum(List<int> list, int index)
        {
            if (index == 0)
                return 0;

            return list[index - 1] + Ex5findSum(list, index - 1);
        }

        //public static double Ex6divide(double a, double b)
        //{
        //    if (b == 0)
        //        return 0;
        //    return Ex6divide();
        //}

        public static bool Ex7isPalindrome(string str)
        {
            if (str.Length == 1)
            {
                return true;
            }
            if (str[0] == str[str.Length - 1])
            {
                return Ex7isPalindrome(str.Substring(1, str.Length - 2));
            }
            return false;
        }

        public static int Ex8DecimalToBinary(int num)
        {
            if (num == 0)
                return 0;
            return num % 2 + 10 * Ex8DecimalToBinary(num / 2);
        }

        public static void Ex9evenNumbers(int num)
        {
            if (num == 0)
                return;
            if (num % 2 != 0)
                Ex9evenNumbers(num - 1);
            else
            {
                Ex9evenNumbers(num - 2);
                Console.Write(num + " ");
            }
        }
    }
}
