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
                    Console.WriteLine($"Test {totalTests} Passed: Insert and Find elements.");
                    passedTests++;
                }
                else
                {
                    Console.WriteLine($"Test {totalTests} Failed: Insert and Find elements.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"Test {totalTests} Failed: Insert and Find elements with exception: {ex.Message}"
                );
            }

            // Test GetMin
            totalTests++;
            try
            {
                int? min = tree.GetMin();
                if (min == 2)
                {
                    Console.WriteLine(
                        $"Test {totalTests} Passed: GetMin returns the smallest element."
                    );
                    passedTests++;
                }
                else
                {
                    Console.WriteLine(
                        $"Test {totalTests} Failed: GetMin (Expected: 2, Got: {min})."
                    );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test {totalTests} Failed: GetMin with exception: {ex.Message}");
            }

            // Test GetMax
            totalTests++;
            try
            {
                int? max = tree.GetMax();
                if (max == 8)
                {
                    Console.WriteLine(
                        $"Test {totalTests} Passed: GetMax returns the largest element."
                    );
                    passedTests++;
                }
                else
                {
                    Console.WriteLine(
                        $"Test {totalTests} Failed: GetMax (Expected: 8, Got: {max})."
                    );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test {totalTests} Failed: GetMax with exception: {ex.Message}");
            }

            // Test InOrder
            totalTests++;
            try
            {
                List<int> inOrder = tree.InOrder();
                if (inOrder.SequenceEqual(new List<int> { 2, 3, 4, 5, 6, 7, 8 }))
                {
                    Console.WriteLine($"Test {totalTests} Passed: InOrder traversal.");
                    passedTests++;
                }
                else
                {
                    Console.WriteLine(
                        $"Test {totalTests} Failed: InOrder traversal (Expected: 2, 3, 4, 5, 6, 7, 8, Got: {string.Join(", ", inOrder)})."
                    );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"Test {totalTests} Failed: InOrder traversal with exception: {ex.Message}"
                );
            }

            // Test PreOrder
            totalTests++;
            try
            {
                List<int> preOrder = tree.PreOrder();
                if (preOrder.SequenceEqual(new List<int> { 5, 3, 2, 4, 7, 6, 8 }))
                {
                    Console.WriteLine($"Test {totalTests} Passed: PreOrder traversal.");
                    passedTests++;
                }
                else
                {
                    Console.WriteLine(
                        $"Test {totalTests} Failed: PreOrder traversal (Expected: 5, 3, 2, 4, 7, 6, 8, Got: {string.Join(", ", preOrder)})."
                    );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"Test {totalTests} Failed: PreOrder traversal with exception: {ex.Message}"
                );
            }

            // Test Delete
            totalTests++;
            try
            {
                tree.Delete(3);
                List<int> inOrder = tree.InOrder();
                if (!tree.Find(3) && inOrder.SequenceEqual(new List<int> { 2, 4, 5, 6, 7, 8 }))
                {
                    Console.WriteLine($"Test {totalTests} Passed: Delete an element.");
                    passedTests++;
                }
                else
                {
                    Console.WriteLine(
                        $"Test {totalTests} Failed: Delete an element (Expected: 2, 4, 5, 6, 7, 8, Got: {string.Join(", ", inOrder)})."
                    );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"Test {totalTests} Failed: Delete an element with exception: {ex.Message}"
                );
            }

            // Additional Test: Delete non-existing element
            totalTests++;
            try
            {
                tree.Delete(10); // Try deleting a non-existing element
                Console.WriteLine(
                    $"Test {totalTests} Passed: Delete non-existing element (No exception thrown)."
                );
                passedTests++;
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"Test {totalTests} Failed: Delete non-existing element with exception: {ex.Message}"
                );
            }

            // Summary
            Console.WriteLine($"\nSummary: {passedTests} out of {totalTests} tests passed.");
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
}
