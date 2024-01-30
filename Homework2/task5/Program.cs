
List<int> numbers = new List<int>(){ 1, 2, 3, 4, 5 };
List<int> even = numbers.FindAll(el => el % 2 == 0);
    Console.Write("The filtered numbers are:");
foreach (int item in even)
{

    Console.Write(" " + item);
}
System.Console.WriteLine(".");