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
            int numberOfMessages;
            string userMessage;

            Console.Write("Напишите сообщение для вывода: ");
            userMessage = Console.ReadLine();
            Console.Write("Сколько раз вывести воше сообщение?: ");
            numberOfMessages = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            for (int i = 1; i <= numberOfMessages; i++)
            {
                Console.WriteLine(i + " " + userMessage);
            }
        }
    }
}
