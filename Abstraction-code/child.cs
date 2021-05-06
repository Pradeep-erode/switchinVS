using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //inheritance of father class
    public class Child:father
    {
        
        //implementation of abstract class using override keyword whereas in method overriding this is not compulsary 
        //to implement 


        public override void display()
        {
            Console.WriteLine("I am implanted class");
        }
        public void disk()
        {
            Console.Write("I am pradeep");
        }
    }
}
