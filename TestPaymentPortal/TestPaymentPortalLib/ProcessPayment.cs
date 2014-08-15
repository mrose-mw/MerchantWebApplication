namespace TestPaymentPortalLib
{

    using System;
    using System.ServiceModel;

    #region Program
    public class ProcessPayment : IProcessPayment
    {
        public ProcessPayment()
        {
            
        }
        
        public int ProcessTransation(int cardNumber)
        {
            if (cardNumber == 1)
            {
                return 1;
            }

            return 2;
        }
    }
    #endregion
}
