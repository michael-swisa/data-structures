using System;
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
    }
}
