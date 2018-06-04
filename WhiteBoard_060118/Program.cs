using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoard_060118
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string below, and I will mix it up and send it back to you:");
            string input = Console.ReadLine();

            char[] delimiterChars = { ' ', '.', ',', ';', ':', '?', '!'  };
            List<string> inputList = new List<string>(input.Split(delimiterChars));
            List<string> outputList = new List<string>();
            Random random = new Random();

            foreach (string s in inputList)
            {
                // create temporary string (stringbuilder)
                string sTemp = s;
                StringBuilder sTempSB = new StringBuilder();
                // while letters left in string s
                while (sTemp.Length > 0)
                {
                    // get character at random index and append to temporary string
                    int randomIndex = random.Next(0, sTemp.Length);
                    sTempSB.Append(sTemp[randomIndex]);

                    // remove that character from string s
                    sTemp = sTemp.Remove(randomIndex, 1);
                }

                // add temp string to output list
                outputList.Add(sTempSB.ToString());

            }

            Console.WriteLine(string.Join(" ", outputList.ToArray()));
            Console.ReadLine();

        }
    }
}
