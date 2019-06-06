using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GASB.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PrimeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PrimeService.svc or PrimeService.svc.cs at the Solution Explorer and start debugging.
    public class PrimeService : /*GASB.Contract.IPrimeService eklenmesi lazım  */ 
    {
        public void DoWork()
        {
        }

        public int GetJob(Guid clientId)
        {
            //using (GASBDataContext db=new GASBDataContext())
            //{
                return 3;
            //}
        }

        public Guid Register(string Email)
        {
            throw new NotImplementedException();
        }

        public void SaveResult(Guid clientId, int N, bool isPrime)
        {
            throw new NotImplementedException();
        }
    }
}
