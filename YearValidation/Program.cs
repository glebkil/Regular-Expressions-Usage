using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
/*Написать приложение, проверяющее с помощью регулярного
 * выражения корректность ввода даты в формате Число-Месяц-Год (например, 01-04-2015)*/

namespace YearValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex reg = new Regex(@"^(0?[1-9]|[12][0-9]|3[01])-(0?[1-9]|1[012])-((19|20)\d\d)$");
            while (true)
            {
                Console.WriteLine("Input any date in format of dd-mm-yyyy");
                if (reg.IsMatch(Console.ReadLine()))
                {
                    Console.WriteLine("Input is correct");
                }
                else
                {
                    Console.WriteLine("Input is incorrect");
                }
            }
        }
    }
}
