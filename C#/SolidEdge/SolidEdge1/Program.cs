using System;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;

namespace SolidEdge1
{
    class Program
    {
        /* Constructors
        */

        static void Main(string[] args) //Main method(function) of the program that gets executed
        {
            
            Chef chef = new Chef();                         //Superclass 
            chef.MakeSpecialDish();

            ItalianChef italianChef = new ItalianChef();    //Subclass
            italianChef.MakeSpecialDish();




            Console.ReadLine();
        }
    }



}

