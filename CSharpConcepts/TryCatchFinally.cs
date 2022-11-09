using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConcepts
{
    public class TryCatchFinally
    {
        public int start()
        {
            try
            {
                throw new DivideByZeroException();
                return 1;
            }
            catch (DivideByZeroException ex)
            {
                return 2;
            }
            catch (Exception ex)
            {
                return 5;
            }
            finally
            {
                //Compile Time Error
                //Control cannot leave the body of finally clause, so cannot have a return statement in finally block
                //return 3;
            }
        }


    }
}
