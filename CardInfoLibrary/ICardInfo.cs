using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel; 

namespace CardInfoLibrary
{
    [ServiceContract]
   public interface ICardInfo
    {
        [OperationContract]
        [FaultContract(typeof(ArgumentException))]
        bool Transaction(int cardno, DateTime expdt, int cvv, float tramt);
    }
}
