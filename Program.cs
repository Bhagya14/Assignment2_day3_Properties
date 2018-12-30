using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_task_day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter id:");
            int emp_id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter customer name:");
            string emp_name = Console.ReadLine();

            Console.WriteLine("enter item name:");
            string emp_city = Console.ReadLine();

            employee obj = new employee(emp_id, emp_name, emp_city);
            Console.WriteLine(obj.pemp_id);
            Console.WriteLine(obj.pemp_name);
            Console.WriteLine(obj.pemp_city);
            Console.ReadLine();
        }
    }
}
