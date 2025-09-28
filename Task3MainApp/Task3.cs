using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task3MainApp
{
    public static class Task3
    {
        private static void ProcessCreate(ref Process process, string ChildPath, string[] arguments)
        {
            process.StartInfo.FileName = ChildPath;
            process.StartInfo.Arguments = string.Join(" ", arguments.Select(a => $"\"{a}\""));
            process.StartInfo.UseShellExecute = false;        // запускаємо процес напряму
            process.StartInfo.CreateNoWindow = false; // позволить ОС создать отдельное окно
            process.StartInfo.RedirectStandardOutput = true; // читаємо його консольний вивід
            process.StartInfo.RedirectStandardError = true;  // читаємо його консольний вивід помилок

        }

        public static string RunChildApp(string exepath, string[] arguments)
        {

            var process = new System.Diagnostics.Process();
            ProcessCreate(ref process , exepath , arguments);
            try
            {
                
                process.Start(); // запускаємо процес
                string output = process.StandardOutput.ReadToEnd();
                return output;

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                process.Close();
            }


        }
    }
}
