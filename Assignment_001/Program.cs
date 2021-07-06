using System;

namespace Assignment_001
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Asignment:
            // Write a program in C# to find the element with the maximum and minimum length in an array of strings. 
            string[] collection = new String[] { "Cupcake", "Cake", "Candy", "Coffeee", "Tobleroneeee" };

            int minLength = collection[0].Length;
            int maxLength = collection[0].Length;
            string minLengthString = string.Empty;
            string maxLengthString = string.Empty;

            for (int i = 1; i < collection.Length; i++)
            {
                if(collection[i].Length < minLength)
                {
                    minLength = collection[i].Length;
                    minLengthString = collection[i];
                }

                if(collection[i].Length > maxLength)
                {
                    maxLength = collection[i].Length;
                    maxLengthString = collection[i];
                }
            }

            Console.WriteLine("The smallest string is {0} and has a length of: {1}", minLengthString, minLength);
            Console.WriteLine("The largest string is {0} and has a length of: {1}", maxLengthString, maxLength);
        }
    }
}
