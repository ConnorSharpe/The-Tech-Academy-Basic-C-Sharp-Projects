using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Functions
{
    class Program
    {
        static void Main(string[] args)
        {

            //string name = "Connor";
            //string quote = "The man said,\"the backslash is the escape character\"\n backslash 'n' is used to break the line \n \t backslash 't' is to tab.";
            //string filePath = @"C:\Users\Connor";

            //bool tF = name.Contains("s");
            //tF = name.EndsWith("r");
            //int length = name.Length;

            ////to make string uppercase vs. ToLower
            //name = name.ToUpper();

            //Console.WriteLine(tF);
            //Console.ReadLine();


            ////STRINGBUILDER - dynamic string class to change strings and free up memory
            //StringBuilder sb = new StringBuilder();

            //sb.Append("My name is Connor");
            //Console.WriteLine(sb);
            //Console.ReadLine();

            string str1 = "Look, Mom, ";
            string str2 = "I am concatenating three strings";
            string str3 = " into one sentence!";
            Console.WriteLine(str1 + str2 + str3);

            string upper = "this bad boy has been upper-cased.";
            Console.WriteLine(upper.ToUpper());

            StringBuilder paragraph = new StringBuilder();
            paragraph.Append("\n\tI shall build the perfect paragraph.");
            paragraph.Append("\nIt should be about something important.");
            paragraph.Append("\nSomething so important that the instructor \n grading this will never forget it.");
            paragraph.Append("\nHopefully you saw that this perfect paragraph begins at a tab.");
            paragraph.Append("\nand demonstrates my genius-level intellect.");
            paragraph.Append("\nMy mother's friends all say I am very smart.");
            paragraph.Append("\nHandsome, too.");
            Console.WriteLine(paragraph);
            Console.ReadLine();
        }
    }
}
