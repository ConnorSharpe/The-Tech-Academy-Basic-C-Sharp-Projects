using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_I_O
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite number for the log?");
            int answer = Convert.ToInt32(Console.ReadLine());
            File.WriteAllText(@"C:\Users\conno\Logs\logDrill.txt", answer.ToString());
            Console.WriteLine(File.ReadAllText(@"C:\Users\conno\Logs\logDrill.txt"));
            Console.Read();
        }
    }
}
