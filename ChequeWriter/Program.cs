using static ChequeWriter.WordsWrapper;

namespace ChequeWriter
{
    class ChequeWriter
    {
        public static void Main(string[] args)
        {
            //Console.Write("Enter a number to convert to words: ");

            Double n = Double.Parse(Console.ReadLine());
            Console.WriteLine("{0}", NumWordsWrapper(n));
        }
    }
}

//
// Or we can use Humanizer(https://github.com/Humanizr/Humanizer)
//
