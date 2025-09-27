using System.IO;
using System.Text.RegularExpressions;

namespace Task_4_Child
{
    internal class Program
    {
        /*Дочірній процес має відобразити кількість разів, скільки слово bicycle зустрічається у файлі.*/


        static void Main(string[] args)
        {
            FileStream fs = new FileStream(args[0], FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string fileContent = sr.ReadToEnd();
            sr.Close();
            Regex pattern = new Regex($@"\b{args[1]}\b", RegexOptions.IgnoreCase);
            MatchCollection matches = pattern.Matches(fileContent);

            Console.WriteLine($"The word '{args[1]}' occurs {matches.Count} times in the file '{args[0]}'.");

        }
    }
}
