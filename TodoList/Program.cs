// Console.WriteLine("Hello, World!");
// Console.WriteLine("[S]ee all TOTOs");
// Console.WriteLine("[A]dd a TODO");
// Console.WriteLine("[R]emove a TODO");
// Console.WriteLine("[E]xit");

// var userChoice = Console.ReadLine();


// if (userChoice.Length <3 )
// {
//    Console.WriteLine("Short answer.");
// }
// else if(userChoice.Length <= 10)
// {
//     Console.WriteLine("Medium answer.");
// }

// else
// {
//     Console.WriteLine("Long Answer");
// }
// Console.ReadKey();

// bool isUserInputAbc = userChoice == "ABC";
// bool isUserInputNotAbc = userChoice != "ABC";
// bool isUserInputNotAbc2 = !(userChoice == "ABC");


// string userInput = "A";
// Console.WriteLine(userInput);
// userInput = "ABC";
// Console.WriteLine(userInput);

// int number;
// number = 7;
// Console.WriteLine(number);

// int a = 1, b=2;
// string name, surname;

// Console.ReadKey();

// string @class = "First";

// int a = 10;
// int b = 5;

// Console.WriteLine(a + b);
// Console.WriteLine(a - b);
// Console.WriteLine(a * b);
// Console.WriteLine(a / b);
// Console.WriteLine("Mehmet" + " " + "Eren");


// string word = "ABC";
// int number = 5;

// var worde = "AWEADS";
// Console.WriteLine();

// //scope
// Console.WriteLine("Hello, World!");
// Console.WriteLine("[S]ee all TOTOs");
// Console.WriteLine("[A]dd a TODO");
// Console.WriteLine("[R]emove a TODO");
// Console.WriteLine("[E]xit");

// var userChoice = Console.ReadLine();

// if(userChoice.Length == 0)
// {
//     Console.WriteLine("Empty choice!");
//     int number = 5;
//     Console.WriteLine(number);
// }
// else
// {
//     Console.WriteLine("Non-empty choice: "+ userChoice) ;
// }
// Console.WriteLine("Your choice is: "+ userChoice);

// Console.ReadKey();


// // METHODS == function

// Console.WriteLine("Hello, World!");
// Console.WriteLine("[S]ee all TOTOs");
// Console.WriteLine("[A]dd a TODO");
// Console.WriteLine("[R]emove a TODO");
// Console.WriteLine("[E]xit");

// var userChoice = Console.ReadLine();

// if( userChoice == "S")
// {
//     Console.WriteLine("Selected option: See all TODOs");
// }
// else if ( userChoice == "A" )
// {
//     PrintSelectedOption("See all TODOs");
// }
// else if(userChoice == "R")
// {
//     PrintSelectedOption("Remove a TODO");
// }
// else if ( userChoice == "E")
// {
//     PrintSelectedOption("Exit");
// }

// Console.ReadKey();

// void PrintSelectedOption(string selectedOption)
// {
//     Console.WriteLine("Selected option: " + selectedOption);
// }



// // METHODS2 == function

// using System.ComponentModel;

// Console.WriteLine("Hello, World!");
// Console.WriteLine("[S]ee all TOTOs");
// Console.WriteLine("[A]dd a TODO");
// Console.WriteLine("[R]emove a TODO");
// Console.WriteLine("[E]xit");

// var userChoice = Console.ReadLine();
// bool isLong = IsLong(userChoice);

// var result = Add(10,5);
// Console.WriteLine("10 + 5 = " + result);

// // if( userChoice == "S")
// // {
// //     Console.WriteLine("Selected option: See all TODOs");
// // }
// // else if ( userChoice == "A" )
// // {
// //     PrintSelectedOption("See all TODOs");
// // }
// // else if(userChoice == "R")
// // {
// //     PrintSelectedOption("Remove a TODO");
// // }
// // else if ( userChoice == "E")
// // {
// //     PrintSelectedOption("Exit");
// // }

// // Console.ReadKey();

// // void PrintSelectedOption(string selectedOption)
// // {
// //     Console.WriteLine("Selected option: " + selectedOption);
// // }


// int Add (int a, int b)
// {
//     return a + b; 
// }

// bool IsLong(string input)
// {
//     return input.Length >10;
     
// }


// // parse
// Console.WriteLine("Provide a number");
// string userInput = Console.ReadLine();
// int number = int.Parse(userInput);
// Console.WriteLine(number);


// Console.WriteLine("Provide a number");
// string userInput = Console.ReadLine();
// int number = int.Parse(userInput);
// Console.WriteLine(number);


// // string interpolation
// int a = 4, b = 2, c = 10;

// Console.WriteLine("First is: " + a + ", second is: " + b + ",third is: " + c);

// Console.WriteLine(
//     $"First is: {a}, second is: {b}, third is:{c}"
// );

// //while

// var number = 0;

// while (number < 10) {
//     number++;
//     Console.WriteLine(number);
// }

// // do while
// int number = 1;

// do
// {
//     Console.WriteLine(number);
//     number++;
// }
// while (number <= 5);

// //for 

// for (int i = 0; i <5 ; i++)
// {
//     Console.WriteLine("Hello");
// }


// // arrays

// // int[] numbers = new int [5];

// // numbers[0] = 5;
// // numbers[1] = 6;
// // numbers[2] = 7;
// // numbers[3] = 37;
// // numbers[4] = 47;

// // Console.WriteLine("Element at index 0 is " + numbers[0]);
// // Console.WriteLine("Element at index 1 is " + numbers[1]);
// // Console.WriteLine("Element at index 2 is " + numbers[2]);


// // var firstFromEnd = numbers[^1];
// // var secondFromEnd = numbers[^2];
// // Console.WriteLine("First from end : " + firstFromEnd);
// // Console.WriteLine("Second from end: " + secondFromEnd);


// // Console.WriteLine("Element at index 0 is " + numbers[0]);
// // Console.WriteLine("Element at index 1 is " + numbers[1]);
// // Console.WriteLine("Element at index 2 is " + numbers[2]);


// int[] numbers = new int[] {2, 6, 1, 6, 19};

// var sum = 0;


// for(int i = 0; i < numbers.Length; i++)
// {
//     sum += numbers[i];
// }
// Console.WriteLine("sum of elments is " + sum);


// // multidimensional array 

// char[,] letters = new char[2,3];

// letters[0, 0] = 'A';
// letters[0, 1] = 'B';
// letters[0, 2] = 'C';
// letters[0, 0] = 'D';
// letters[0, 1] = 'E';
// letters[0, 2] = 'F';

// var letters2 = new char[,]
// {
//     {'A', 'B','C'},
//     {'D','E','F'},
// };

// // foreach

// var words = new[] {"one","two","three","four"};

// foreach(var word in words)
// {
//     Console.WriteLine(word);
// }


// lists 
// List<string> words = new List<string>();
// Console.WriteLine("Count of elements is "+ words.Count);

// words.Add("hello");
// Console.WriteLine("Count of element is " + words.Count);



// var words = new List<string>
// {
//     "one",
//     "two",
    
// };
// Console.WriteLine("Count of element is " + words.Count);

// foreach(var word in words)
// {
//     Console.WriteLine(word);
// }

// words[0] = "ouno";

// // for(int i = 0; i < words.Count; i++)
// // {
// //     Console.WriteLine(words[i]);
// // }

// // var moreWords = new[] { "three", "four", "five" };
// // words.AddRange(moreWords);

// words.AddRange(new[] { "three", "four", "five" });

// for(int i = 0; i < words.Count; i++)
// {
//     Console.WriteLine(words[i]);
// }


