using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.Sleep(30000);
            string ActiveWindow = Test.GetCaptionOfActiveWindow();
            if (ActiveWindow == "World of Warcraft")
            {
                Console.WriteLine("Yep");
            }
            //Initialize.startup();
        }
    }
}
