using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaShop.Fish
{
    abstract internal class Fish
    {
        public string Name {
            get { return Name; }
            set
            {
                if(String.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Fish name cannot be null or empty");
                
                Name = value;
            }
        }
        public string Species 
        {
            get { return Species; }
            set 
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Fish species cannot be null or empty");

                Species = value;
            }
        }
        public abstract int Size { get; protected set;}
        public decimal Price
        {
            get { return Price; }
            set
            {
                if (Price <= 0)
                    throw new ArgumentException("Fish price cannot be below or equal to 0");
            }
        }

        public Fish(string name, string species, decimal price)
        {
            Name = name;
            Species = species;
            Price = price;
        }

        public abstract void Eat();
    }
}
