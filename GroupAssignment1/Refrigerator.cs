using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment1
{
    internal class Refrigerator : Appliance
    {
        private int _doors, _height, _width;

        public int Doors { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public Refrigerator(string itemNumber, string brand, int quantity, double wattage, string color, double price, int doors, int height, int width) :
            base(itemNumber, brand, quantity, wattage, color, price)
        {
            this.Doors = doors;
            this.Height = height;
            this.Width = width;
        }

        public override void Checkout()
        {
            if (this.Quantity > 0)
            {
                this.Quantity--;
                Console.WriteLine($"Appliance {ItemNumber} has beeen checked out.");
            }
            else
            {
                Console.WriteLine("The apppliance is not available to be checked out");
            }
        }

        public override void DetermineAppliance()
        {
            throw new NotImplementedException();
        }

        public override string FormatForFile()
        {
            return $"{ItemNumber};{Brand};{Quantity};{Wattage};{Color};{Price},{Doors},{Height},{Width}";
        }

        public override string ToString() 
        {
            string doors=null;
            switch(this.Doors)
            {
                case 2:
                    doors = "double door";
                    break;
                case 3:
                    doors = "three doors";
                    break;
                case 4:
                    doors = "four doors";
                    break;
            }
            return $"ItemNumber: {ItemNumber}\nBrand: {Brand}\nQuantitiy: {Wattage}\nColor: {Color}\nPrice: {Price}\nDoors: {doors}\nHeight: {Height}\nWidth: {Width}";
        }
    }
}
