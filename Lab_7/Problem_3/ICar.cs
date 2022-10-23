using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_3
{
    internal interface ICar
    {
        string CarName { get; }

        public string UseBrackes();
        public string PushTheGas();
    }
}
