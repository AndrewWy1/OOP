using AquaShop.Aquarium;
using AquaShop.Decorations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaShop.BusinessLogic
{
    internal class Controller : IController
    {
        private DecorationRepository decoration = new DecorationRepository();
        private List<AquaShop.Aquarium.Aquarium> aquariums = new List<AquaShop.Aquarium.Aquarium>();

        public void AddAquarium(string aquariumType, string aquariumName)
        {
            if (aquariumType.Trim() == "FreshwaterAquarium")
            {
                aquariums.Add(new FreshwaterAquarium(aquariumName));
                Console.WriteLine("Successfully added FreshwaterAquarium");
            }
            else if(aquariumType.Trim() == "SalthwaterAquarium")
            {
                aquariums.Add(new SaltwaterAquarium(aquariumName));
                Console.WriteLine("Successfully added SaltwaterAquarium");
            }
            else
                Console.WriteLine("Invalid aquarium type");
        }

        public void AddDecoration(string type)
        {
            if (type.Trim() == "Ornament")
            {
                decoration.Add(new Ornament());
            }
            else if (type.Trim() == "Plant")
            {
                decoration.Add(new Plant());
            }
            else
                Console.WriteLine("Invalid decoration type");
        }

        public void InsertDecoration(string aquariumName, string decorationType)
        {
           foreach(AquaShop.Aquarium.Aquarium)
        }

        public void AddFish(string aquariumName, string fishType, string FishName, string FishSpecies, decimal price)
        {
            //Type t;
            //if (fishType == "FreshwaterAquarium")
            //    t = typeof(FreshwaterAquarium);

            //else
            //    t = typeof(SaltwaterAquarium);


            //foreach (AquaShop.Aquarium.Aquarium aquarium in aquariums)
            //{
            //    if (aquarium.Name == aquariumName)
            //    {
            //        if (if)
            //        {

            //        }
            //    }
            //}
        }

        public void CalculateValue(string aquariumnName)
        {
            throw new NotImplementedException();
        }

        public void Exit()
        {
            throw new NotImplementedException();
        }

        public void FeedFish(string aquariumnName)
        {
            throw new NotImplementedException();
        }

        

        public void Report()
        {
            throw new NotImplementedException();
        }
    }
}
