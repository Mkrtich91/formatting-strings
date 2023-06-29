using System.Globalization;

namespace FormattingStrings
{
    public static class FormatStrings
    {
        public static string Format1(int number1, int number2, float number3, double number4)
        {
            return string.Format(NumberFormatInfo.InvariantInfo, "{0} {2} {1} {3}", number1, number2, number3, number4);
        }

        public static string Format2(string str1, double number1, string str2, float number2, int number3)
        {
            return $"{str2} {number2} {number1} {number3} {str1}";
        }

        public static string Format3(string str1, float number1, double number2, int number3)
        {
            return string.Format(NumberFormatInfo.InvariantInfo, "{3}, {0}, {1:P0}, {2:C2}", str1, number1, number2, number3);
        }

        public static string Format4(int number1, int number2, long number3, string str1, string str2)
        {
            string formattedString = string.Format(NumberFormatInfo.InvariantInfo, "{0},{1},{2:X},{3},{4}", number2, str1, number1, number3, str2);

            return formattedString;
        }

        public static string Format5(string str1, double number1, int number2, int number3)
        {
            string formattedString = string.Format(NumberFormatInfo.InvariantInfo, "{{ \"id\": {0}, \"name\": \"{1}\", \"deposit\": {2:F2}, \"days\": {3:D3} }}", number3, str1, number1, number2);
            return formattedString;
        }

        public static string Format6(int number1, double number2, string str1, string str2, string str3)
        {
            string formattedString = string.Format(NumberFormatInfo.InvariantInfo, "{{ \"parameter\": \"{0}\", \"code\": {{ \"type\": \"{1}\", \"label\": \"{2:X4}\" }}, \"value\": {{ \"data\": \"{3:F2}\", \"units\": \"{4}\" }}}}", str3, str2, number1, number2, str1);

            return formattedString;
        }

        public static string Format7(string str1, string str2, float number1, float number2, int number3)
        {
            return string.Format(NumberFormatInfo.InvariantInfo, "|{4,6}|{0,9}|{2,8}|{1,9}|{3,6}|", str1, str2, number1, number2, number3);
        }

        public static string Format8(string str1, string str2, string str3, double number1, double number2, double number3)
        {
            string formattedString = string.Format(NumberFormatInfo.InvariantInfo, "| {0,8} | {1,7} | {2,10} | {3,11} | {4,10} | {5,8} |", str3, number1, number2, number3, str2, str1);

            return formattedString;
        }

        public static string Format9(string str1, string str2, float number1, float number2, float number3)
        {
            return string.Format(NumberFormatInfo.InvariantInfo, "| {4,10:P} | {0,-12} | {1,-14} | {3,12:C2} | {2,-20:N4} |", str1, str2, number1, number2, number3);
        }

        public static string Format10(decimal number1, decimal number2, double number3, string str1, string str2, string str3)
        {
            string formattedString;

            if (str1 == "Norway")
            {
                formattedString = string.Format(CultureInfo.CurrentCulture, "| {0,-6}   | {1,-12:F0} | {2,12:N2} | {3,15} | {4,11} | ¤{5,11:N4}  |", str1, number1, number3, str3, str2, number2);
            }
            else
            {
                formattedString = string.Format(CultureInfo.CurrentCulture, "| {0,-8} | {1,-12:F0} | {2,12:N2} | {3,15} | {4,11} | ¤{5,11:N4}        |", str1, number1, number3, str3, str2, number2);
            }

            return formattedString;
        }
    }
}
