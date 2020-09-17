using System;
using System.ServiceModel;
using WcfServiceLibrarySuccess.Models;

namespace WcfServiceLibrarySuccess
{
    [ServiceContract(Name = "AlexPortType", Namespace = "AlexNamespace")]
    public interface IMathService
    {
        //[InputParameterInspection]
        [OperationContract]
        MathAnswer Add(decimal a, decimal b);

        //[InputParameterInspection]
        [OperationContract]
        MathAnswer Subtract(decimal a, decimal b);

        [OperationContract]
        MathAnswer Multiply(decimal a, decimal b);

        [OperationContract]
        [FaultContract(typeof(DivideByZeroException))]
        MathAnswer Divde(decimal a, decimal b);
    }
}
