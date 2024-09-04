using System;

namespace Complexity_exercises_and_running_time.Testers
{
    internal class TesterStack
    {
        static int totalTests = 0;
        static int passedTests = 0;

        public static void Main()
        {
            // הרצת בדיקות עבור מחסנית
            TestStack_PushAndPop_ShouldReturnCorrectValues();
            TestStack_Peek_ShouldReturnTopWithoutRemoving();
            TestStack_GetCount_ShouldReturnCorrectCount();
            // סיכום תוצאות
            PrintSummary();
        }

        // פונקציות בדיקה למחסנית
        static void TestStack_PushAndPop_ShouldReturnCorrectValues()
        {
            totalTests++;
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            try
            {
                if (stack.Pop() != 3)
                    throw new Exception();
                if (stack.Pop() != 2)
                    throw new Exception();
                if (stack.Pop() != 1)
                    throw new Exception();
                passedTests++;
                Console.WriteLine("TestStack_PushAndPop_ShouldReturnCorrectValues: Passed");
            }
            catch
            {
                Console.WriteLine("TestStack_PushAndPop_ShouldReturnCorrectValues: Failed");
            }
        }

        static void TestStack_Peek_ShouldReturnTopWithoutRemoving()
        {
            totalTests++;
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            try
            {
                if (stack.Peek() != 3)
                    throw new Exception();
                if (stack.Peek() != 3)
                    throw new Exception(); // Peek shouldn't remove the item
                passedTests++;
                Console.WriteLine("TestStack_Peek_ShouldReturnTopWithoutRemoving: Passed");
            }
            catch
            {
                Console.WriteLine("TestStack_Peek_ShouldReturnTopWithoutRemoving: Failed");
            }
        }

        static void TestStack_GetCount_ShouldReturnCorrectCount()
        {
            totalTests++;
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            try
            {
                if (stack.GetCount() != 2)
                    throw new Exception();
                stack.Pop();
                if (stack.GetCount() != 1)
                    throw new Exception();
                passedTests++;
                Console.WriteLine("TestStack_GetCount_ShouldReturnCorrectCount: Passed");
            }
            catch
            {
                Console.WriteLine("TestStack_GetCount_ShouldReturnCorrectCount: Failed");
            }
        }

        // סיכום
        static void PrintSummary()
        {
            Console.WriteLine($"Passed {passedTests}/{totalTests} tests.");
            if (passedTests == totalTests)
            {
                Console.WriteLine("All tests passed!");
            }
            else
            {
                Console.WriteLine($"{totalTests - passedTests} tests failed.");
            }
            double score = (double)passedTests / totalTests * 100;
            Console.WriteLine($"Final score: {score:0.00}%");
        }
    }
}
