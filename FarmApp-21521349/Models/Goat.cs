using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmApp_21521349.Models
{
    public class Goat : Animal
    {
        public Goat()
        {
            this.Type = "Goat";
        }
        private Random rand = new Random();
        public override string Sound() => "Bleat!";
        public override int MilkProduction() => rand.Next(0, 11);
        public override int Birth() => rand.Next(1, 3); 
    }
}
