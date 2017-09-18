using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroweHorwathAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write "Hello World" to the Windows console.
            HelloWorldOutput hWConsole = new HelloWorldOutput();
            hWConsole.WriteHelloWorld(HelloWorldEnum.Console);
        }
    }
}
