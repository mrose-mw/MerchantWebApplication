namespace TestPaymentPortalLib
{

    using System;
    using System.ServiceModel;

    [ServiceContract]
    public interface IProcessPayment
    {
        [OperationContract]
        int ProcessTransation(int cardNumber);
    }

}
