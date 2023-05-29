using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_3
{
    internal class Ferrari : ICar
    {
        private string _carName = "488-Spider";
        private string _driver;
        public string CarName { get { return _carName; } }
        public string Driver { get { return _driver; } set { _driver = value; } }

        public string PushTheGas()
        {
            return "Zadu6avam sA!";
        }

        public string UseBrackes()
        {
            return "Brakes";
        }

        public string GetFullInfo()
        {
            return $"{this.CarName}/{this.UseBrackes()}/{this.PushTheGas()}/{this.Driver}";
        }
    }
}
