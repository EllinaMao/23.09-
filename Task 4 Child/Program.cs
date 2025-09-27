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
//Unhandled exception. System.IO.FileNotFoundException: Could not find file 'D:\lessons\СисПрограмирование\23.09 Процеси2\Task 4 Child\bin\Debug\net8.0\text.txt'.
//File name: 'D:\lessons\СисПрограмирование\23.09 Процеси2\Task 4 Child\bin\Debug\net8.0\text.txt'
//   at Microsoft.Win32.SafeHandles.SafeFileHandle.CreateFile(String fullPath, FileMode mode, FileAccess access, FileShare share, FileOptions options)
//   at Microsoft.Win32.SafeHandles.SafeFileHandle.Open(String fullPath, FileMode mode, FileAccess access, FileShare share, FileOptions options, Int64 preallocationSize, Nullable`1 unixCreateMode)
//   at System.IO.Strategies.OSFileStreamStrategy..ctor(String path, FileMode mode, FileAccess access, FileShare share, FileOptions options, Int64 preallocationSize, Nullable`1 unixCreateMode)
//   at System.IO.Strategies.FileStreamHelpers.ChooseStrategyCore(String path, FileMode mode, FileAccess access, FileShare share, FileOptions options, Int64 preallocationSize, Nullable`1 unixCreateMode)
//   at System.IO.FileStream..ctor(String path, FileMode mode, FileAccess access)
//   at Task_4_Child.Program.Main(String[] args) in D:\lessons\СисПрограмирование\23.09 Процеси2\Task 4 Child\Program.cs:line 13

//D:\lessons\СисПрограмирование\23.09 Процеси2\Task 4 Child\bin\Debug\net8.0\Task 4 Child.exe (process 23204) exited with code -532462766 (0xe0434352).
//Press any key to close this window . . .