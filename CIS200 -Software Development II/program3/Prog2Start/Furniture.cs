﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prog2Start
{
    [Serializable] //mark the class as serializable as well as making sure to include its derived classes
    [XmlInclude(typeof(DeskChair))]
    [XmlInclude(typeof(Couch))]
    public class Furniture
    {
        private decimal _price;
        private double _weight;
        private string _category;

        public Furniture() { } //parameterless constructor with default values for loading XML file.

        public Furniture(decimal price, string category, double weight) 
        {
            Price = price;
            Category = category;
            Weight = weight;
        }

        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0.0m)
                {
                    _price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid Price!");
                }
            }
        }

        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value > 0 && value <= 1000)
                {
                    _weight = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid Weight!");
                }
            }
        }

        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("Invalid Category!");
                }
                else
                {
                    _category = value;
                }
            }
        }
    }
}
