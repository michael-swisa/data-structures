namespace Complexity_exercises_and_running_time.Testers
{
    internal class TesterQueue
    {
        static int totalTests = 0;
        static int passedTests = 0;

        public static void Main()
        {
            // הרצת בדיקות עבור תור
            TestQueue_EnqueueAndDequeue_ShouldReturnCorrectValues();
            TestQueue_Peek_ShouldReturnFrontWithoutRemoving();
            TestQueue_GetCount_ShouldReturnCorrectCount();
            // סיכום תוצאות
            PrintSummary();
        }

        // פונקציות בדיקה לתור
        static void TestQueue_EnqueueAndDequeue_ShouldReturnCorrectValues()
        {
            totalTests++;
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            try
            {
                if (queue.Dequeue() != 1)
                    throw new Exception();
                if (queue.Dequeue() != 2)
                    throw new Exception();
                if (queue.Dequeue() != 3)
                    throw new Exception();

                passedTests++;
                Console.WriteLine(
                    $"Test {totalTests} Passed: Enqueue and Dequeue return correct values."
                );
            }
            catch
            {
                Console.WriteLine(
                    $"Test {totalTests} Failed: Enqueue and Dequeue did not return correct values."
                );
            }
        }

        static void TestQueue_Peek_ShouldReturnFrontWithoutRemoving()
        {
            totalTests++;
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            try
            {
                if (queue.Peek() != 1)
                    throw new Exception();
                if (queue.Peek() != 1)
                    throw new Exception(); // Peek shouldn't remove the item

                passedTests++;
                Console.WriteLine(
                    $"Test {totalTests} Passed: Peek returns front without removing."
                );
            }
            catch
            {
                Console.WriteLine(
                    $"Test {totalTests} Failed: Peek did not return front correctly."
                );
            }
        }

        static void TestQueue_GetCount_ShouldReturnCorrectCount()
        {
            totalTests++;
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            try
            {
                if (queue.GetCount() != 2)
                    throw new Exception();
                queue.Dequeue();
                if (queue.GetCount() != 1)
                    throw new Exception();

                passedTests++;
                Console.WriteLine(
                    $"Test {totalTests} Passed: GetCount returns the correct number of elements."
                );
            }
            catch
            {
                Console.WriteLine(
                    $"Test {totalTests} Failed: GetCount did not return the correct number of elements."
                );
            }
        }

        // סיכום
        static void PrintSummary()
        {
            Console.WriteLine($"\nSummary: {passedTests} out of {totalTests} tests passed.");
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
