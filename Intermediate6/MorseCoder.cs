﻿using System.Collections.Generic;
using System.Linq;

namespace Intermediate6
{
    /// <summary>
    /// Base class for MorseEncoder and MorseDecoder, for character level coding and decoding morse data
    /// </summary>
    public class MorseCoder
    {
        /// <summary>
        /// Pre-constructed dictionary containing the ITU standard morse code table.
        /// </summary>
        static readonly Dictionary<string, string> morseLookupTable = new Dictionary<string, string>()
        {
            {"A", ".-" },
            {"B", "-..." },
            {"C", "-.-." },
            {"D", "-.." },
            {"E", "." },
            {"F", "..-." },
            {"G", "--." },
            {"H", "...." },
            {"I", ".." },
            {"J", ".---" },
            {"K", "-.-" },
            {"L", ".-.." },
            {"M", "--" },
            {"N", "-." },
            {"O", "---" },
            {"P", ".--." },
            {"Q", "--.-" },
            {"R", ".-." },
            {"S", "..." },
            {"T", "-" },
            {"U", "..-" },
            {"V", "...-" },
            {"W", ".--" },
            {"X", "-..-" },
            {"Y", "-.--" },
            {"Z", "--.." },
            {"0", "-----" },
            {"1", ".----" },
            {"2", "..---" },
            {"3", "...--" },
            {"4", "....-" },
            {"5", "....." },
            {"6", "-...." },
            {"7", "--..." },
            {"8", "---.." },
            {"9", "----." }
        };

        /// <summary>
        /// Returns Morse representation of passed input character
        /// </summary>
        /// <param name="inputChar">Character to be converterd to Morse</param>
        public static string GetCharAsMorse(string inputChar) =>
            morseLookupTable.ContainsKey(inputChar) ? morseLookupTable.FirstOrDefault(x => x.Key == inputChar).Value : string.Empty;

        /// <summary>
        /// Decodes Morse representation to character
        /// </summary>
        /// <param name="inputMorse">Morse string to be decoded</param>
        public static string GetMorseAsChar(string inputMorse) =>
            morseLookupTable.ContainsValue(inputMorse) ? morseLookupTable.FirstOrDefault(x => x.Value == inputMorse).Key : string.Empty;
    }
}
