using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroweHorwathAssessment
{
        /// <summary>
    /// This class writes "Hello World" to the correct output that is indicated.
    /// </summary>
    public class HelloWorldOutput : HelloWorldInterface
    {
        HelloWorld hWorld = new HelloWorld();

        public void WriteHelloWorldConsole()
        {
            try
            {
                Console.WriteLine(hWorld.HelloWorldText + Environment.NewLine);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void WriteHelloWorldDB()
        {
            //TO DO
        }

        public void WriteHelloWorldWeb()
        {
            //TO DO
        }

        public void WriteHelloWorldMobile()
        {
            //TO DO
        }

        public void WriteHelloWorld(HelloWorldEnum outputType)
        {
            switch (outputType)
            {
                case HelloWorldEnum.Console:
                    WriteHelloWorldConsole();
                    break;
                case HelloWorldEnum.Database:
                    WriteHelloWorldDB();
                    break;
                case HelloWorldEnum.Web:
                    WriteHelloWorldWeb();
                    break;
                case HelloWorldEnum.Mobile:
                    WriteHelloWorldMobile();
                    break;
            }
        }
    }

}

