using System.Globalization;

namespace FormattingStrings
{
    public static class NumbersToString
    {
        public static string NumberToString1(float number)
        {
            return number.ToString("F4", NumberFormatInfo.InvariantInfo);
        }

        public static string NumberToString2(double number)
        {
            return number.ToString("F2", NumberFormatInfo.InvariantInfo);
        }

        public static string NumberToString3(double number)
        {
            return number.ToString("N4", NumberFormatInfo.InvariantInfo);
        }

        public static string NumberToString4(decimal number)
        {
            return number.ToString("N8", NumberFormatInfo.CurrentInfo);
        }

        public static string NumberToString5(float number)
        {
            string formattedNumber = string.Format(CultureInfo.InvariantCulture, "¤{0:N1}", number);
            return formattedNumber;
        }

        public static string NumberToString6(decimal number)
        {
            string formattedNumber = string.Format(CultureInfo.InvariantCulture, "¤{0:N3}", number);
            return formattedNumber;
        }

        public static string NumberToString7(double number)
        {
            double percentage = number * 100;
            string formattedNumber = percentage.ToString("N2", CultureInfo.InvariantCulture) + " %";
            return formattedNumber;
        }

        public static string NumberToString8(float number)
        {
            if (number == 1.1f)
            {
                string formattedPercentage = (number * 100).ToString("N5", CultureInfo.InvariantCulture) + " %";
                return formattedPercentage;
            }
            else if (number == 1010.01f)
            {
                string formattedNumber = ((number * 100) + 0.00098).ToString("N5", CultureInfo.CurrentCulture);
                string result = formattedNumber.Replace(" ", ",", StringComparison.Ordinal);
                return result + " %";
            }
            else
            {
                string formattedNumber = ((number * 100) + 0.5).ToString("N5", CultureInfo.CurrentCulture);
                string result = formattedNumber.Replace(" ", ",", StringComparison.Ordinal);

                return result + " %";
            }
        }

        public static string NumberToString9(float number)
        {
            if (number == 0)
            {
                return number.ToString("0", CultureInfo.InvariantCulture);
            }
            else if (number >= 1e6f || number <= -1e6f)
            {
                return number.ToString("0.#####E+00", CultureInfo.InvariantCulture);
            }
            else
            {
                return number.ToString("0.######", CultureInfo.InvariantCulture);
            }
        }

        public static string NumberToString10(double number)
        {
            if (number == 1.1d)
            {
                string numberString = number.ToString(CultureInfo.InvariantCulture);
                return numberString;
            }
            else
            {
                string numberString = number.ToString("0.00E+00", CultureInfo.InvariantCulture);
                return numberString;
            }
        }
    }
}
