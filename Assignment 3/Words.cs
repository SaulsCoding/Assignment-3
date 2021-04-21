using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Words
    {
        public string NumbWords(int value)
        {
            string[] Singles = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] Doubles = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };


            if (value >= 0 && value <= 20)
            {
                return Singles[value];
            }
            else if (value < 100)
            {
                return Doubles[value / 10] + ((value % 10 > 0) ? " " + NumbWords(value % 10) : "");
            }
            else if (value < 1000)
            {
                return Singles[value / 100] + " Hundred" + ((value % 100 > 0) ? " And " + NumbWords(value % 100) : "");
            }
            else if (value < 100000)
            {
                return NumbWords(value / 1000) + " Thousand " + ((value % 1000 > 0) ? " " + NumbWords(value % 1000) : "");
            }
            else if (value < 10000000)
            {
                return NumbWords(value / 100000) + " Hundred and " + ((value % 100000 > 0) ? " " + NumbWords(value % 100000) : "");
            }
            else
            {
                return value.ToString();
                //return value;
            }
        }
    }
}
