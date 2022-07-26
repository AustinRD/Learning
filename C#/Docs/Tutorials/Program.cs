// See https://aka.ms/new-console-template for more information

WorkWithString();

/*
    String Interpolation - strings preceded with a $ operator, may contain embedded C#.
*/
void WorkWithString() {
    // List Collections Tutorial
    var names = new List<string> { "Austin", "Ana", "Felipe" };
    foreach (var name in names) {
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }

    Console.WriteLine();
    // Modifying List Contents
    names.Add("Maria");
    names.Add("Bill");
    names.Remove("Ana");

    foreach (var name in names) {
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }

    // Accessing items in a list by index
    Console.WriteLine($"My name is {names[0]}");
    Console.WriteLine($"The list has {names.Count} people in it.");

    // Searching and Sorting lists
    var index = names.IndexOf("Maria");
    if (index == -1) {
        Console.WriteLine($"When an item is not found, IndexOf returns {index}");
    } else {
        Console.WriteLine($"The name {names[index]} is at index {index}");
    }

    index = names.IndexOf("Not Found");
    if (index == -1) {
        Console.WriteLine($"When an item is not found, IndexOf returns {index}");
    } else {
        Console.WriteLine($"The name {names[index]} is at index {index}");
    }

    names.Sort();
    foreach (var name in names) {
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }


    // Fibonacci Challenge
    var fibonacciNumbers = new List<int> {1, 1};

    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

    fibonacciNumbers.Add(previous + previous2);

    for(int i = 0; i < 17; ++i) {
        previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
        previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

        fibonacciNumbers.Add(previous + previous2);
    }

    foreach (var item in fibonacciNumbers) {
        Console.WriteLine(item);
    }

    
}