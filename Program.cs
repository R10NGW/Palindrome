using System;
using System.Collections.Generic;
using System.IO;


namespace FibSequence
{
    class Program  //application 
    {

        public static int getInt()   //gets int from user
        {
            Console.WriteLine("Enter the number of fib sequences you would like to see:");
            return Convert.ToInt32(Console.ReadLine());
        }
        public static void printer(List<int> finalList)   //prints to file and writes output in terminal 
        {
            string finalString = "";
            string outFile = @"./output.txt";
            foreach(var v in finalList)
                finalString += v + " ";
            File.WriteAllText(outFile, finalString);
            Console.Write(finalString);
        }

        public static List<int> fibSequenceWorker(int fibCount)   //calculates fib sequence
        {
            List<int> fibSequnce = new List<int>(new int[] {0, 1});   //creates new list if we want to search for specific instance of fib sequence
            int prev1 = 0;  //variables for storing and calling fib sequence numbers
            int prev2 = 1;
            int newFibNumber;
            for(int i =0; i < fibCount -2; i++)   //loop to create the new numbers
            {
                newFibNumber = prev1 +prev2;
                fibSequnce.Add(newFibNumber); 
                prev1 = prev2;
                prev2 = newFibNumber;
            }
            return fibSequnce;
        }
        
        public static void Main(string[] args)  //main string in class
        {
            int fibCount = getInt();    //gets the number of fib we want to find
            printer(fibSequenceWorker(fibCount));  //prints to terminal and to output txt the number of fib sequences user reuqested
        }
    }
}