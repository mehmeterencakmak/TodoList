// Random rand = new Random();
// int randomNumber = rand.Next(1, 7);

// int tries = 0;

// Console.WriteLine("Dice rolled. Guess what number it shown in 3 tries");


// while (tries < 3)
// {
//     Console.WriteLine("Enter number: ");   
//     string input = Console.ReadLine();

//     if(!int.TryParse(input, out int userInput) ||
//         userInput < 1 ||
//         userInput > 6)
//     {
//         Console.WriteLine("Incorrect input");
//         continue;
//     }
//     if (userInput == randomNumber)
//     {
//         Console.WriteLine("You win!");
//         break;
//     }
//     tries++;
//     Console.WriteLine("Wrong number");

//     if (tries == 3)
//     {
//         Console.WriteLine("You lose!");
//         break;
//     }
// }


// Console.ReadKey();



// -------- With Class ------------


var random = new Random();

Console.ReadKey();

public class GuessingGame
{
    private readonly Dice _dice;
    private readonly ConsoleReader _consoleReader;
    private const int InitialTries = 3;
   
    public GuessingGame(Dice dice, ConsoleReader consolereader)
    {
        _dice = dice;
        _consoleReader = consolereader;        
    }
    public void Play()
    {
        var diceRollResult = _dice.Roll();
        Console.WriteLine($"Dice rolled. Guess what number it shown in {InitialTries} tries.");

        var triesLeft = InitialTries;
        while(triesLeft > 0)
        {
            var guess = _consoleReader.ReadInteger("Enter a number:");
            triesLeft--;
            
        }
    }
    
}

public class ConsoleReader
{
    public ReadInteger(string message)
    {
        int result;
        do
        {
            Console.WriteLine(message);
        }while(!int.TryParse(Console.ReadLine(), out result));
        return result;
    }
}

public class Dice
{
    private readonly Random _random;
    private const int SidesCount = 6;
    public Dice(Random random, int sidesCount){
        SidesCount = sidesCount;
        _random = random; 
    }

    public int Roll() => _random.Next(1, SidesCount + 1 );

    public void Describe() =>
        Console.WriteLine($"This is a dice with {SidesCount} sides");
 
}
// yarıda kaldı..(sonra bak)