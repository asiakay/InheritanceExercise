using System;
using System.Collections.Generic;
using System.Linq;

// Create a class Animal
// give this class 4 members that all Animals have in common

namespace Inheritance
{
    public class Animal
    {
        public Animal()
        {
        }
        public bool isAlive { get; set; }
        public string isNamed { get; set; }
        public string AnmlType { get; set; }
        public int cute1to10 { get; set; }
        public bool CartoonCharacter { get; set; }

        public void PrintMe()
        {
            
            Console.WriteLine($"This animal is alive= {isAlive}. It is named= {isNamed} " +
                $"the {AnmlType}." +
                $"On a cute scale from 1-10, {isNamed} ranks {cute1to10}.");
             
        }

 
    }
}
