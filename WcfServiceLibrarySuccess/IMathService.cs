using System;
using System.ServiceModel;

namespace WcfServiceLibrarySuccess
{
    [ServiceContract]
    public interface IMathService
    {
        [OperationContract]
        MathAnswer Add(decimal a, decimal b);

        [OperationContract]
        MathAnswer Subtract(decimal a, decimal b);

        [OperationContract]
        MathAnswer Multiply(decimal a, decimal b);

        [OperationContract]
        [FaultContract(typeof(DivideByZeroException))]
        MathAnswer Divde(decimal a, decimal b);
    }
}
