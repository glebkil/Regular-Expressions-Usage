using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

/*1. Написать приложение, проверяющее
 * с помощью регулярного выражения корректность ввода фамилии и инициалов 
 * пользователя в следующем виде: Иванов И.И. либо Иванов ИИ*/

namespace Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex reg = new Regex("^[А-Я][а-я]+ ([А-Я].[А-Я].|[А-Я][А-Я])$");
            while (true)
            {
                Console.WriteLine("Input you name and initials: ");
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
