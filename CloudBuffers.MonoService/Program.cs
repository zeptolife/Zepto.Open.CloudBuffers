using System;

namespace CloudBuffers.MonoService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CloudBuffers cb = new CloudBuffers();

            //Pass in config as need

            cb.Run();
        }
    }
}
