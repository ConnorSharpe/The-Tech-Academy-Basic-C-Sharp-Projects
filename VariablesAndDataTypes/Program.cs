using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favNumber = Console.ReadLine();
            //int intNum = Convert.ToInt32(favNumber);
            //int total = intNum + 5;
            //Console.WriteLine("Your favorite number plus 5: " + total);
            //Console.ReadLine();

            //bool isStudying = false;
            //byte hoursWorked = 42;
            //sbyte currentTemp = -23;
            //char letter = 'X'; //Use single quotes
            //decimal money = 100.5m; //always use 'm' at the end primary use is finance
            //double heightinCM = 211.2342341;
            //float secondsLeft = 2.62f; //always use 'f' at the end 
            //short tempOnMars = -341;
            //string myName = "Connor"; // always use double quotes

            //int currentAge = 30;
            //string yearsOld = currentAge.ToString();

            //bool isRaining = true;
            //string RainingStatus = Convert.ToString(isRaining);
            //Console.WriteLine(RainingStatus);
            //Console.ReadLine();

            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number?");
            string courseNumber = Console.ReadLine();
            int courseNum = Convert.ToInt32(courseNumber);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string TF = Console.ReadLine();
            bool courseHelp = Convert.ToBoolean(TF);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string exp = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string work = Console.ReadLine();
            int hoursWorked = Convert.ToInt32(work);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
