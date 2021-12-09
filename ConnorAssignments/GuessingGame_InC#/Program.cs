Random rand = new Random();
int randomNum = rand.Next(0, 101);
int counter = 0;
int number;
String input = "";

Console.WriteLine("Try and guess the random number! (between 0 and 100)");
// Console.WriteLine("The number is " + randomNum");
input = Console.ReadLine();
number = int.Parse(input);
while (number < 0 || number > 100) {
    Console.WriteLine("Please enter a number between 0 and 100.");
    input = Console.ReadLine();
    number = int.Parse(input);
}
Console.WriteLine();
counter++;

while (number != randomNum) {
    if (number > randomNum) {
        Console.WriteLine("You're wrong! You guessed too high.");
        if ((number - randomNum) < 5)
            Console.WriteLine("You're super hot!");
        else if((number - randomNum) < 15)
            Console.WriteLine("You're hot!");
        else if ((number - randomNum) < 25)
            Console.WriteLine("You're warm!");
        else if ((number - randomNum) < 35)
            Console.WriteLine("You're cold!");
        else
            Console.WriteLine("You're freezing!");
        Console.WriteLine("Number of tries: " + counter);
        Console.WriteLine("Please guess again.");
        input = Console.ReadLine();
        number = int.Parse(input);
        while (number < 0 || number > 100) {
            Console.WriteLine("Please enter a number between 0 and 100.");
            input = Console.ReadLine();
            number = int.Parse(input);
        }
        Console.WriteLine();
        counter++;
    }
    else if (number < randomNum) {
        Console.WriteLine("You're wrong! You guessed too low.");
        if ((randomNum - number) < 5)
            Console.WriteLine("You're super hot!");
        else if((randomNum - number) < 15)
            Console.WriteLine("You're hot!");
        else if ((randomNum - number) < 25)
            Console.WriteLine("You're warm!");
        else if ((randomNum - number) < 35)
            Console.WriteLine("You're cold!");
        else
            Console.WriteLine("You're freezing!");
        Console.WriteLine("Number of tries: " + counter);
        Console.WriteLine("Please guess again.");
        input = Console.ReadLine();
        number = int.Parse(input);
        while (number < 0 || number > 100) {
            Console.WriteLine("Please enter a number between 0 and 100.");
            input = Console.ReadLine();
            number = int.Parse(input);
        }
        Console.WriteLine();
        counter++;
    }
}
Console.WriteLine();
Console.WriteLine("Total number of guesses: " + counter);
Console.WriteLine("You're right! Have a cookie!");