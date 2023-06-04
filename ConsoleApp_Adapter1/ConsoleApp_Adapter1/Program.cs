namespace ConsoleApp_Adapter1
{

    class Program
    {
        static void Main(string[] args)
        {
            IXML xml = new XMLImp();
            IJSON json = new JsonImpl();

            IJSON xmlAdapter = new XMLAdapter(xml);

            xml.Write();
            xml.Read();

            json.FileName = "customer.json";
            json.Read1();

            xmlAdapter.Read1();

        }
    }

}
