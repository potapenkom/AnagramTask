using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AnagramTask
{
    public class UerInput
    {
        private string _input;
        public UerInput(string input)
        {
            _input = input;
        }

        public bool IsLettersOrDigits(string s)
        {
            foreach (var c in s)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public string Reverse(char[] s)
        {
            Array.Reverse(s);
            return new string(s);
        }
        public string Reverse()
        {
            var parts = Regex.Split(_input, @"([^a-zA-Z])");

            var results = new List<string>();
            foreach (var x in parts)
            {
                results.Add(IsLettersOrDigits(x)
                           ? Reverse(x.ToCharArray())
                           : x);
            }
            return string.Concat(results);
        }
    }
}

