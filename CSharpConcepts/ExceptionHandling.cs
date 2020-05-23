using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts
{
    public class ExceptionHandling
    {
        public void start()
        {
            try
            {
                throw new FormatException();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format Exception Reached");
                throw new Exception(); // Exception will be thrown to Main() from here...
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in start()");
            }
        }
    }
}
