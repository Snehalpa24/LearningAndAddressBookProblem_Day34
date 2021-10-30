using System;

namespace DBConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectDB obj = new ConnectDB();
            obj.getData();
        }
    }
}
