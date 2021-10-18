using System;
using System.IO;


namespace Palindrome
{
    class Program  //application 
    {

        public static string getString()   //gets string from user
        {
            Console.WriteLine("Enter palindrome:");
            return Console.ReadLine();
        }
        public static void printer(string finalString)   //prints to file and writes output in terminal 
        {
            string outFile = @"./output.txt";
            File.WriteAllText(outFile, finalString);
            Console.Write(finalString);
        }

        public static string palindromeCheck(string inputString)   //checks if user input is palindrome and returns result 
        {
            string reverse = "";
            for (int i = inputString.Length - 1; i >= 0; i--) //assigns new variable the characters of inpout string in reverse order
                reverse += inputString[i];
            if (reverse == inputString)   //checks if it is a palindrome
                return (reverse + " is Palindrome");
            else
                return (reverse + " isnt palindrome");
        }
        
        public static void Main(string[] args)  //main string in class
        {
            string input = getString();    //gets input
            printer(palindromeCheck(input));  //checks if string is a palindrome and prints it to a file and terminal 
        }
    }
}
