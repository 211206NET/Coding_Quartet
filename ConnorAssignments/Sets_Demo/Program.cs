HashSet<int> evenNumbers = new HashSet<int>();
SortedSet<string> alphabetical = new SortedSet<string>();

for (int i = 0; i < 10; i++) {
    // populates even numbers into the set
    evenNumbers.Add(i * 2);
    // should add duplicate numbers, but since it's a hashset it doesn't
    evenNumbers.Add((i * 2) + 2);
}

Console.Write("evenNumbers contains {0} elements: ", evenNumbers.Count);
DisplayHashSet(evenNumbers);


alphabetical.Add("Michael Big");
alphabetical.Add("Joy Evans");
alphabetical.Add("Connor Kobel");
alphabetical.Add("Dennis Sanders");
Console.WriteLine("Please add a name to be sorted alphabetically");
alphabetical.Add(Console.ReadLine());
Console.WriteLine();
DisplaySortedSet(alphabetical);


void DisplayHashSet(HashSet<int> collection)
{
    Console.Write("{");
    foreach (int i in collection)
    {
        Console.Write(" {0}", i);
    }
    Console.WriteLine(" }");
}

void DisplaySortedSet(SortedSet<string> collection) {
    foreach (string i in collection) {
        Console.WriteLine("{0}", i);
    }
}