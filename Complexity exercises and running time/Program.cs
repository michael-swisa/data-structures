//Console.WriteLine("Running All Tests...\n");

//// Linked List Tests
//Console.WriteLine("=== Linked List Tests ===\n");
//TesterLinkedList.Main();
//Console.WriteLine();

//// Stack Tests
//Console.WriteLine("=== Stack Tests ===\n");
//TesterStack.Main();
//Console.WriteLine();

//// Queue Tests
//Console.WriteLine("=== Queue Tests ===\n");
//TesterQueue.Main();
//Console.WriteLine();

//// Binary Tree Tests
//Console.WriteLine("=== Binary Tree Tests ===\n");
//TesterBinaryTree.Main();
//Console.WriteLine();

//Console.WriteLine("All tests completed.");

//public class Program
//{
//    public static object JsonConvert { get; private set; }
//    public static object JsonFileReader { get; private set; }

//    public static void Main(string[] args)
//    {
//        string filePath =
//            @"C:\_kodcode2\second half\C#\first week\Tuesday\Complexity exercises and running time\Complexity exercises and running time\Tree.json";
//        string jsonString = File.ReadAllText(filePath);

//        var data = JsonSerializer.Deserialize<Dictionary<string, BinaryJson>>(jsonString);

//        var trees = new Dictionary<string, BinaryTree>();
//        foreach (var kvp in data)
//        {
//            BinaryTree tree = new BinaryTree();

//            foreach (var number in kvp.Value.Values)
//            {
//                tree.Insert(number);
//            }
//            trees[kvp.Key] = tree;
//        }
//        foreach (var kvp in trees)
//        {
//            Console.WriteLine($"Tree for key: {kvp.Key}");
//            Console.WriteLine($"Min: {kvp.Value.GetMin()}");
//            Console.WriteLine($"Max: {kvp.Value.GetMax()}");
//            Console.WriteLine();
//        }
//    }
//}

using Complexity_exercises_and_running_time;

int result = RecurrsionExercises.Ex12subtracEvenOdd(12345);
Console.WriteLine(result);
Console.ReadLine();
