using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaShop.BusinessLogic
{
    internal interface IController
    {
        public void AddAquarium(string aquariumType, string aquariumName);
        public void AddDecoration(string type);
        
        public void InsertDecoration(string aquariumName, string decorationType);

        public void AddFish(string aquariumName, string fishType, string FishName, string FishSpecies, decimal price);

        public void FeedFish(string aquariumnName);

        public void CalculateValue(string aquariumnName);

        public void Report();

        public void Exit();
    }
}
