using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenProject.Models
{
    public class Furniture
    {
        public string Name { get; set; }
        public double X { get; set;   }
        public double Y { get; set; }
        public double Z { get; set; }

        public static List<Neshto> neshto { get; set; }

    }
}
