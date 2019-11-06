using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        //    //ARRAY:
        //    int[] numArray = new int[5];
        //    numArray[0] = 5;
        //    numArray[1] = 2;
        //    numArray[2] = 10;
        //    numArray[3] = 200;
        //    numArray[4] = 5000;
        //    //OR...
        //    int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };
        //    //OR... EASIEST METHOD!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //    int[] numArray2 = { 5, 2, 10, 200, 5000 };

        //    //Changing array value
        //    numArray[4] = 650;

        //    Console.WriteLine(numArray[4]);
        //    Console.ReadLine();

        ////LISTS
        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);
        //intList.Remove(10);

        //Console.WriteLine(intList[0]);
        //Console.ReadLine();

        string[] stringArray = { "Connor", "Robert", "Sharpe", "Son of John" };
        Console.WriteLine("Please select an index number between 0 and 3 to find a piece of my name.");
        int index = Convert.ToInt32(Console.ReadLine());
        if (index > 3)
            Console.WriteLine("Were you paying attention?! between 0 and 3!");
        Console.WriteLine("You picked: " + stringArray[index]);

        int[] favNum = { 69, 420, 58008, 5318008 };
        Console.WriteLine("Pick an index between 0 and 3 to print one of my favorite numbers.");
        int intIndex = Convert.ToInt32(Console.ReadLine());
        if (intIndex > 3)
            Console.WriteLine("Gosh darn it. Between 0 and 3.");
        Console.WriteLine("You picked: " + favNum[intIndex]);
        

        List<string> strList = new List<string>();
        strList.Add("0 seems like a good place to start");
        strList.Add("1 is the lonliest number");
        strList.Add("2 is the number it takes to tango");
        strList.Add("3 is a crowd");
        Console.WriteLine("Select a list index between 0 amd 3 for some info on that number");
        int strIndex = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(strList[strIndex]);
        Console.ReadLine();

    }
}

