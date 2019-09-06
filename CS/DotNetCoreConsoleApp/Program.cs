using System;

namespace DotNetCoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WinRTComponent.Class winRTClass = new WinRTComponent.Class();
            String textFromComponent = winRTClass.MyProperty.ToString();
            Console.WriteLine(textFromComponent);
        }
    }
}
