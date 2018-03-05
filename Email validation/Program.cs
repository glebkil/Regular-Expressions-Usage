using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*Написать приложение, проверяющее с помощью регулярного выражения корректность
 * ввода адреса электронной почты. Адрес электронной почты должен иметь следующий вид: 
 * login@host, где login - последовательность из букв, цифр и символа "_", начинающаяся с буквы. 
 * Длина - от 3 до 16 символов. host - строка вида mail.ru или mail.odessa.ua и т.п. 
 * В конце host должен содержать от 2 до 3 символов (ua, com, net, ru и т.д.)*/

namespace Email_validation
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex reg = new Regex(@"^[a-z]\w{2,15}@(\w+.)+[a-z]{1,3}$");
            while (true)
            {
                Console.WriteLine("Input you email: ");
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
