using static System.Console;

namespace _1_Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var words = new string[] { "quick", "quiCk", "BROWn", "FOX", "fox" };
            //WriteLine(IsAnyWordUpperCase(words));
            //WriteLine(IsAnyWordUpperCaseLinq(words));

            //words = new string[] { "quick", "quiCk", "BROWn", "FoX", "fox" };
            //WriteLine(IsAnyWordUpperCase(words));
            //WriteLine(IsAnyWordUpperCaseLinq(words));

            //new TestPerdicates();
            new TestGenericIsAny();
        }

        public static bool IsAnyWordUpperCase(IEnumerable<string> words)
        {
            foreach (var word in words)
            {
                var soFarUpper = true;
                for (var i = 0; i < word.Length && soFarUpper; i++)
                {
                    soFarUpper = soFarUpper && char.IsUpper(word[i]);
                }
                if (soFarUpper)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsAnyWordUpperCaseLinq(IEnumerable<string> words)
        {
            return words.Any(word => word.All(letter => char.IsUpper(letter)));
        }
    }
}
