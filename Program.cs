
Console.Clear();
string playAgain = "yes";
while (playAgain == "yes")
{

    int num1 = 0;
    bool numberOne = false;

    Console.WriteLine("Welcome to odd or even");

    while (!numberOne)
    {
        Console.Write("Enter in a number to see if it is odd or even: ");
        numberOne = Int32.TryParse(Console.ReadLine(), out num1);

        if (!numberOne)
        {
            Console.WriteLine("Invalid please enter in a number");
        }
    }

    if (num1 % 2 == 0)
    {
        Console.WriteLine($"{num1} is even");
    }
    else
    {
        Console.WriteLine($"{num1} is odd");
    }

    Console.Write("Would you like to try again? Type in Yes to retry or No to quit: ");

    string playAgainInput = "Nothing";

    while (playAgainInput != "yes" || playAgainInput != "no")
    {
        playAgainInput = Console.ReadLine().ToLower();
        if (playAgainInput == playAgain)
        {
            break;
        }
        else if (playAgainInput == "no")
        {
            Console.WriteLine("Thanks for playing!");
            playAgain = playAgainInput;
            break;

        }
        else
        {
            Console.WriteLine("Invalid Input");
            playAgainInput = "invalid";
        }
    }
}
