using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Employee
    {
        public float salary = 40000;
    }
    public class Programmer : Employee
    {
        public float bonus = 10000;
    }
    public class Salar : Programmer
    {
        public float advance = 10000;

    }
    class TestInheritance
    {
        public static void Main(string[] args)
        {
            Salar p1 = new Salar();

            Console.WriteLine("Salary: " + p1.salary);
            Console.WriteLine("Bonus: " + p1.bonus);
            Console.WriteLine("Salary: " + p1.advance);


        }
    }
}


