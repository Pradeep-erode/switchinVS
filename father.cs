using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //abstract can have both  marked abstract method and non-abstract method in abstract class
    //But interface class having abstract method only 

    public abstract class father
    {
        //abstract method(or marked abstract method) and implemention not done
        public abstract void display();


        //non-abstract method in abstract class 
        public void show(int a,int b)//getting inputs through arguments
        {
           
            Console.Write("\nsum =" + (a + b));
        }
    }


}