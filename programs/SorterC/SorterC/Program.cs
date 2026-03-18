List<int> list = new List<int>();

var r = new Random();

for (int i = 0; i < 10; i++)
    list.Add(r.Next(0, 100) + 1);

Console.WriteLine($"Unsorted: [{string.Join(", ", list)}]");
list.Sort();
Console.WriteLine($"Sorted: [{string.Join(", ", list)}]");