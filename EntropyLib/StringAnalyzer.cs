using System;
using System.Collections.Generic;


namespace EntropyLib
{
    public class StringAnalyzer
    {
        Dictionary<char, string> rule = new Dictionary<char, string>();
        
        public string ToFormat(char ch)
        {
            string str = rule[ch];
            string result = "";
            int numberDigits = (int)Math.Ceiling(Math.Log2(rule.Count));
            if (str.Length != numberDigits)
            {
                for (int i = 0; i < numberDigits - str.Length; i++)
                    result += "0";
            }
            result += str;
            return result;
        }
        public string FromStrToCode(string str)
        {
            string result = "";
            for(int i = 0; i < str.Length; i++)
            {
                result += ToFormat(str[i]);
            }
            return result;
        }
        public string FromCharToCode(char ch)
        {
            return rule[ch];
        }
        public void MakeRule(string str)
        {
            int code = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if (!rule.ContainsKey(str[i]))
                {
                    rule.Add(str[i], Convert.ToString(code, 2));
                    code++;
                }
            }
        }

        public StringAnalyzer(string str)
        {
            MakeRule(str);
        }

        public StringAnalyzer() { }
    }
}
