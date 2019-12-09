using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { ID = 1, FirstName = "Joe", LastName = "Fixit" });
            employees.Add(new Employee() { ID = 2, FirstName = "Lisa", LastName = "Engler" });
            employees.Add(new Employee() { ID = 3, FirstName = "Jeremy", LastName = "White" });
            employees.Add(new Employee() { ID = 4, FirstName = "Ronald", LastName = "MacDonald" });
            employees.Add(new Employee() { ID = 5, FirstName = "Jeffery", LastName = "Dahmer" });
            employees.Add(new Employee() { ID = 6, FirstName = "Matthew", LastName = "Fontino" });
            employees.Add(new Employee() { ID = 7, FirstName = "Joe", LastName = "Joestar" });
            employees.Add(new Employee() { ID = 8, FirstName = "Peter", LastName = "Parket" });
            employees.Add(new Employee() { ID = 9, FirstName = "Gwen", LastName = "Stacy" });
            employees.Add(new Employee() { ID = 10, FirstName = "Xing", LastName = "Fu" });

            List<Employee> joes = new List<Employee>();

            foreach(Employee employee in employees)
            {
                if(employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
            }
            foreach (Employee guy in joes)
            {
                Console.WriteLine(guy.FirstName + " " + guy.LastName);
            }

            List<Employee> j = employees.Where(x => x.FirstName == "Joe").ToList();
            Console.WriteLine(j);
            foreach(Employee guy in j)
            {
                Console.WriteLine(guy.FirstName + " " + guy.LastName);
            }

            List<Employee> lg = employees.Where(x => x.ID > 5).ToList();
            foreach (Employee guy in lg)
            {
                Console.WriteLine(guy.ID + " " + guy.FirstName + " " + guy.LastName);
            }
            Console.ReadLine();
        }
    }
}
