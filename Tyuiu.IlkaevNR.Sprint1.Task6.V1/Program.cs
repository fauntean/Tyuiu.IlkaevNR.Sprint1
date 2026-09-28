using System.Net.Http.Headers;
using Tyuiu.IlkaevNR.Sprint1.Task6.V1.Lib;

namespace Tyuiu.IlkaevNR.Sprint1.Task6.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Илькаев Н. Р. | ИСТНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Илькаев Н. Р. | ИСТНб-26-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит код введенного пользователем        *");
            Console.WriteLine("* символа. Программа должна завершать работу в результате ввода,          *");
            Console.WriteLine("* например, точки.                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value;

            Console.WriteLine("Введите символ и нажмите клавишу <Enter> :");
            Console.WriteLine("Для завершения введите символ точки <.> .");

            while (true) 
            {

                value = Console.ReadLine();

                if (string.IsNullOrEmpty(value))
                {
                    continue;
                }

                if (value[0] == '.')
                {
                    break;
                }

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
                Console.WriteLine("***************************************************************************");

                Console.WriteLine("Символ: " + value + " Код: " + ds.SymbolCode(value));
                
            }
            

        }
    }
}
