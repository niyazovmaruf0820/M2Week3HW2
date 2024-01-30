List<double> numbers = new List<double>{ 3.5, 2.7, 6.9, 1.2 };
double sum = 0;
foreach (double item in numbers)
{
    sum += item;
}
double average = (double)sum/numbers.Count;
Console.WriteLine("The average value of all the elements in the list is: " + average);