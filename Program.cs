using System;

namespace BasicCodingKata
{
    class Program
    {
        static void Main(string[] args)
        {
           // Write a program that asks the user for their name and greets them with their name.
             Greeting.HelloName();
             



             // Write a program that asks the user for their name and only greets you if you are Alice or Bob.
             
              Console.WriteLine("Hello! What is your name?");
              var userInput1 = Console.ReadLine();
              if (userInput1 == "Alice" || userInput1 == "Bob") {
                  Console.WriteLine($"Hello {userInput1}! Have a good day!");
              } else 
              {
                  Console.WriteLine("No Greeting");
              }
          

//             //Using PERSON CLASS
//             //Create instance of a person from a non static Person class
//             /*
//             Console.WriteLine("Hello! What is your name?");
//             string userInput = Console.ReadLine();
//             Person person1 = new Person(userInput);
//             if (person1.Name.Equals("Alice", StringComparison.OrdinalIgnoreCase) || 
//                 person1.Name.Equals ("Bob", StringComparison.OrdinalIgnoreCase))
//             {
//                 Console.WriteLine($"Hello {person1.Name}! Have a good day!");
//             } 
//             else 
//             {
//                 Console.WriteLine("No Greeting");
//             }
//             */
//
//             //Create List with three names 
//             //declare List
//             //List<string> people = new List<string>();
//             //String[] people = new String[3];
//             /*
//              for (int i = 0; i < 3 ; i++)
//              {
//                  Console.WriteLine("Hello! What is your name?");
//                  string userInput = Console.ReadLine();
//                  Person person1 = new Person(userInput);
//                  //people[i] = person1.Name;
//                  people.Add(person1.Name);
//              }
//              Console.WriteLine(people.Count);
//              Console.WriteLine();
//              
//              foreach (var person in people)
//              {
//                  Console.WriteLine($"Hello {person}! Have a good day!");
//              }
//  
//              people.Distinct();
//              */
//
//
//
//             List<Person> people = new List<Person>();
//             string name = "";
//             string hair = "";
//
//             
//                     Console.WriteLine("Hello! What is your name?");
//                     name = Console.ReadLine();
//                     if (!ErrorChecker.CheckInput(name)) // should be easy to read
//                     {
//                         Console.WriteLine("Sorry, please enter letters only.");
//                     }
//                     else
//                     {
//                         Console.WriteLine("What is your hair colour?");
//                             hair = Console.ReadLine();
//
//                             if (!ErrorChecker.CheckInput(hair))
//                             {
//                                 Console.WriteLine("Sorry, please enter letters only.");
//                             }
//                             else
//                             {
//                                 Person person1 = new Person(name, hair);
//                                 people.Add(person1);
//                             }
//                     }
//             
//
//             Console.WriteLine($"Number of people: {people.Count}");
//             Console.WriteLine();
//             
//         foreach (var person in people)
//         {
//             Console.WriteLine($"Hello {person.Name}! You have {person.HairColour} hair colour!");
//                 
//         }
//
//             
//
//
//         //Alternative - if ignore case
//         /*
//             Console.WriteLine("Hello! What is your name?");
//             var userInput2 = "";
//             userInput2 = Console.ReadLine();
//             if (userInput2.Equals("Alice", StringComparison.OrdinalIgnoreCase)){
//                 Console.WriteLine($"Hello {userInput2}! Have a good day!");
//             }
//
//             else if (userInput2.Equals("Bob", StringComparison.OrdinalIgnoreCase)){
//                 Console.WriteLine($"Hello {userInput2}! Have a good day!");
//             }
//             else
//             {
//                 Console.WriteLine("No Greeting");
//             }
//         */
//         //Write a program that asks the user for a number n and prints the sum of the numbers 1 to n
//         /*
//         Console.WriteLine("Please enter a positive number");
//         
//         var n = Console.ReadLine();
//         int i = 0;
//         int userNum = 0;
//         bool isNumber = int.TryParse(n, out userNum);
//         
//         if(isNumber){
//             for (i = 1; i < userNum + 1; i++)
//             {
//                 Console.WriteLine(i);
//             }
//             
//         }
//         else
//         {
//             Console.WriteLine("Please enter a number");
//         }
//         */
         //Write a program that asks the user for a number n and prints the sum of the numbers 1 to n if the number is a multiple of three or five, e.g. 3, 5, 6, 9, 10, 12, 15 for n=17
       
         
         /*
         Console.WriteLine("Please enter a positive number");
         var n = Console.ReadLine();
         int i = 0;
         int userNum = 0;
         bool isNumber = int.TryParse(n, out userNum);
         
         if(isNumber){
             for (i = 1; i < userNum + 1; i++)
             {
                 if (i % 3 == 0 || i % 5 == 0)
                 {
                     Console.WriteLine(i);
                 }
             }
             
         }
         else
         {
             Console.WriteLine("Please enter a number");
         }

         //Write a program that asks the user for a number n and gives them the possibility to choose between computing the sum and computing the product of 1,…,n.
         
         int userNum = 0;
         bool keepGoing = true;
        
         do
         {
             Console.WriteLine("Please enter a number.");
             var n = Console.ReadLine();
             bool isNumber = int.TryParse(n, out userNum);
             
             if (isNumber)
             {
                 Console.WriteLine(
                     "Enter SUM if you would like to find the sum of all numbers from 1 to your chosen number or PRODUCT if you would like to see the product of all numbers from 1 to your chosen number");
                 var userChoice = Console.ReadLine();
                 int i = 0;
                 int sum = 0;
                 int product = 1;
                 
                 if (userChoice.Equals("SUM", StringComparison.OrdinalIgnoreCase))
                 {
                     for (i = 0; i < userNum; i++)
                     {
                         sum += i + 1;
                     }

                     Console.WriteLine($"Sum: {sum}");
                     keepGoing = false;
                 }
                 else if (userChoice.Equals("PRODUCT", StringComparison.OrdinalIgnoreCase))
                 {
                     for (i = 1; i < userNum + 1; i++)
                     {
                         product *= (i * 1);
                     }

                     Console.WriteLine($"Product: {product}");
                     keepGoing = false;
                 }
                 else
                 {
                     Console.WriteLine("Please enter 'SUM' or PRODUCT'");
                 }

             }
             
         } while (keepGoing);
*/
         
          // Write a program that prints a multiplication table for numbers up to 12.
         
         int k = 0;
         int i = 0;
         int j = 0;
         for (i = 1; i <= 12; i++)
         {
             for (j = 1; j <= 12; j++)
             {
                 Console.Write(String.Format($"{i*j,-4}"));
             }
             Console.WriteLine();
         }
         

        //Write a guessing game where the user has to guess a secret number.
        //After every guess the program tells the user whether their number was too large or too small.
        //At the end the number of tries needed should be printed.
        //It counts only as one try if they input the same number multiple times consecutively.


        
        Random rnd = new Random();
        int randomNum = rnd.Next(1, 30);
        int guessNumber = 0;
        int numOfGuesses = 0;
        int checkGuess = 0;
        
        bool keepGoing = true;
        string guessAnother = "";
        Console.WriteLine("Guess a number between 1 to 30.");
        do
        {
            var userInput = Console.ReadLine();
            bool result = Int32.TryParse(userInput, out guessNumber);
            
            if (!result)
            {
                Console.WriteLine("That does not look like a number between 1 to 30! Guess again!");
                numOfGuesses++;
            }
            else
            {
                if (guessNumber == randomNum)
                {
                    numOfGuesses++;
                    Console.WriteLine("Congratulations! You guessed the answer in " + numOfGuesses + " tries!");
                    keepGoing = false;
                }
                else
                {
                    if (checkGuess != guessNumber)
                    {
                        numOfGuesses++;
                    }

                    checkGuess = guessNumber;
                    Console.WriteLine("Guess a {0} number!", guessNumber > randomNum ? "lower" : "higher");
                    keepGoing = true;

                }
            }
        }  while (keepGoing);
        
// Write a program that prints the next 20 leap years.

            int currentYear = 2021;
            int nextLeapYear = currentYear + 3;
            Console.WriteLine("Next 20 leap years : ");
            Console.WriteLine(nextLeapYear);
            for (int i = 0; i < 19; i++)
            {
                nextLeapYear += 4;
                Console.WriteLine( nextLeapYear );
                
            }
            
        }
    }
}