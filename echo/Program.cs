using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Eric Broadbent
Hello World example
ch 2.3
9/20
*/



namespace Hello
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.Write("type in your Name");// user input prompt
            string name = Console.ReadLine();//Reading user input and assigning it to name

            string myFirstVarable; //declaration statment 
            myFirstVarable = "Welcome";// asignment statment


            string Var2 = "somthing else"; //declaration and assignment in one
            

            Console.WriteLine(myFirstVarable + " " + name);// this is a console print statment
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();// reading key presses
        }
    }
}
