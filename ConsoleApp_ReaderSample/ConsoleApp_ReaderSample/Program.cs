using System;
using System.Reflection.PortableExecutable;

namespace ConsoleApp_ReaderSample
{
    class Program 
    {
        static void Main(string[] args)
        {
            ReaderFactory readerFactory = new ReaderFactory();

            for (int i = 0; i < 4; i++)
            {
                Reader reader = readerFactory.CreateReader(i+1);
                reader.Read();
            }
            Console.Read();
        }
    }
}///burası aslında client yani data buradan istenir,kullanıcı datayı buradan çeker
