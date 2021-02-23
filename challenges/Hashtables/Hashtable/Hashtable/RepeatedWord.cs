using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable
{
    public class RepeatedWord
    {
        public static string FirstRepeatedWord(string s)
        {
            Hashmap map = new Hashmap(50);
            string[] split = s.Split();
            if(split.Length == 0 || split.Length == 1) { return null; }
            foreach(string w in split)
            {
                if (!map.Contains(w))
                {
                    map.Add(w, w);
                }
                else
                {
                    return w;
                }
            }
            return null;
        }
    }
}
