using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;
using CommandLine.Text;

namespace RC4_key_recovery_tool
{
    class Program
    {
        private static bool isPermutation(int[] array)
        {
            bool[] test = new bool[array.Length];
            foreach (int x in array)
            {
                if (test[x])
                    return false;
                test[x] = true;
            }
            return true;
        }


        private static bool parsePermutation(string[] s, NumberStyles style, out int[] result)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;

            result = new int[s.Length];

            int i = 0;
            foreach (string word in s)
            {
                int number;
                bool success = Int32.TryParse(word, style, provider, out number);

                if (!success)
                    return false;

                result[i] = number;
                i++;
            }
            return true;
        }

        private static bool parseHexPermutation(string[] s, out int[] result)
        {
            return parsePermutation(s, NumberStyles.HexNumber, out result);
        }

        private static bool parseIntPermutation(string[] s, out int[] result)
        {
            return parsePermutation(s, NumberStyles.Integer, out result);
        }

        private static int readNumber(string message)
        {
            bool providedKeyLength = false;
            int number = -1;
            while (!providedKeyLength)
            {
                Console.WriteLine(message);

                string word = Console.ReadLine();

                if (!Int32.TryParse(word, out number))
                    Console.WriteLine("ERROR. Failed to parse number");
                else
                    providedKeyLength = true;
            }
            return number;
        }

        private static bool readOption(string[] options, string message, out string selected)
        {
            Console.WriteLine(message);
            string readed = Console.ReadLine();

            foreach (string option in options)
            {
                if (readed == option)
                {
                    selected = readed;
                    return true;
                }
            }

            selected = "";
            return false;
            
        }

        private static bool askQuestion(string message)
        {
            string option;
            while (!readOption(new string[] { "y", "n" }, message + " Type [y/n]", out option)) ;

            if (option == "n") return false;
            return true;
        }

        public static void Main(string[] args)
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));

            int[] permutation = new int[Constants.N];

            char[] delimiterChars = { ' ', ',', ':', ';', '\t', '\n' };
            bool providedPermutation = false;
            while (!providedPermutation)
            {
                Console.WriteLine("Please write the inner PERMUTATION S:");

                string[] words = new string[0];
                string input = "";
                string line;

                while ((line = Console.ReadLine()) != null)
                {             
                    if (line == "done") break;
                    input = input + " " + line;
                    words = input.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
                    if (words.Length == Constants.N) break;
                }

                if (!(words.Length == Constants.N))
                {
                    Console.WriteLine("ERROR. Please provide permutation with {0} entries.", Constants.N);
                    continue;
                }

                if (!parseIntPermutation(words, out permutation))
                    if(!parseHexPermutation(words, out permutation)) {
                        Console.WriteLine("ERROR. Unable to parse values. Did you provide numbers in decimal (i.e. 123) or hexadecimal (i.e. C9) form?");
                    }

                if (!isPermutation(permutation))
                    Console.WriteLine("ERROR. Values correctly parsed, but seems not to be permutation.");

                providedPermutation = true;
                Console.WriteLine("Permutation correct.");
            }

            int keyLength = readNumber("Please set KEY LENGHT. Type number from 1 to N.");
            Cracker attack = new Cracker(permutation, keyLength);

            if (Constants.defaults[keyLength] != null)
            {
                Console.WriteLine("Default parameters for length {0} are (m,nc) = ({1},{2})",
                    keyLength, Constants.defaults[keyLength].m, Constants.defaults[keyLength].nc);
            }

            bool keyRetrieved = false;
            while(!keyRetrieved)
            {
                int m = readNumber("Set m (number of key bytes to be fixed)");
                int nc = readNumber("Set nc (number of candidates for each non fixed key byte to be tried)");
                int[] key;

                if (attack.guessKey(m, nc, out key))
                {
                    Console.WriteLine("Key successfully retireved:");
                    Utils.LogArrayHex(key);
                    break;
                } else
                {
                    Console.WriteLine("FAIL. Key retrieving were not successfull.");
                    string option;
                }

                if (!askQuestion("Do you want change the parameters?"))
                    break;
                
            }




            #if DEBUG
                        Console.WriteLine("Press enter to close...");
                        Console.ReadLine();
            #endif
        }
    }
}
