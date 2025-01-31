namespace UniqueNamer;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class UniqueNamer
{
    public static string Generate(Categories[] categories, int suffixLength = 0, string separator = "-", int? seed = null, Style style = Style.lowercase)
    {
        var random = seed.HasValue ? new Random(seed.Value) : Random.Shared;

        var wordsList = Data.Words[categories[random.Next(categories.Length)]];

        var adjective = Data.Adjectives[random.Next(Data.Adjectives.Length)];
        var noun = wordsList[random.Next(wordsList.Length)];

        if (suffixLength == 0)
        {
            return $"{FormatWord(adjective, style)}{separator}{FormatWord(noun, style)}";
        }
        else
        {
            var sb = new StringBuilder();
            sb.Append(FormatWord(adjective, style)).Append(separator).Append(FormatWord(noun, style)).Append(separator);
            for (int i = 0; i < suffixLength; i++)
            {
                switch(style)
                {
                    case Style.lowercase:
                    case Style.TitleCase:
                        sb.Append(Data.SuffixLowerCaseAlphabet[random.Next(Data.SuffixLowerCaseAlphabet.Length)]);
                        break;
                    case Style.UPPERCASE:
                        sb.Append(Data.SuffixUpperCaseAlphabet[random.Next(Data.SuffixUpperCaseAlphabet.Length)]);
                        break;
                    default: throw new NotImplementedException();
                }
            }
            return sb.ToString();
        }
    }

    private static string FormatWord(string noun, Style style)
    {
        switch(style)
        {
            case Style.TitleCase: return $"{char.ToUpperInvariant(noun[0])}{noun.Substring(1)}";
            case Style.lowercase: return noun.ToLowerInvariant();
            case Style.UPPERCASE: return noun.ToUpperInvariant();
            default: throw new NotImplementedException();
        }
    }
}
