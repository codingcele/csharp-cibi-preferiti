// See https://aka.ms/new-console-template for more information

using System;

namespace cibiPreferiti
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cibiPreferiti = { "carbonara", "cioccolata", "anacardi", "pizza", "kebab", "poke", "pere" };

            int length = cibiPreferiti.Length;
            Console.WriteLine("Length is: " + length);

            var primoCibo = cibiPreferiti[0];
            Console.WriteLine("1st favourite food is: " + primoCibo);

            var ultimoCibo = cibiPreferiti[cibiPreferiti.Length - 1];
            Console.WriteLine("Last food in most favourite foods rank is: " + ultimoCibo);
        }
    }
}