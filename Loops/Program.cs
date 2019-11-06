using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Guess a number!");
            //int number = Convert.ToInt32(Console.ReadLine());
            //bool isGuessed = number == 12;
            //do
            //{
            //    switch (number)
            //    {
            //        case 62:
            //            Console.WriteLine("You guessed 62. Try again.");
            //            Console.WriteLine("Guess a number!");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 29:
            //            Console.WriteLine("You guessed 29. Try again.");
            //            Console.WriteLine("Guess a number!");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 55:
            //            Console.WriteLine("you guessed 55. Try again.");
            //            Console.WriteLine("Guess a number!");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 12:
            //            Console.WriteLine("You guessed 12. That is correct!");
            //            isGuessed = true;
            //            break;
            //        default:
            //            Console.WriteLine("You're Wrong.");
            //            Console.WriteLine("Guess a number!");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}
            //while (!isGuessed); //isGuessed == false
            //Console.Read();


            //WHILE LOOP
            Console.WriteLine("Give me a fruit!");
            string fruit = Console.ReadLine();
            bool Banana = false;
            while (!Banana)
            {
                switch (fruit)
                {
                    case "banana":
                        Console.WriteLine("B is Bananas B-A-N-A-N-A-S!");
                        Banana = true;
                        break;
                    default:
                        Console.WriteLine("Not what we are looking for. Please try again.");
                        Console.WriteLine("HINT: think Gwen Stefani.");
                        Console.WriteLine("Try again!");
                        fruit = Console.ReadLine();
                        break;
                }
            }


            //DO WHILE LOOP
            Console.WriteLine("Okay, now give me the best Pokemon.");
            string pokemon = Console.ReadLine();
            bool karp = pokemon == "magikarp";
            do
            {
                switch (pokemon)
                {
                    case "pikachu":
                        Console.WriteLine("Nice try, pikachu is annoying.");
                        Console.WriteLine("The pokemon im looking for will make a 'splash'. (get it?)");
                        Console.WriteLine("Give me a better pokemon.");
                        pokemon = Console.ReadLine();
                        break;
                    case "squirtle":
                        Console.WriteLine("While squirtle is objectively the sexiest pokemon,");
                        Console.WriteLine("It's not exactly what I'm looking for. Give me another!");
                        pokemon = Console.ReadLine();
                        break;
                    case "magikarp":
                        Console.WriteLine("You did it. Magikarp is the greatest pokemon because");
                        Console.WriteLine("it is the only pokemon that actually exists. All the others are losers.");
                        break;
                    default:
                        Console.WriteLine("You aren't even close. Try 'pikachu' or 'squirtle' or something.");
                        pokemon = Console.ReadLine();
                        break;
                }
            }
            while (!karp);


            Console.Read();
        }
    }
}
