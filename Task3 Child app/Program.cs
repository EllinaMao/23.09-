namespace Task3_Child_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {


                Console.WriteLine("Приветики! Давайте посчитаем наш результат");
                var res = Calculator.GetRes(args);
                Console.WriteLine("Результат вычислений: " + res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
