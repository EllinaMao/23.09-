namespace _23._09_Процеси
{
 /*Процеси
Завдання 1
Розробіть додаток, який уміє запускати дочірній процес і очікувати його завершення. Коли дочірній процес завершено, батьківський додаток має відобразити код завершення.
  */
    public class Program
    {
        static void Main(string[] args)
        {
            Task1.RunAndWaitProcess("notepad.exe");
            Task2.RunAndWaitOrKillProcess("notepad.exe");
        }
    }
}
