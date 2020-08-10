using System;
using System.ServiceModel;
using WcfServiceLibrarySuccess.Models;

namespace WcfServiceLibrarySuccess
{
    public class MathService : IMathService
    {
        public MathAnswer Add(decimal a, decimal b)
        {
            LogInputData("Add", a, b);
            decimal result = a + b;
            LogResult(result);
            return new MathAnswer(result, 15);
        }

        public MathAnswer Subtract(decimal a, decimal b)
        {
            LogInputData("Subtract", a, b);
            decimal result = a - b;
            LogResult(result);
            return new MathAnswer(result);
        }

        public MathAnswer Divde(decimal a, decimal b)
        {
            LogInputData("Divide", a, b);
            if (b == 0)
            {
                throw new FaultException<DivideByZeroException>(new DivideByZeroException(), new FaultReason("Abe uio"));
            }
            decimal result = a / b;
            LogResult(result);
            return new MathAnswer(result);
        }

        public MathAnswer Multiply(decimal a, decimal b)
        {
            LogInputData("Multiply", a, b);
            decimal result = a * b;
            LogResult(result);
            return new MathAnswer(result);
        }

        private void LogInputData(string action, decimal a, decimal b)
        {
            Console.WriteLine($"{action}: Received {a} and {b}.");
        }

        private void LogResult(decimal result)
        {
            Console.WriteLine($"{result}");
        }
    }
}
