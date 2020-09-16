using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Classes
{
    class Vehicle
    {
        string model { get; set; }

        public Vehicle() { }

        public Vehicle(string vmodel)
        {
            model = vmodel;
        }
    }
}
