using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._09_Процеси
{
    /*
     * Завдання 2
Розробіть додаток, який вміє запускати дочірній процес. Залежно від вибору користувача батьківський застосунок має очікувати завершення дочірнього процесу та відображати код завершення або примусово завершувати роботу дочірнього процесу.*/
    public static class Task2
    {
        public static void RunAndWaitOrKillProcess(string processName)
        {
            Process process = new Process();
            try
            {
                process.StartInfo.FileName = processName;
                process.Start();

                int choise = Choise(new List<string> {
    "Выберите действие",
    "1. Подождите завершения процесса",
    "2. Принудительно завершить процесс" }
);
                switch (choise)
                {
                    case 1:
                        Console.WriteLine("Ждем пока закроют дочерний процесс...");
                        process.WaitForExit();
                        break;
                    case 2:
                        if (!process.HasExited)
                        {
                            process.Kill();
                            Console.WriteLine("Процесс завершен");
                        }
                        break;
                    default:
                        Console.WriteLine("Такого варианта не знаю");
                        break;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка: " + ex.Message);

            }
            finally
            {
                int exitCode = process.ExitCode;
                Console.WriteLine($"Код выхода: {exitCode}");
            }

        }
        private static int Choise(List<string> texts)
        {
            foreach (string text in texts)
            {
                Console.WriteLine(text);
            }
            try
            {
                int choise = Convert.ToInt32(Console.ReadLine());
                return choise;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
