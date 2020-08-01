using System.Diagnostics;
using System.ServiceModel.Dispatcher;

namespace WcfServiceLibrarySuccess.MessageInspection
{
    public class DivideInspector : IParameterInspector
    {
        private static int n = 0;

        public void AfterCall(string operationName, object[] outputs, object returnValue, object correlationState)
        {
            Debug.WriteLine($"{++n}. IParameterInspector.AfterCall called for {operationName}.");
        }

        public object BeforeCall(string operationName, object[] inputs)
        {
            Debug.WriteLine($"{++n}. IParameterInspector.BeforeCall called for {operationName}.");
            return null;
        }
    }
}
