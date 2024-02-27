using System.Diagnostics.Metrics;

namespace Uppgift_7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sträng = new string[] { "hej", "nej", "ja" };
            char tecken = 'j';

            if (FinnsTecknetIAllaSträngar(sträng, tecken))
            {
                Console.WriteLine($"{tecken} finns i alla orden");
            }
            else
            {
                Console.WriteLine($"{tecken} finns inte i alla orden");
            }

            Console.ReadKey();
        }

        static bool FinnsTecknetIAllaSträngar(string[] str, char tecken)
        {
            foreach(var ord  in str)
            {
                if (!ord.Contains(tecken))
                {
                    return false;
                }
            }
            return true;
        }
    }
}