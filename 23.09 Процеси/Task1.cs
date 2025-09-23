using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._09_Процеси
{ 
/*Процеси
Завдання 1
Розробіть додаток, який уміє запускати дочірній процес і очікувати його завершення. Коли дочірній процес завершено, батьківський додаток має відобразити код завершення.
  */
    public static class Task1
    {
        public static void RunAndWaitProcess(string processName)
        {
            Process process = new Process();
            try
            {
                process.StartInfo.FileName = processName;
                process.Start();

                Console.WriteLine("Ждем пока закроют дочерний процесс...");
                process.WaitForExit();

            }
            catch(Exception ex) {
                Console.WriteLine("Помилка: " + ex.Message);

            }
            finally
            {
                int exitCode = process.ExitCode;
                Console.WriteLine($"Дети закончились, всем до свидания: {exitCode}");
            }

        }
        
    }
}
