// 1)
List<string> strings = new List<string>();
// 2)
strings.Add("apple");
strings.Add("banana");
strings.Add("orange");
// 3)
System.Console.WriteLine(strings.Count);
// 4)
foreach (var item in strings)
{
    System.Console.Write(item + " ");
}
// 5)
strings.Remove("banana");
// 6)
System.Console.WriteLine(strings.Contains("apple"));
// 7)
strings.Clear();
// 8)
List<string> strings1 = new List<string>(){"apple", "banana", "orange"};
// 9)
strings1.Insert(0, "grape");
// 10)
string position2 = strings1[2];
strings1.RemoveAt(2);
System.Console.WriteLine(position2);
// 11)
bool IsEmpty;
if (strings1.Count > 0) IsEmpty = false;
else IsEmpty = true;
System.Console.WriteLine(IsEmpty);
strings1.Sort();
// 13)
strings1.Reverse();
// 14)
List<string> strings2 = new List<string>(){"akaiOrzu", "marufniyazov", "aka","amir"};
strings1.AddRange(strings2);
// 15)
string find = strings1.Find(e => e == "apple");
System.Console.WriteLine(find);
for (int i = 0; i < strings1.Count; i++)
{
    if (strings1[i] == find)
    System.Console.WriteLine(i);
}
// 16)
strings1.RemoveAll(e => e.Length > 5);
// 17)
List<string> strings3 = strings1.FindAll(e => e[0] == 'a');
System.Console.WriteLine(strings3.Count);
// 18)
List<string> strings4 = new List<string>();
foreach (var item in strings1)
{
    strings4.Add(item);
}
// 19)
strings1.Reverse();
// 20)
string concat = string.Join(",", strings1);
foreach (var item in strings4)
{
    System.Console.WriteLine(item);
}