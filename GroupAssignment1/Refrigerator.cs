using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment1
{
    internal class Refrigerator:Appliance
    {
        private int _doors, _height,_width;

        public int Doors {  get; set;  }
        public int Height { get; set; }
        public int Width { get; set; }

        public Refrigerator(string itemNumber, string brand, int quantity, double wattage, string color, double price, int doors, int height, int width):
            base(itemNumber, brand, quantity, wattage, color, price)
        {
            this.Doors = doors;
            this.Height = height;
            this.Width = width;
        }

        public override string FormatForFile()
        {
            return $"{ItemNumber};{Brand};{Quantity};{Wattage};{Color};{Price},{Doors},{Height},{Width}";
        }

    }
}
