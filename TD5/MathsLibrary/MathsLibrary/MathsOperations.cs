using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathsLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class MathsOperations : IMathsOperations
    {

        int IMathsOperations.Add(int a, int b)
        {
            return a + b;
        }

        int IMathsOperations.Multiply(int a, int b)
        {
            return a * b;
        }

        int IMathsOperations.Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
