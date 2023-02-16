using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{

    

    class Orders : IPaymentMethods,IReceipts
    {
        public void Card()
        {
            throw new NotImplementedException();
        }

        public void Cash()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Cash accepted");
        }

        public void Gpay()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Gpay Accepted");
        }

        public void PhonePe()
        {
            throw new NotImplementedException();
        }

        public void SendByCourier()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Sending by courier");
        }

        public void SendByMail()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Sending by mail");
        }

        public void SendByPost()
        {
            throw new NotImplementedException();
        }
    }

    internal interface IPaymentMethods
    {

        void Cash();
        void Gpay();
        void PhonePe();
        void Card();
    }


    interface IReceipts
    {

        void SendByCourier();
        void SendByMail();
        void SendByPost();
    }
}
