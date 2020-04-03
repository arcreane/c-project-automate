
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Automate
{
    public abstract class Drink
    {
        protected string name;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        protected int price;

        internal void stName(string v)
        {
            name = v;
        }

        protected bool stick;

        protected bool condiment;

        protected int quantity;

        //public abstract void preparationDrink();

    }
}