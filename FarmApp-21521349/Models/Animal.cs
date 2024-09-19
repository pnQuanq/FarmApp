using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmApp_21521349.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Type { get; set; } 
        public int Quantity { get; set; } 
        public int TotalMilk { get; set; } 
        public int TotalBirths { get; set; } 
        public virtual string Sound() => "";
        public virtual int MilkProduction() => 0;
        public virtual int Birth() => 0;
    }
}
