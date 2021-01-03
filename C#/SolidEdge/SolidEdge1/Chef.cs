﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SolidEdge1
{
    class Chef     
    {
        public void MakeChicken() 
        {
            Console.WriteLine("The Chef makes chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad");
        }
        public virtual void MakeSpecialDish()       //Virtual means that subclasses can change the functionality of this method
        {
            Console.WriteLine("The Chef makes bbq ribs");
        }


    }
}
