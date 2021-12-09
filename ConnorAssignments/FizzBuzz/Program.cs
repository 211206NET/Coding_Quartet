Console.WriteLine();
Console.WriteLine("FizzBuzz");

// Console.WriteLine("Enter a positive integer");
// // string variable for input
// String input = Console.ReadLine();

// // verifying input
// Console.WriteLine("You entered " + input);

// // change the string to an integer
// int number = int.Parse(input);
// Console.WriteLine("We parsed your input to " + number);

// while (number <= 0) {
//     Console.WriteLine("The number should be greater than 0");
//     Console.WriteLine("Enter a positive number");
//     input = Console.ReadLine();
//     number = int.Parse(input);
//     Console.WriteLine();
// }


string input = "";
int number = 0;
do {
    Console.WriteLine("Enter a positive number");
    input = Console.ReadLine();
    number = int.Parse(input);
    Console.WriteLine();

    if (number <= 0) {
        Console.WriteLine("The number should be greater than 0");
    }
} while (number <= 0);

// count up to the number and print all numbers
for (int i = 1; i <= number; i++) {
    if (i % 15 == 0) {
        Console.WriteLine("FizzBuzz (" + i + ")");
    } else if (i % 3 == 0) {
        Console.WriteLine("Fizz (" + i + ")");
    } else if (i % 5 == 0) {
        Console.WriteLine("Buzz (" + i + ")");
    } else {
        Console.WriteLine(i);
    }
}