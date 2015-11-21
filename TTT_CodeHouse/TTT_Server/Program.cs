using System;
using TTT_Server.Lib;

namespace TTT_Server
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Press 1 for Server, 2 for Client");
            var pressed = Console.ReadKey();
            Console.Clear();
            if (pressed.Key == ConsoleKey.D1)
                TcpHandler.Receive(13000, "127.0.0.1");
            else
            {
                Console.Write("Type a Message: ");
                var message = Console.ReadLine();
                Console.WriteLine();
                TcpHandler.Send(13000, "127.0.0.1", message);
            }
        }
    }
}