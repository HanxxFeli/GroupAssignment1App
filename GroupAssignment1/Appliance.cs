﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment1
{
    internal abstract class Appliance
    {

        // private fields
        private string _brand, _color, itemNumber;
        private double _price, _wattage;
        private int _quantity;

        // public properties
        public string Brand { get; set; }
        public string Color { get; set; }
        public string ItemNumber { get; set; }
        public double Price { get; set; }

        public double Wattage { get; set; } 
        public int Quantity { get; set; }

        // Methods 
        public Appliance(string itemNumber, string brand, int quantity, double wattage, string color, double price)
        {
            this.Brand = brand;
            this.ItemNumber = itemNumber;
            this.Price = price;
            this.Wattage = wattage;
            this.Quantity = quantity;
            this.Color=color;
        }

        public abstract void Checkout();
        public abstract void DetermineAppliance();
        public abstract string FormatForFile();

    } // abstract class
} // namespace
