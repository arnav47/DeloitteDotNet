using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;


namespace CalculatorLibrary
{
    [ServiceContract]
    public interface Icalculator
    {
        [OperationContract]
        [FaultContract(typeof(ArgumentException))]
        int Add(int x, int y);

        [OperationContract]
        [FaultContract(typeof(ArgumentException))]
        int Sub(int x, int y);


    }
}
