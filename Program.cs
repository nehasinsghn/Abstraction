using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Person //Abstract Class
        {
        public string name; 
        public int age;
        public  int PhoneNO;
        public abstract void PrintDetail(); //Abstract Method      
    }
    class Student : Person
    {
    
        public  int RollNO;
        public  int fees;

       

        public override void PrintDetail()
        {
            Console.WriteLine("Student name :{0}", name);
            Console.WriteLine("Student age : {0}", age);
            Console.WriteLine("Student PhoneNo :{0}", PhoneNO);
            Console.WriteLine("Student rollNO :{0}",RollNO);
            Console.WriteLine("Student fees :{0}",fees);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student Neha = new Student();
            Neha.name = "Neha Singh";
            Neha.age = 22;
            Neha.PhoneNO = 63886804;
          
            Neha.fees = 232;
            Neha.PrintDetail();
            Console.ReadLine();
        }
    }
}
