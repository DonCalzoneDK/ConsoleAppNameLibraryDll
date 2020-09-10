using System;
using System.Net.Http.Headers;
using ClassLibraryName;

namespace ConsoleAppNameLibraryDll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ClassLibraryName.Name name = new ClassLibraryName.Name("Josh");

            Console.WriteLine(name.MyNameIs());
            
        }
    }
}
