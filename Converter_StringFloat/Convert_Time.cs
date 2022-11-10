using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter_StringFloat
{
    internal class Convert_Time
    {
        
        public static float String_to_Float(in string str)
        {
            //Exception handler
            if (string.IsNullOrEmpty(str))
            {
                //action for string is null or empty
                return (float)-1f;
            }

            float[] floatArray = str.Split(':').Select(float.Parse).ToArray();

            //Exception for float out of range
            float returnFloat = floatArray[0] + floatArray[1] / 100;
            if (returnFloat < 7f || returnFloat > 17f) return (float)-1f;

            return returnFloat;
        }


        public static string Float_to_String(in float num)
        {
            //Exception handlers
            if (num < (float)7f || num > (float)17f)
            {
                //actions for float out of range 
                return "The input float invalid.";
            }

            string[] unformatStrArray = num.ToString("00.00").Split('.');

            return unformatStrArray[0] + ':' + unformatStrArray[1];
        }

        static void Main(string[] args)
        {
            //Normal test cases for String_to_Float
            string[] testStrArray = { "05:20", "19:00", "", "15:01", "09:10"}; //{invalids, valids}
            float returnFloat;
            foreach (string str in testStrArray)
            {
                returnFloat = String_to_Float(str);
                Console.WriteLine("The input string is: " + str + ", and the output float is: " + returnFloat);
            }

            //Null string test cases for String_to_Float
            string nullStr = null;
            returnFloat = String_to_Float(nullStr);
            Console.WriteLine("The input string is: null, and the output float is: " + returnFloat);

            //Test cases for Float_to_String
            float[] testfloat = { 5.01f, 18f, .08f, 15.2f, 7.05f, 13f}; //{invalids, valids}
            string returnStr;
            foreach (float flo in testfloat)
            {
                returnStr = Float_to_String(flo);
                Console.WriteLine("The input string is: " + flo + ", and the output float is: " + returnStr);
            }
        }
    }
}
