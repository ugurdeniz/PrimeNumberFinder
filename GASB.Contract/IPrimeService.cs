using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace GASB.Contract
{
    [ServiceContract]
    public interface IPrimeService
    {
        [OperationContract]
        Guid Register(string Email);

        [OperationContract]
        int GetJob(Guid clientId);

        [OperationContract]
        void SaveResult(Guid clientId, int N, bool isPrime);
    }
}
