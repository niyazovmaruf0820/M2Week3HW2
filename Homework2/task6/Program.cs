List<bool> boolList = new List<bool> { true, true, false, true };

bool allTrue = boolList.All(b => b == true);
Console.WriteLine("Are all the values in the list true? " + allTrue + ".");