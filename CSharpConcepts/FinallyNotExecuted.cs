using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    internal class FinallyNotExecuted
    {
        public void start()
        {
            int[] array1 = { 0, 0 };
            int[] array2 = { 0, 0 };

            try
            {
                Array.Copy(array1, array2, -1);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Error: {0}", e);
                // Whenever we re-throw an exception in the catch block and there's no further catch block to handle it,
                // the finally block is not executed.
                // Another case where finally is not executed is when we set System.ExitCode to failure
                throw;
            }
            finally
            {
                Console.WriteLine("This statement is always executed.");
            }
        }
    }
}
