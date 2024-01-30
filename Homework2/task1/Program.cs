using System.Collections.Generic;
List<int> numbers = new List<int>(){1, 2, 3, 4, 5};
int sum = 0;
foreach (int item in numbers)
{
    sum += item;
}

System.Console.WriteLine("The sum of all the elements in the list is: " + sum);