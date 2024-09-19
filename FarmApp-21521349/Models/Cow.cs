using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmApp_21521349.Models
{
    public class Cow : Animal
    {
        public Cow()
        {
            this.Type = "Cow";
        }
        private Random rand = new Random();
        public override string Sound() => "Moo!";
        public override int MilkProduction() => rand.Next(0, 21); 
        public override int Birth() => rand.Next(1, 4);
    }
}
