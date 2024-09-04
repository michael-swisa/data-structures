using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complexity_exercises_and_running_time.Testers
{
    internal class TesterBinaryTree
    {
        public static void Main()
        {
            int passedTests = 0;
            int totalTests = 0;

            // Create an instance of BinaryTree
            BinaryTree tree = new BinaryTree();

            // Test Insert and Find
            totalTests++;
            try
            {
                tree.Insert(5);
                tree.Insert(3);
                tree.Insert(7);
                tree.Insert(2);
                tree.Insert(4);
                tree.Insert(6);
                tree.Insert(8);

                if (tree.Find(5) && tree.Find(2) && !tree.Find(10))
                {
                    Console.WriteLine("Test 1: Insert and Find - Passed");
                    passedTests++;
                }
                else
                {
                    Console.WriteLine("Test 1: Insert and Find - Failed");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test 1: Insert and Find - Failed with exception: {ex.Message}");
            }

            // Test GetMin
            totalTests++;
            try
            {
                int? min = tree.GetMin();
                if (min == 2)
                {
                    Console.WriteLine("Test 2: GetMin - Passed");
                    passedTests++;
                }
                else
                {
                    Console.WriteLine($"Test 2: GetMin - Failed (Expected: 2, Got: {min})");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test 2: GetMin - Failed with exception: {ex.Message}");
            }

            // Test GetMax
            totalTests++;
            try
            {
                int? max = tree.GetMax();
                if (max == 8)
                {
                    Console.WriteLine("Test 3: GetMax - Passed");
                    passedTests++;
                }
                else
                {
                    Console.WriteLine($"Test 3: GetMax - Failed (Expected: 8, Got: {max})");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test 3: GetMax - Failed with exception: {ex.Message}");
            }

            // Test InOrder
            totalTests++;
            try
            {
                List<int> inOrder = tree.InOrder();
                if (inOrder.SequenceEqual(new List<int> { 2, 3, 4, 5, 6, 7, 8 }))
                {
                    Console.WriteLine("Test 4: InOrder - Passed");
                    passedTests++;
                }
                else
                {
                    Console.WriteLine(
                        $"Test 4: InOrder - Failed (Expected: 2, 3, 4, 5, 6, 7, 8, Got: {string.Join(", ", inOrder)})"
                    );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test 4: InOrder - Failed with exception: {ex.Message}");
            }

            // Test PreOrder
            totalTests++;
            try
            {
                List<int> preOrder = tree.PreOrder();
                if (preOrder.SequenceEqual(new List<int> { 5, 3, 2, 4, 7, 6, 8 }))
                {
                    Console.WriteLine("Test 5: PreOrder - Passed");
                    passedTests++;
                }
                else
                {
                    Console.WriteLine(
                        $"Test 5: PreOrder - Failed (Expected: 5, 3, 2, 4, 7, 6, 8, Got: {string.Join(", ", preOrder)})"
                    );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test 5: PreOrder - Failed with exception: {ex.Message}");
            }

            // Test Delete
            totalTests++;
            try
            {
                tree.Delete(3);
                List<int> inOrder = tree.InOrder();
                if (!tree.Find(3) && inOrder.SequenceEqual(new List<int> { 2, 4, 5, 6, 7, 8 }))
                {
                    Console.WriteLine("Test 6: Delete - Passed");
                    passedTests++;
                }
                else
                {
                    Console.WriteLine(
                        $"Test 6: Delete - Failed (Expected: 2, 4, 5, 6, 7, 8, Got: {string.Join(", ", inOrder)})"
                    );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test 6: Delete - Failed with exception: {ex.Message}");
            }

            // Additional Test: Delete non-existing element
            totalTests++;
            try
            {
                tree.Delete(10); // Try deleting a non-existing element
                Console.WriteLine(
                    "Test 7: Delete non-existing element - Passed (No exception thrown)"
                );
                passedTests++;
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"Test 7: Delete non-existing element - Failed with exception: {ex.Message}"
                );
            }

            // Summary
            Console.WriteLine($"\nSummary: {passedTests}/{totalTests} tests passed.");
            int score = (passedTests * 100) / totalTests;
            Console.WriteLine($"Final Score: {score}%");

            if (passedTests == totalTests)
            {
                Console.WriteLine("All tests passed successfully!");
            }
            else
            {
                Console.WriteLine("Some tests failed. Please review the results above.");
            }
        }
    }

    //public void Play()
    //{

    //}
}
