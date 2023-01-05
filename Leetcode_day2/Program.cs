using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_day2
{
    internal class Program
    {

        private static string ExtractMachineType(in string str)
        {
            /* If there is exact 6 digits in the string: 3; contains 'pwm' in the string: 5;
             * contains 'x' in the string: 7.
             */
            int keyValue = 1;
            string subStr = "";
            bool isLastWindowDigit = false;

            //Exception check if Null and Empty string str
            if (String.IsNullOrEmpty(str)) return "String is Empty!";

            //Exception check if str length is < 6
            if (str.Length < 6) return "Unknown";

            //Check with sliding window
            for (int i = 0; i <= str.Length - 6; i++)
            {
                subStr = str.Substring(i, 6).ToLower();

                //If there are exact 6 continuous digits in the string 
                if (int.TryParse(subStr, out var parsedStr))
                {
                    if (isLastWindowDigit) return "Unknown";
                    isLastWindowDigit = true;
                    keyValue *= 3;
                } else { isLastWindowDigit = false; }
            }

            //Check for extra conditions
            if (str.ToLower().IndexOf("pwm") != -1) keyValue *= 5;
            if (str.ToLower().IndexOf('x') != -1) keyValue *= 7;
            

            //Decide MachineType of String
            if (keyValue % 21 == 0) return "AUX";
            else if (keyValue % 15 == 0) return "PWM";
            else if (keyValue % 3 == 0) return "IV";

            return "Unknown";
        }

        static void Main(string[] args)
        {
            //{AUX, IV, AUX, PWM, AUX, IV}
            string[] testStrValid = { "123456x", "123456", "pwm123456X", "pWm123456", "12345X123456", "pw123456m"};
            //{allInvalid}
            string[] testStrInvalid = { "", "xidf", "xow12345x6", "1234561234567", "12345", "pw12345m", "123,@1234567", "123x456" };

            Console.WriteLine("All the following test cases should be valid:");
            foreach (string str in testStrValid)
            {
                Console.WriteLine("Current test string is: " + str + ", and the result is: " + ExtractMachineType(str));
            }

            Console.WriteLine("\n All the following test cases should be invalid: ");
            foreach (string str in testStrInvalid)
            {
                Console.WriteLine("Current test string is: " + str + ", and the result is: " + ExtractMachineType(str));
            }
        }
    }
}
