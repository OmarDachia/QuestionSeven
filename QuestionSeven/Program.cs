using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#7 Write a Promgram to calculate \ni.	(a+b)2\nii.	(a+b)3\n\niii.	(a2-b2)");
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("User input:->");
            Console.WriteLine("+++++++++++++");

            double a = 0, b = 0;
            Console.WriteLine("Enter the a:->");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Enter the b:->");
            double.TryParse(Console.ReadLine(), out b);
            

            Console.WriteLine("Result:->");
            Console.WriteLine("*********");
            Console.WriteLine(string.Format("\ni.	(a+b)2={0} \nii.	(a+b)3={1}\niii.	(a2-b2)={2}", (Math.Pow(a + b, 2)), (Math.Pow(a + b, 3)), (Math.Pow(a, 2) - Math.Pow(b, 2))));
            Console.ReadKey();
        }
    }
}
