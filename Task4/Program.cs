using System.Configuration;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Завдання 4
Розробіть додаток, який вміє запускати дочірній процес і передавати йому аргументи командного рядка. Як аргументи мають бути шлях до файлу та слово для пошуку. Наприклад, аргументи:
E:\someFolder
bicycle
Дочірній процес має відобразити кількість разів, скільки слово bicycle зустрічається у файлі.*/
            string? exePath = ConfigurationManager.AppSettings["ChildExePath"];
            string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "text.txt");
            string word = "bicycle";

            string[] arguments = new[] {filepath, word};

            string output = Task3MainApp.Task3.RunChildApp(exePath, arguments);
            Console.WriteLine(output);

        }
    }
}
