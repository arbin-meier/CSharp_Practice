using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    internal class day1
    {
        enum Target
        {
            CH,
            Ch,
            cH,
            ch
        }

        private static int _serialSum(in string args)
        {
            if (string.IsNullOrEmpty(args)) return -1;

            int sum = 0;            

            foreach (string _str in Enum.GetNames(typeof(Target)))
            {                
                int _startIndex = 0;
                int _returnIndex = 0;

                while (_startIndex <= args.Length-_str.Length) 
                {
                    string temp = "";
                    _returnIndex = args.IndexOf(_str, _startIndex);

                    if (_returnIndex != -1)
                    {
                        for (int i = _returnIndex-1; i >= 0; i--)
                        {
                            if (Char.IsDigit(args[i]))
                                temp = args[i] + temp;
                            else break;
                        }
                    } else { break; }

                    try { sum += Int32.Parse(temp); } //Is TryParse needed to handle more exceptions?
                    catch { Console.WriteLine("Cannot Parse string to int");  }
                    
                    _startIndex = _returnIndex+1;
                } 
            }

            return sum; 
        }

        static void Main(string[] args)
        {
            string _inputstr = "system-12ch,3252serialnumber-123CH,65ch";
            int sum = _serialSum(_inputstr);
            Console.WriteLine(sum);
        }

        
    }
}
