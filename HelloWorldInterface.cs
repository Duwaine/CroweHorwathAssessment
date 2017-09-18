using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroweHorwathAssessment
{       
    /// <summary>
    /// This interface is implemented by whichever output method is used for the output of the "Hello World" text. 
    /// </summary>
    public interface HelloWorldInterface
    {
        void WriteHelloWorld(HelloWorldEnum outputType);
    }       
}
