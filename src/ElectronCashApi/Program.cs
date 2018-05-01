using System;
using HttpJsonRpc;

namespace ElectronCashApi
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonRpc.RegisterMethods(typeof(Program).Assembly);
            JsonRpc.Start("http://127.0.0.1:80");

            Console.ReadLine();
        }
    }
}
