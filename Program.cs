using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMethods
{

    public class OurClass
    {
        // instance Method return type void and no parameters
        public void Display()
        {
            Console.WriteLine("Welcome to Methods!!!");

        }
        // Static method

        public static void Welcome()
        {
            Console.WriteLine("Static Method Welcome you!!!");
        }

        // Methods return void & take two parameters
        public void FullName(string fname, string lname)
        {
            Console.WriteLine("Full Name is: " + fname + lname);
        
        }
        public double Add(double n1,double n2)
        {
            double result;
            result = n1 + n2;
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //OurClass obj=new OurClass();
            //obj.Display();
            //obj.FullName("Sam","Dicosta");
            //OurClass.Welcome();

            OurClass ourClass=new OurClass();
            double num1, num2;
            Console.WriteLine("Enter First Number");
            num1=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            num2=double.Parse(Console.ReadLine());
            Console.WriteLine("Result after Addition is: \t"+ ourClass.Add(num1,num2));

            Console.ReadKey();
        }
    }
}
