using System;
using System.Globalization;
using System.IO;

namespace TimeConversion
{
    class Program
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable(@".\Documents\mydoc.txt"), true);

            string s = Console.ReadLine();

            string result = TimeConversion.timeConversion(s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

    public class TimeConversion
    {
        public static string timeConversion(string s)
        {
            DateTime myDate = DateTime.Parse(s);
            return myDate.ToString("T", CultureInfo.CreateSpecificCulture("de-DE"));
        }
    }
}
