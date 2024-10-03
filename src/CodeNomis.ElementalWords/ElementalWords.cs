using System.Globalization;
using System.Text;

namespace CodeNomis.ElementalWords;

/// <summary>
/// 
/// </summary>
public class ElementalWords
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="word"></param>
    /// <returns></returns>
    public static string[][] ElementalForms(string word)
    {
        Console.WriteLine("********************************************");
        Console.WriteLine(word.ToUpper());
        var builder=new StringBuilder();
        foreach (var letter in word)
        {
            builder.Append("-");
        }
        Console.WriteLine(builder.ToString());

        _results = new string[0][];
        if (word is not null && word.Length > 0)
        {
            Recurse(word, 0, []);
            foreach (var result in ElementalWords.Results)
            {
                Console.WriteLine(string.Join(", ", result));
            }
            //Console.WriteLine("********************************************");
        }

        return Results;
    }

    /// <summary>
    /// 
    /// </summary>
    private static string[][] _results = new string[0][];

    public static string[][] Results { get => _results; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="wordPart"></param>
    /// <param name="startIndex"></param>
    /// <param name="mappedElements"></param>
    private static void Recurse(string wordPart, int startIndex, List<string> mappedElements)
    {
        if (startIndex == wordPart.Length)
        {
            Array.Resize(ref _results, _results.Length + 1);
            _results[_results.Length - 1] = [.. mappedElements];
            return;
        }

        for (var i = startIndex + 1; i <= wordPart.Length; i++)
        {
            var key = wordPart.Substring(startIndex, i - startIndex);
            key = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(key.ToLower());

            //Console.WriteLine($"start: {startIndex}, i: {i}, symbol: {key}");

            if (PreLoaded.Elements.TryGetValue(key, out var value))
            {
                mappedElements.Add($"{value} ({key})");
                Recurse(wordPart, i, mappedElements);
                mappedElements.RemoveAt(mappedElements.Count - 1);
            }
        }
    }
}
