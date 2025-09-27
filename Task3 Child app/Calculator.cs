using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Child_app
{
    public static class Calculator
    {
        public static object GetRes(string[] args)//изначально лучше было б просто дженерик, но я подумала что мы не знаем что зайдет в качестве аргументов так что я потом поставила dynamic, а потом и вовсе object потому что все равно Compute возвращает именно его
        {
            if(args.Length < 3)
            {
                throw new ArgumentException("Недостаточно данных, передайте три аргумента");
            }
            string expression = $"{args[0]} {args[2]} {args[1]}";
            try
            {
            var result = Calculate(expression);
            return result;
            }
            catch (EvaluateException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public static object Calculate(string expression , string filter = "")
        {
            var table = new System.Data.DataTable();/*табличка данных как бд, она пустая, она тут чисто метод вызвать*/
            try
            {
            var result = table.Compute(expression, filter);/*Калькулятор! местный, если вкратце*/
                return result;//его вернет как object ибо Compute возвращает object.
            }
            catch (EvaluateException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        } 
    }
}
