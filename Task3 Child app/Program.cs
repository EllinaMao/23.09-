namespace Task3_Child_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветики! Давайте посчитаем наш результат");
            //var res = Calculator.GetRes<dynamic>(new string[] { "7", "+", "3" });
            var res = Calculator.GetRes(args);
            Console.WriteLine("Результат вычислений: "+ res);
        }
    }
}
