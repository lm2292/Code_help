using System;
using System.Collections.Generic;
using System.Text;

namespace SolidEdge1
{
    class ItalianChef : Chef
    {
        public void MakePasta() 
        {
            Console.WriteLine("The Chef makes pasta");
        }
        public override void MakeSpecialDish()       //Overrides the virtual method from Chef class 
        {
            Console.WriteLine("The Chef makes pizza");
        }
    }
}
