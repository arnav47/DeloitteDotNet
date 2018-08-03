using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace WCFCard
{
    [ServiceContract]
    
   public interface ICard
    {
        [OperationContract]
        [FaultContract(typeof(ArgumentException))]

        bool Authenticate(int CardNo, string cvv);


        [OperationContract]
        [FaultContract(typeof(ArgumentException))]

        bool DateCheck(int CardNo) ;

        [OperationContract]
        [FaultContract(typeof(ArgumentException))]

        decimal Trans(int CardNo, decimal amount);


    }
}
