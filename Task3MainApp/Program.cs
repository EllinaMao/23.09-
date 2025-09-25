using System.Configuration;
using System.Diagnostics;
using System.Reflection;

namespace Task3MainApp
{
    internal class Program
    {
        static void Main()
        {
            string[] arguments = {"7", "3", "+"};
            string? exePath = ConfigurationManager.AppSettings["ChildExePath"];
            int endCode = 0;
            if (exePath == null)
            {
                Console.WriteLine("Не найден путь к дочернему процессу в appsettings.");
                return;
            }
            try
            {

                Task3.RunChildApp(exePath, arguments);
                Console.WriteLine("Дочерний процесс запущен!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка запуска: " + ex.Message);
            }
        }
    }

}
