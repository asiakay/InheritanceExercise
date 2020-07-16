using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            isAlive = true;
            isNamed = "Florence";
            canFly = true;
            featherColor = "pink";
            cute1to10 = 10;
            
        }
        public bool canFly { get; set; }
        public bool canSwim { get; set; }
        public bool winterSouth { get; set; }
        public string featherColor { get; set; }

    }
}
