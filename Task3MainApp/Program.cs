using System.Configuration;
using System.Diagnostics;
using System.Reflection;
/*Розробіть додаток, який вміє запускати дочірній процес і передавати йому аргументи командного рядка. Як аргументи мають бути два числа й операція, яку необхідно виконати. Наприклад, аргументи:
7
3
+
Дочірній процес має відобразити аргументи і вивести результат додавання 10 на екран.*/
namespace Task3MainApp
{
    internal class Program
    {
        static void Main()
        {
            string[] arguments = {"7", "3", "+"};
            string? exePath = ConfigurationManager.AppSettings["ChildExePath"];
            if (exePath == null)
            {
                Console.WriteLine("Не найден путь к дочернему процессу в appsettings. Вы запускали приложение перед запуском этого? exe мог не сформироваться");
                return;
            }
            try
            {
                string output = Task3.RunChildApp(exePath, arguments);
                Console.WriteLine("Дочерний процесс запущен!");
                Console.WriteLine(output);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка запуска: " + ex.Message);
            }
        }
    }

}
