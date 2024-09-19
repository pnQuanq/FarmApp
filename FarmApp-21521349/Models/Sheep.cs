using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmApp_21521349.Models
{
    public class Sheep : Animal
    {
        public Sheep()
        {
            this.Type = "Sheep";
        }
        private Random rand = new Random();
        public override string Sound() => "Baa!";
        public override int MilkProduction() => rand.Next(0, 6);
        public override int Birth() => rand.Next(1, 3);
    }
}
