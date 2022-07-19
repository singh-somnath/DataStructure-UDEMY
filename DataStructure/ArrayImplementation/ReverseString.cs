using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.ArrayImplementation
{
    class ReverseString
    {
        public string mainString = "";

        public ReverseString(string str)
        {
            this.mainString = str;
        }

        public string reverseString()
        {
            string returnItem = "";
            for (int i = this.mainString.Length-1; i >= 0; i--)
            {
                returnItem += this.mainString[i];
            }
            return returnItem;
        }
    }
}
