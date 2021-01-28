using System;

namespace MultiBracketValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("false: " + MultiBracketValidation("fjdslf"));
            Console.WriteLine("true: " + MultiBracketValidation("[fsds]"));
            Console.WriteLine("false: " + MultiBracketValidation(""));
            Console.WriteLine("false: " + MultiBracketValidation("((sf)"));
        }

        /// <summary>
        /// checks if a string has balanced sets of brackets
        /// </summary>
        /// <param name="s">string to test</param>
        /// <returns>true if brackets are balanced, false if brackets are imbalanced or none exist</returns>
        public static bool MultiBracketValidation(string s)
        {
            bool returnVal = false;
            if(s == "") { returnVal = false; }
            if(!s.Contains("(") && !s.Contains("[") && !s.Contains("{")) { returnVal = false;  }
            char[] sArr = s.ToCharArray();
            for(int i = 0; i < sArr.Length; i++)
            {
                if(sArr[i] == '(') { 
                    for(int j = i; j < sArr.Length; j++)
                    {
                        if (sArr[j] == ')')
                        {
                            sArr[j] = '.';
                            returnVal = true;
                        }
                    }
                }
                if(sArr[i] == '[') {
                    for (int j = i; j < sArr.Length; j++)
                    {
                        if (sArr[j] == ']')
                        {
                            sArr[j] = '.';
                            returnVal = true;
                        }
                    }
                }
                if(sArr[i] == '{') {
                    for (int j = i; j < sArr.Length; j++)
                    {
                        if (sArr[j] == '}')
                        {
                            sArr[j] = '.';
                            returnVal = true;
                        }
                    }
                }
            }
            return returnVal;
        }
    }
}
