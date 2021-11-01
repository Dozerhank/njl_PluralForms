using System;

namespace Plural_Forms
{
    class Program
    {
        public static string PluralForm(string word)
        {

            //Setup initial values
            string endPunctiation = "";
            bool attachToEnd = false;

            //Checks for punctuation and endPunctiation
            if (word.EndsWith(".") || word.EndsWith(",") || word.EndsWith("!") || word.EndsWith("?") || word.EndsWith(";"))
            {
                // takes the last part of string and saves it to endPun
                endPunctiation = word.Substring(word.Length - 1, 1);
                // set bool to true
                attachToEnd = true;
                // we writes word w/o endPun
                word = word.Substring(0, word.Length - 1);
            }

            //Check for es endings
            if (word.EndsWith("s") || word.EndsWith("x") || word.EndsWith("ch") || word.EndsWith("sh") || word.EndsWith("z"))
            {
                word = word + "es";
            }

            //Come back and use switch statement on array
            else if (word.EndsWith("qo") || word.EndsWith("wo") || word.EndsWith("ro") || word.EndsWith("to") || word.EndsWith("po") || word.EndsWith("so") ||
            word.EndsWith("do") || word.EndsWith("fo") || word.EndsWith("go") || word.EndsWith("ho") || word.EndsWith("jo") || word.EndsWith("ko") || word.EndsWith("lo") ||
            word.EndsWith("zo") || word.EndsWith("xo") || word.EndsWith("co") || word.EndsWith("vo") || word.EndsWith("bo") || word.EndsWith("no") || word.EndsWith("mo"))
            {
                word = word + "es";
            }

            else if (word.EndsWith("qy") || word.EndsWith("wy") || word.EndsWith("ry") || word.EndsWith("ty") || word.EndsWith("py") || word.EndsWith("sy") ||
            word.EndsWith("dy") || word.EndsWith("fy") || word.EndsWith("gy") || word.EndsWith("hy") || word.EndsWith("jy") || word.EndsWith("ky") || word.EndsWith("ly") ||
            word.EndsWith("zy") || word.EndsWith("xy") || word.EndsWith("cy") || word.EndsWith("vy") || word.EndsWith("by") || word.EndsWith("ny") || word.EndsWith("my"))
            {
                //Delete y and add es
                word = word.Substring(0, word.Length - 1);
                word = word + "ies";
            }

            //Default
            else
            {
                word = word + "s";
            }

            //Add the ending punctuation
            if (attachToEnd == true)
            {
                word = word + endPunctiation;
                return word;
            }
            else
            {
                return word;
            }

        }


        public static void Main(string[] args)
        {
            string userInput;

            Console.WriteLine("This program converts an English word to its plural form.");
            Console.WriteLine();
            Console.Write("English word: ");
            userInput = Console.ReadLine();
            Console.WriteLine("Plural form: {0}", PluralForm(userInput));

        }
    }
}
