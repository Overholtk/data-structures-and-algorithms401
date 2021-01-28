using System;

namespace MultiBracketValidations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("false: " + MultiBracketValidation("((sf)"));
        }

        /// <summary>
        /// checks if a string has balanced sets of brackets
        /// </summary>
        /// <param name="s">string to test</param>
        /// <returns>true if brackets are balanced, false if brackets are imbalanced or none exist</returns>
        public static bool MultiBracketValidation(string s)
        {
            bool returnVal = true;
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
                            break;
                        }
                        else if(j == sArr.Length - 1 && sArr[j] != ')'){ returnVal = false; }
                    }
                }
                if(sArr[i] == '[') {
                    for (int j = i; j < sArr.Length; j++)
                    {
                        if (sArr[j] == ']')
                        {
                            sArr[j] = '.';
                            break;
                        }
                        else if (j == sArr.Length - 1 && sArr[j] != ']') { returnVal = false; }
                    }
                }
                if(sArr[i] == '{') {
                    for (int j = i; j < sArr.Length; j++)
                    {
                        if (sArr[j] == '}')
                        {
                            sArr[j] = '.';
                            break;
                        }
                        else if (j == sArr.Length - 1 && sArr[j] != '}') { returnVal = false; }
                    }
                }
            }
            return returnVal;
        }
    }
}
