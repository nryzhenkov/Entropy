using System;
using System.Collections.Generic;

namespace EntropyLib
{
    public class StringAnalyzer
    {
        Dictionary<char, string> rule = new Dictionary<char, string>();

        public string FromCharToCode(char ch)
        {
            return rule[ch];
        }
        public void MakeRule(string str)
        {
            int code = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if (rule.ContainsKey(str[i]))
                {
                    rule.Add(str[i], Convert.ToString(code, 2));
                    code++;
                }
            }
        }
    }
}
