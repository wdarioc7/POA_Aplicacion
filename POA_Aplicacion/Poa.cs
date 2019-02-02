
using PostSharp.Aspects;
using System;

namespace PruebaPostSharp
{
    [Serializable]
    class AspectoQueInterceptaUnMetodo : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            Console.WriteLine("Entrado al método: " + args.Method.Name);
        }
    }
}