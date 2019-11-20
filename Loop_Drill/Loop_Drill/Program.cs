using System;
using System.Collections.Generic;


namespace Loop_Drill
{
	class Program
	{
		static void Main(string[] args)
		{
			//1.Create a one-dimensional Array of strings.Ask the user to input some text.
			//Create a loop that goes through each string in the Array, adding the user’s text to the string.
			//Then create a loop that prints off each string in the Array on a separate line.
			string[] inputs = new string[3];
			Console.WriteLine("Please give me a string for my array: ");
			inputs[0] = Console.ReadLine();
			Console.WriteLine("Please give me another string for the array: ");
			inputs[1] = Console.ReadLine();
			Console.WriteLine("I need one last string for the array: ");
			inputs[2] = Console.ReadLine();

			for (int i = 0; i < inputs.Length; i++)
			{
				Console.WriteLine(inputs[i]);
			}
			Console.ReadLine();

			//2.Create an infinite loop.
			//bool yes = true;
			//while (yes == true) 
			//{
			//	Console.WriteLine("INFINITY");
			//}
			//Console.ReadLine();


			//3.Fix the infinite loop so it will execute.
			bool yes = true;
			while (yes == true)
			{
				Console.WriteLine("Infinity...");
				yes = false;
			}
			Console.ReadLine();

			//4.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
			int[] numbas = { 45, 1000, 46, 50, 2, 19 };
			for (int i = 0; i < numbas.Length; i++) 
			{
				if (numbas[i] < 50)
				{
					Console.WriteLine(numbas[i]);
				}
			}
			Console.ReadLine();

			//5.Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
			for (int i = 0; i < numbas.Length; i++)
			{
				if (numbas[i] <= 50)
				{
					Console.WriteLine(numbas[i]);
				}
			}
			Console.ReadLine();

			//6.Create a List of strings where each item in the list is unique.Ask the user to select text to search for in the List.
			//	Create a loop that iterates through the list and then displays the index of the array that 
			//contains matching text on the screen.
			List<string> strList = new List<string>();
			strList.Add("waxing gibbous");
			strList.Add("waning gibbous");
			strList.Add("waxing crescent");
			strList.Add("waning crescent");
			strList.Add("full moon");
			strList.Add("first quarter");
			strList.Add("third quarter");
			strList.Add("new moon");
			Console.WriteLine("What is your favorite moon phase? ");
			string phase = Console.ReadLine();
			bool moon = false;

            for (int i = 0; i < strList.Count; i++) 
            {
                if (strList[i] == phase) 
                {
                    Console.WriteLine("Your phase is at index: " + i);
                    break;
                }
            }
            if (!strList.Contains(phase)) 
            {
                Console.WriteLine("Check your research. That is not a moon phase.");
            }
            Console.ReadLine();

            //7.Add code to that above loop that tells a user if they put in text that isn’t in the List.

            //8.Add code to that above loop that stops it from executing once a match has been found.

            //9.Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List.
            //Create a loop that iterates through the list and then displays the indices of the array that contain matching text on the screen.
            List<string> match = new List<string>();
            match.Add("Aloha");
            match.Add("There are two strings ");
            match.Add("in this list ");
            match.Add("that are the same. ");
            match.Add("Which string is duplicated?");
            match.Add("Aloha");

            match.ForEach(i => Console.Write("{0}\t", i));
            string guess = Console.ReadLine();
            for (int i = 0; i > match.Count; i++) 
            {
                if (guess == match[i])
                {
                    Console.WriteLine("your guess is at index: "+ i);
                }
            }
            if (!match.Contains(guess)) 
            {
                Console.WriteLine("Sorry, that string isn't in the list.");
            }
            Console.ReadLine();

            //10.Add code to that above loop that tells a user if they put in text that isn’t in the List.

            //11.Create a List of strings that has at least two identical strings in the List. 
            //Create a foreach loop that evaluates each item in the list, and displays a message showing the string and 
            //whether or not it has already appeared in the list.
            List<string> twin = new List<string>();
            twin.Add("A");
            twin.Add("E");
            twin.Add("U");
            twin.Add("I");
            twin.Add("O");
            twin.Add("U");
            List<string> duplicates = new List<string>();

            Console.WriteLine("Check out these sick vowels. There is a hilarious joke hidden in there. Can you find it?");
            twin.ForEach(i => Console.Write("{0}\t", i));

            foreach (string vowel in twin) 
            {
                Console.WriteLine(vowel);
                if (!duplicates.Contains(vowel))
                {
                    duplicates.Add(vowel);
                }
                else 
                {
                    Console.WriteLine("That vowel has already appeared!");
                    Console.WriteLine("double U!");
                }
            }

            Console.ReadLine();

        }
	}
}
