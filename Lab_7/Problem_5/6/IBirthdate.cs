using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_5._6
{
    internal interface IBirthdate
    {
        Date BornYear { get; set; }

        public string GetFullInfo();
    }
}
