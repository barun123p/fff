using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {


            BusinessLogicImplementation businessLogicImplementation = new BusinessLogicImplementation(new ClaimService());
            businessLogicImplementation = new BusinessLogicImplementation(new AdjudificationService());
            businessLogicImplementation = new BusinessLogicImplementation(new PaymentService());
            

            UnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<IService, ClaimService>();
            unityContainer.RegisterType<IService, AdjudificationService>();
            unityContainer.RegisterType<IService, PaymentService>();


            AdjudificationService obj = unityContainer.Resolve<AdjudificationService>();
            obj.ServiceMethod();
            IService obj1 = unityContainer.Resolve<ClaimService>();
            obj1.ServiceMethod();
            IService obj2 = unityContainer.Resolve<PaymentService>();
            obj2.ServiceMethod();
           
            Console.ReadLine();



        }
    }


    public class BusinessLogicImplementation
    {
        private IService client;
        public BusinessLogicImplementation(IService client)
        {
            this.client = client;
            Console.WriteLine("Constructor Injection Injection ==> Current Service: {0}", client.ServiceMethod());
        }
    }
}