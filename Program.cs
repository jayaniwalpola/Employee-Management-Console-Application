using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double BS, YofS, NofL;
            Console.WriteLine("Enter employee Basic Salary:");
            BS = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter years of service:");
            YofS = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of leaves:");
            NofL = double.Parse(Console.ReadLine());
            Employee emp1 = new Employee();
            emp1.salary(BS, NofL, YofS);
            Console.ReadLine();
            
        }
    }
}
