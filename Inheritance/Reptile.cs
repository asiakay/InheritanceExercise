using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
        }
        //automatic properties with read write capability

        public bool HasScales { get; set; }
        public bool LaysEggs { get; set; }
        public bool ColdBlooded { get; set; }
        public string Habitat { get; set; }
    }
}
