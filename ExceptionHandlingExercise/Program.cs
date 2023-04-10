using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // X First create an char[], it must contain 6 numbers and 3 letters - name it arr
            // X Create a list called numbers that will hold integers
            // X Create an string variable with an empty string initializer - name it str

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------
            char[] arr = new char[] { 'a', 'b', 'c', '1', '2', '3', '4', '5', '6' };
            List<int> numbers = new List<int>();
            string str = "";

            //TODO START HERE:
            string c;
            // Make a foreach loop to iterate through your character array
            // Now create a try catch

            // Inside your try block
            // X set your string variable to each array element in your char[] to .ToString()
            // X Now, using int.Parse, parse your string variable and store in an int variable
            // X Then add each int to your list

            // catch your Exception:
            // in the scope of your catch you can use the following, 

            // ? Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection
            try
            {
                foreach (char character in arr)
                {
                    c = character.ToString();
                    str += c;
                    int charNum = int.Parse(c);
                    numbers.Add(charNum);
                }
            } catch (FormatException e) {
                Console.WriteLine(e.Message);
            } catch (Exception e) {
                Console.WriteLine($"Unable to Parse '{e.Message}'");
            }


        }
    }
}
