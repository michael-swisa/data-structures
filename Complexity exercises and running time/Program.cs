using Complexity_exercises_and_running_time;

BinaryTree binaryTree = new BinaryTree();
binaryTree.Insert(5);
binaryTree.Insert(3);
binaryTree.Insert(7);
binaryTree.Insert(2);
binaryTree.Insert(4);
binaryTree.Insert(6);
binaryTree.Insert(8);

Console.WriteLine(binaryTree.Find(5));
Console.WriteLine(binaryTree.Find(6));
Console.WriteLine(binaryTree.Find(7));
Console.WriteLine(binaryTree.Find(8));
Console.WriteLine(binaryTree.Find(9));

Console.WriteLine(binaryTree.GetMin());
Console.WriteLine(binaryTree.GetMax());
