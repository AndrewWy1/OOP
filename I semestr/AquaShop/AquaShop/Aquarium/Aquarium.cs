using AquaShop.Decorations;
using AquaShop.Fish;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaShop.Aquarium
{
    abstract class Aquarium
    {
        public string Name 
        {
            get { return Name; }
            set
            {
                if(String.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Aquarium cannot be null or empty");

                Name = value;
            }
        }
        public abstract int Capacity { get;  set; }
        public int Comfort { get; set; }

        public List<Decoration> Decorations = new List<Decoration>();
        public List<AquaShop.Fish.Fish> Fish = new List<AquaShop.Fish.Fish>();

        public Aquarium(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }
        public Aquarium(string name)
        {
            Name = name;
        }

        public void AddFish(AquaShop.Fish.Fish fish)
        {
            if (Fish.Count >= Capacity)
                throw new InvalidOperationException("Not enogh capacity");

            Fish.Add(fish);
        }

        public bool RemoveFish(AquaShop.Fish.Fish fish)
        {
           return Fish.Remove(fish);
        }

        public void AddDecoration(Decoration decoration)
        {
            Decorations.Add(decoration);
        }

        public void Feed()
        {
            foreach(AquaShop.Fish.Fish fish in Fish)
            {
                fish.Eat();
            }
        }

        public string GetInfo()
        {
            string str = $"{this.Name} {this.GetType()}";
            if (this.Fish.Count == 0)
                return str += $" Fish: None, Decorations: {this.Decorations.Count}, Comfort: {this.Comfort}";

            else
            {
                foreach (AquaShop.Fish.Fish fish in Fish)
                {
                    str += $" {fish.Name}";
                }

                return str;
            }
        }
    }
}
