using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAppCoin.Stack
{
    public class TagValidator
    {
        public class SearchForARange
        {
            public static void Main()
            {

                string data = "<A> </A> Test <B> </B>";
                 data = "<A> <B> </A> Test </B>";

                var result = TagValidatorSolve(data);
            }

            private static bool TagValidatorSolve(string content)
            {
                Stack<string> stktags = new Stack<string>();
                string[] tags =  { "<A>"," </A>","Test","<B>","</B>"};
                
                for(int i =0; i< tags.Length; i++)
                {
                    if (!tags[i].Contains("</") && i+1 != content.Length && tags[i].Contains("<"))
                        stktags.Push(tags[i].Trim().Replace("<","").Trim());

                    if (tags[i].Contains("</"))
                    {
                        var tag = stktags.Pop();

                        var currentClosingTag = tags[i].Trim().Replace("</", "");

                        if (tag.Trim() != currentClosingTag)
                        {
                            return false;
                        }
                    }

                }

                if (stktags.Count() == 0)
                    return true;
                else
                    return false;
            }
        }
    }
}
