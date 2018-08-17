using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IService
    {
        string ServiceMethod();
    }

    public class ClaimService : IService
    {
        public string ServiceMethod()
        {
            return " ClaimService is running";
        }
    }

    public class AdjudificationService : IService
    {
        public string ServiceMethod()
        {
            return " AdjudificationService is running";
        }
    }

    public class PaymentService : IService
    {
        public string ServiceMethod()
        {
            return " PaymentService is running";
        }
    }
}
