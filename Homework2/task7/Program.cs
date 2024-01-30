
List<int> numbers = new List<int>{ 1, 2, 3, 4, 5 };
numbers.Remove(1);
foreach (int item in numbers)
{
    System.Console.WriteLine(item);
}