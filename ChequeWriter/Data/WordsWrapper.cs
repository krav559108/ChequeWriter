using static ChequeWriter.NumToWords;

namespace ChequeWriter
{
    class WordsWrapper : ChequeWriter
	{
        public static String NumWordsWrapper(double n, int decimalPlaces = 2)
        {
            // sets decimal to 2 places
            double factor = Math.Pow(10, decimalPlaces);
            n = n * factor;
            n = Math.Truncate(n);
            n = n / factor;
            string formatedNubmer = string.Format("{0:N" + Math.Abs(decimalPlaces) + "}", n);

            // input recieves a split between whole and fractional parts
            string words = "";
            double intPart;
            double decPart = 0;
            if (n == 0)
                return "zero";
            try
            {
                string[] splitter = formatedNubmer.ToString().Split('.');
                intPart = double.Parse(splitter[0]);
                decPart = double.Parse(splitter[1]);
            }
            catch
            {
                intPart = n;
            }

            if (intPart < 2000000000)
            {
                words = NumWords(intPart) + " DOLLARS";
            }
            else
            {
                Console.WriteLine("Out of range");
            }

            if (decPart > 0 && decPart < 100)
            {
                if (words != "")
                    words += " AND ";
                words += NumWords(decPart) + " CENTS";
            }
            else
            {
                Console.WriteLine("Out of range");
            }

            return words;
        }
    }
}

