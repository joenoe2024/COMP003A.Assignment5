/*
 * Author: joseph sandoval
 * intro to prog concepts method c#
 * week 5 assignment Methods & xml Comments
 */

namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSeparator();
            Console.WriteLine("Triangle section");
            PrintSeparator();

            Console.WriteLine("Enter a single character:  ");
            char userChar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.WriteLine("Please enter a whole positive number");
            string userInput = Console.ReadLine();

            int userNumber;
            if (int.TryParse(userInput, out userNumber) && userNumber > 0)
            {
                IsoscelesTriangleBuilder(userChar, userNumber);
            }

            PrintSeparator();
            Console.WriteLine("Favorite Characters");
            PrintSeparator();

            CharacterInfo("snow white", 1937);
            CharacterInfo("Johny,", 1946);
            CharacterInfo("Dumbo", 1941);
            CharacterInfo("Donald duck", 1934);
            CharacterInfo("joseph sandoval", 1999);

            



            
        }

        static void CharacterInfo(string name, int birthYear)
        {
            int age = AgeCalculator(birthYear);
            Console.WriteLine($"{name} turns {age} this year!");
            /// strings together and calls agecalculator method to create "name and age"
        }

        static void IsoscelesTriangleBuilder(char inputCharacter, int size)
        {
            for (int i = 1; i <= size; i++)
            {
                string line = new string(inputCharacter, i);
                Console.WriteLine(line);
            }
            for (int i = size -1; i >= 1; i--)
            {
                string line = new string(inputCharacter, i);
                Console.WriteLine(line);
            }/// builds a triangle mthod of a value of your choice
        }
        
        static int AgeCalculator(int birthYear)
        {
            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthYear;
            return currentYear - birthYear;
            /// generates age 
        }

        static void PrintSeparator()
        {
            Console.WriteLine(new string ( '*', 50 ));
            /// prints a separator line with asterisk
            
        
        }
    }
}
