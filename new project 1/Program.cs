using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 0;
            for (; i < 5;)
            {
                i++;
                sum += i;
            }


            Console.WriteLine("the sum of number is {0}", sum);
            Console.ReadLine();
        }
    }
}
