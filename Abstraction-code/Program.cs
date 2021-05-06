using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Hello World!");
            Child obj = new Child();//object created for child class
            obj.display();//access display function with the help of object created
            obj.disk();
            obj.show(6, 7);//giving inputs for show function through arguments


        }
    }
}
