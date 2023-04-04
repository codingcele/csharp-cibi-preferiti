// See https://aka.ms/new-console-template for more information

using System;

namespace cibiPreferiti
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cibiPreferiti = { "carbonara", "cioccolata", "anacardi", "pizza", "kebab", "poke", "pere", "paella" };

            int length = cibiPreferiti.Length;
            Console.WriteLine("Length is: " + length);

            var primoCibo = cibiPreferiti[0];
            Console.WriteLine("1st favourite food is: " + primoCibo);

            var ultimoCibo = cibiPreferiti[cibiPreferiti.Length - 1];
            Console.WriteLine("Last food in most favourite foods rank is: " + ultimoCibo);

            if (length % 2 == 0)
            {
                int stHalf = length / 2 - 1;
                int ndHalf = length / 2;

                var foodStHalf = cibiPreferiti[stHalf];
                var foodNdHalf = cibiPreferiti[ndHalf];

                Console.WriteLine("Foods in the middle: " + foodStHalf + " and " + foodNdHalf);
            }
            else
            {
                Console.WriteLine(length);
                int half = length / 2;
                var middleFood = cibiPreferiti[half];
                Console.WriteLine("The food in the middle is: "+ middleFood);
            }
        }
    }
}