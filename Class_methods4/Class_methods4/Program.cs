using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_methods4
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("Please give me your favorite whole number: ");
            int favNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please give me your second Favorite number. If you do not have one: just press enter.");
            string favNum2 = Console.ReadLine();
            if (favNum2 == "")
            {
                math.Math1(favNum);
            }
            else
            {
                int FavNum2 = Convert.ToInt32(favNum2);
                math.Math1(favNum, FavNum2);
            }
            
            Console.ReadLine();
        }
    }
}
