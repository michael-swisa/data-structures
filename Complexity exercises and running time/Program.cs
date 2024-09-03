// See https://aka.ms/new-console-template for more information

using Complexity_exercises_and_running_time;

Console.WriteLine("Hello, World!");

//int[] array = { 8, 1, 4, 3, 9, 5 };
//Sortes.InsertionSort(array);

//foreach (var item in array)
//{
//    Console.Write(item + " ");
//}


LinkedList linkedList = new LinkedList(0);
linkedList.Add(0);
linkedList.Add(2);
linkedList.Add(3);
linkedList.Add(2);
linkedList.Add(5);
Console.WriteLine(linkedList.Display());
Console.WriteLine(linkedList.Length());

//linkedList.RemoveAllValues(2);
Console.WriteLine(linkedList.Get(0));
