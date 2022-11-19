using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userNameLine = String.Join(" ", "ds3bhj y1ter/wfsdg 1nh_jgf ds2c_vbg\\4htref".Split(' ', '/', '\\'));
            Regex regex = new Regex("(^|\\s)([A-Z,a-z]([A-Z,a-z,0-9])*(_([A-Z,a-z,0-9]*))?){3,25}");

            MatchCollection matchCollection = regex.Matches(userNameLine);

            int maxLength = matchCollection[0].Value.Length + matchCollection[1].Value.Length;
            int firstWordIndex = 0;
            for(int i = 1; i < matchCollection.Count-1; i++)
            {
                if (matchCollection[i].Value.Length + matchCollection[i + 1].Value.Length > maxLength)
                {
                    maxLength = matchCollection[i].Value.Length + matchCollection[i + 1].Value.Length;
                    firstWordIndex = i;
                }
                    
            }

            Console.WriteLine(matchCollection[firstWordIndex].Value + matchCollection[firstWordIndex + 1].Value);
        }
    }
}
