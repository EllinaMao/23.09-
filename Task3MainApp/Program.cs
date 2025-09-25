using System.Diagnostics;

namespace Task3MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string parentProjectDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            // зараз parentProjectDir = D:\оля\сиспрог\Task3MainApp
            string childFullPath = (Path.Combine(parentProjectDir , "..\\Task3 Child app\\bin\\Debug\\net8.0\\Task3ChildAppexe");)
            childFullPath = Path.GetFullPath(childFullPath);


            Console.WriteLine("Шлях до дочірнього процесу: " + childFullPath);

            if (!File.Exists(childFullPath))
            {
                Console.WriteLine("Файл не найден: " + childFullPath);
                return;
            }

            // Приклад запуску
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = childFullPath ,
                Arguments = "7 3 +" ,
                UseShellExecute = false ,
                RedirectStandardOutput = true
            };

            using (Process process = new Process { StartInfo = startInfo })
            {
                try
                {
                    process.Start();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка запуска дочернего процесса: " + ex.Message);
                    return;
                }
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                Console.WriteLine(output);
            }
        }
    }
}
