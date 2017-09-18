using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroweHorwathAssessment
{
    public class HelloWorld
    {
        private string helloWorldText = "Hello World";

        /// <summary>
        /// Property that returns the "Hello World" text.
        /// </summary>
        public string HelloWorldText
        {
            get { return helloWorldText; }
        }

        /// <summary>
        /// Method that returns the value in the helloWorldText field.
        /// </summary>
        /// <returns></returns>
        public string GetHelloWorld()
        {
            try
            {
                helloWorldText = null;
                return helloWorldText;
            }
            catch (ArgumentNullException ane)
            {
                return ane.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
