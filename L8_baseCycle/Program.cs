using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8_baseCycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count;
            string userMessage;

            Console.Write("Напишите сообщение для вывода: ");
            userMessage = Console.ReadLine();
            Console.Write("Сколько раз вывести воше сообщение?: ");
            count = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine(i + " " + userMessage);
            }
        }
    }
}
