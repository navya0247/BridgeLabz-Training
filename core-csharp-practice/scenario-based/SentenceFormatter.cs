using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.scenarioBased
{
    class SentenceFormatter
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a paragraph:");
            string para = Console.ReadLine();

            string formatted = FormatParagraph(para);
            Console.WriteLine(formatted);

        
            AnalyzeParagraph(para);

            Console.ReadLine();
        }

        //  Method for format paragraph
        static string FormatParagraph(string p)
        {
            string res = "";
            bool cap = true;
            bool giveSpace = false;

            for (int i = 0; i < p.Length; i++)
            {
                char ch = p[i];

                // avoid extra spaces
                if (ch == ' ')
                {
                    if (giveSpace)
                    {
                        res += ' ';
                        giveSpace = false;
                    }
                    continue;
                }

                // make first letter capital after 
                if (cap == true && ch >= 'a' && ch <= 'z')
                {
                    ch = (char)(ch - 32); // capital
                    cap = false;
                }

                res += ch;

                // if punctuation then next should be capital and allow space
                if (ch == '.' || ch == '?' || ch == '!')
                {
                    cap = true;
                    giveSpace = true;
                }
                else
                {
                    giveSpace = true;
                }
            }
            return res;
        }

        // method for analyze paragraph
        static void AnalyzeParagraph(string p)
        {
            int wordCount = 0;
            string longest = "";
            string cur = "";

            //  Count words + find longest word
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] != ' ')
                {
                    cur += p[i];
                }
                else
                {
                    if (cur != "")
                    {
                        wordCount++;

                        if (cur.Length > longest.Length)
                            longest = cur;

                        cur = "";
                    }
                }
            }

            // check last word
            if (cur != "")
            {
                wordCount++;
                if (cur.Length > longest.Length)
                    longest = cur;
            }

            Console.WriteLine("Word Count: " + wordCount);
            Console.WriteLine("Longest Word: " + longest);

            //  Replace word 
            Console.WriteLine("\nEnter word to replace:");
            string oldW = Console.ReadLine();

            Console.WriteLine("Enter new word:");
            string newW = Console.ReadLine();

            string finalPara = "";
            string temp = "";

            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] != ' ')
                {
                    temp += p[i];
                }
                else
                {
                    if (SameIgnoreCase(temp, oldW))
                        finalPara += newW + " ";
                    else
                        finalPara += temp + " ";
                    temp = "";
                }
            }

            // last word check
            if (SameIgnoreCase(temp, oldW))
                finalPara += newW;
            else
                finalPara += temp;

            Console.WriteLine("\nReplaced Paragraph:");
            Console.WriteLine(finalPara);
        }

        //  check equal words without ToLower
        static bool SameIgnoreCase(string a, string b)
        {
            if (a.Length != b.Length) return false;

            for (int i = 0; i < a.Length; i++)
            {
                char x = a[i];
                char y = b[i];

                if (x >= 'A' && x <= 'Z') x = (char)(x + 32);
                if (y >= 'A' && y <= 'Z') y = (char)(y + 32);

                if (x != y) return false;
            }
            return true;
        }
    }
}
