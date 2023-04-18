using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ReaderSample
{
    public class Reader
    {
        public virtual void Read()// a virtual method is a method that can be overriden in a derived class->sanal bir yöntem, türetilmiş bir sınıfta geçersiz kılınabilen bir yöntemdir
        {
            Console.WriteLine("Reader Running.");
        }

    }

    public abstract class Reader2
    {
        public abstract void Read();
    } 

    public interface Reader1
    {
        public abstract void Read();
    }

    public class FileReader : Reader
    {
        override public void Read() => Console.WriteLine("File Reader running");//eğer bir satırlık kod varsa böyle de yazılabilir.
    }

    public class DBReader : Reader
    {
        override public void Read() => Console.WriteLine("DB Reader running");
    }

    public class WebAPIReader : Reader
    {
        override public void Read() => Console.WriteLine("Web API Reader running");
    }

    public class SocketReader : Reader
    {
        override public void Read() => Console.WriteLine("Socket Reader running");
    }
}
