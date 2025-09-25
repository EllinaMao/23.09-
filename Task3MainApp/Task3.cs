using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task3MainApp
{
    public static class Task3
    {
        public static void RunChildApp(string ChildPath, string[] arguments)
        {

            var process = new System.Diagnostics.Process();
            try
            {

                process.StartInfo.FileName = ChildPath;
                process.StartInfo.Arguments = string.Join(" " , arguments.Select(a => $"\"{a}\""));
                process.StartInfo.UseShellExecute = false;        // запускаємо процес напряму
                process.StartInfo.RedirectStandardOutput = true; // читаємо його консольний вивід
                process.StartInfo.RedirectStandardError = true;  // читаємо його консольний вивід помилок

                process.Start(); // запускаємо процес
                string output = process.StandardOutput.ReadToEnd();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error setting up process: {ex.Message}");
                return;
            }
            finally
            {
                process.Close();
            }


        }
    }
}
