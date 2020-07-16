using System;
using System.Collections.Generic;
using System.Linq;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Done Create a class Animal
            // give this class 4 members that all Animals have in common


            // Done Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Done Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class
            var allAnimals = new Animal();
            


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            // . notation
            var aBird = new Bird();
            aBird.isAlive = true;
            aBird.isNamed = "Florence";
            aBird.AnmlType = "Flamingo";
            aBird.cute1to10 = 10;

            //accesinmg a function in the animal class
            aBird.PrintMe();


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            // object initializer syntax
            var aReptile = new Reptile();
            aReptile.isAlive = true;
            aReptile.isNamed = "Jerry";
            aReptile.AnmlType = "Geckko";
            aReptile.cute1to10 = 10;
            //printing to console accessing PrintMe() from the
            //Animal class
            aReptile.PrintMe();
                
                //isAlive = true,
                //ColdBlooded = true,
                //Habitat = "desert",
                //cute1to10 = 1

            
            

           
        }
    }
}
