Random random = new Random();
List<int> numbers = new List<int>(){};
for (int i = 0; i < random.Next(1, 50); i++)
{
    numbers.Add(random.Next(1,10));
}

foreach (int item in numbers)
{
    System.Console.WriteLine(item);
}




