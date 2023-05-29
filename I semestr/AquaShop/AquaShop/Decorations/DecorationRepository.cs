using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaShop.Decorations
{
    internal class DecorationRepository : IRepository<Decoration>
    {
        public List<Decoration> Models =  new List<Decoration>();

        public void Add(Decoration model)
        {
            Models.Add(model);
        }

        public bool Remove(Decoration model)
        {
            return Models.Remove(model);
        }

        public Decoration? FindByType(string type)
        {
            Type t;

            if(type == "Ornament")
               t= typeof(Ornament);

            else
                t = typeof(Plant);


            foreach(Decoration model in Models)
            {
                if(model.GetType() == t)
                {
                    return model;
                }
            }

            return null;
            
        }
    }
}
