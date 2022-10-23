using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_5
{
    internal interface IPerson
    {
        public string ID { get; }
        public string Name { get; set; }
        public string GetFullInfo();
    }
}
