using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class RandomGenerator
    {
        private static readonly Random _random = new Random();

        public static int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        public static string RamdomString(int size, bool lowerCase = false)
        {
            var builder = new StringBuilder(size);

            // Unicode characters have fixed ASCII Numbers
            // Upper Case: 65-90
            // Lower Case: 97-122

            char offset = lowerCase ? 'a' : 'A'; // Single Unicode Character
            const int letterOffset = 26; // A to Z or a to z: the length and spacing between them is 26

            for(var i = 0; i < size; i++)
            {
                var @char = (char)_random.Next(offset, offset + letterOffset); // Basically giving a min and max for how letters logic would work
                builder.Append(@char);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }

        public static char[] RamdomString_CharArray(int size, bool lowerCase = false)
        {
            char[] arr = new char[size];
            // Unicode characters have fixed ASCII Numbers
            // Upper Case: 65-90
            // Lower Case: 97-122

            char offset = lowerCase ? 'a' : 'A'; // Single Unicode Character
            const int letterOffset = 26; // A to Z or a to z: the length and spacing between them is 26

            for (var i = 0; i < size; i++)
            {
                var @char = (char)_random.Next(offset, offset + letterOffset); // Basically giving a min and max for how letters logic would work
                arr[i] = @char;
            }

            return arr;
        }
    }
}
