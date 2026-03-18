List<int> list = new List<int>{ 25, 45, 35, 68, 14, 8, 37, 24, 85, 35};

Console.WriteLine($"Unsorted: [{string.Join(", ", list)}]");
list.Sort();
Console.WriteLine($"Sorted: [{string.Join(", ", list)}]");