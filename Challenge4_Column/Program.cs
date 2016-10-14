using System;

namespace Challenge4_Column
{
    public class Program
    {
        /// <summary>
        /// メイン
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            if (args.Length >= 1)
            {
                int number;
                if (int.TryParse(args[0], out number))
                    Console.WriteLine(ConvertToColumnName(number));
                else
                    Console.WriteLine(ConvertToColumnNumber(args[0].ToUpper()));
            }
        }


        /// <summary>
        /// 数値をExcelの列名(ローマ字)に変換
        /// </summary>
        /// <param name="columnNumber"></param>
        /// <returns></returns>
        public static string ConvertToColumnName(int columnNumber)
        {
            string str = "";
            int quot = columnNumber - 1;
            while (quot >= 26)
            {
                int remain = quot % 26;
                str = (char)('A' + remain) + str;
                quot = quot / 26 - 1;
            }
            str = (char)('A' + quot) + str;
            return str;
        }


        /// <summary>
        /// Excelの列名(ローマ字)を数値に変換
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public static int ConvertToColumnNumber(string columnName)
        {
            int num = 0;
            foreach (var c in columnName)
            {
                num *= 26;
                num += (c - 'A') + 1;
            }
            return num;
        }

    }
}
