using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SLprog
{
    public static class SLprogP
    {
        public static IDictionary<char, int> Silab(string text)
        {
            ValorD(text);

            char[] vocals = { 'a', 'e', 'i', 'o', 'u'};

            Dictionary<char, int> Revoc = new Dictionary<char, int>();
            for(int i = 0; i <text.Length; i++)
            {
                if(vocals.Contains(text[i]))
                {
                    if (Revoc.ContainsKey(text[i]))
                    {
                        Revoc.Add(text[i], 1);
                    }
                    else
                    {
                        Revoc[text[i]] += 1;
                    }
                }
            }
            return Revoc;
        }

        private static void ValorD(string text)
        {
            if (text is null)
            {
                throw new ArgumentNullException(paramName: nameof(text));
            }
        }
    }
}