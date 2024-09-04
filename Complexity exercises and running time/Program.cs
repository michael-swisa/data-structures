using Complexity_exercises_and_running_time;

class Program
{
    static int totalTests = 0;
    static int passedTests = 0;

    static void Main(string[] args)
    {
        // הרצת בדיקות עבור מחסנית
        TestStack_PushAndPop_ShouldReturnCorrectValues();
        TestStack_Peek_ShouldReturnTopWithoutRemoving();
        TestStack_GetCount_ShouldReturnCorrectCount();

        // הרצת בדיקות עבור תור
        TestQueue_EnqueueAndDequeue_ShouldReturnCorrectValues();
        TestQueue_Peek_ShouldReturnFrontWithoutRemoving();
        TestQueue_GetCount_ShouldReturnCorrectCount();

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
            Console.WriteLine("TestQueue_EnqueueAndDequeue_ShouldReturnCorrectValues: Passed");
        }
        catch
        {
            Console.WriteLine("TestQueue_EnqueueAndDequeue_ShouldReturnCorrectValues: Failed");
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
            Console.WriteLine("TestQueue_Peek_ShouldReturnFrontWithoutRemoving: Passed");
        }
        catch
        {
            Console.WriteLine("TestQueue_Peek_ShouldReturnFrontWithoutRemoving: Failed");
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
            Console.WriteLine("TestQueue_GetCount_ShouldReturnCorrectCount: Passed");
        }
        catch
        {
            Console.WriteLine("TestQueue_GetCount_ShouldReturnCorrectCount: Failed");
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
