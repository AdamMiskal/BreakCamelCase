using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BreakCamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string text=Console.ReadLine();
            Console.WriteLine(BreakCamelCase(text)); 
        }
        public static string BreakCamelCase(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return "";
            }
                
            else
                {
                var pattern = "(?<!^)([A-Z])";

                var rgx = new Regex(pattern);
                var result = rgx.Replace(str, " $1");
                return result;
            }
            
        }
    }
}
