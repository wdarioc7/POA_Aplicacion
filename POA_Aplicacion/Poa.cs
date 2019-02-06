
using PostSharp.Aspects;
using System;
using System.Diagnostics;

namespace PruebaPostSharp
{
    [Serializable]
    public sealed class AspectoQueInterceptaUnMetodo : OnMethodBoundaryAspect
    {
        private readonly string _category;
        public AspectoQueInterceptaUnMetodo(string category)
        {
            _category = category;
        }
        public override void OnEntry(MethodExecutionArgs args)
        {
            Console.WriteLine("Entrado al método: " + args.Method.Name);
            Trace.WriteLine(string.Format("Entering:{0}.{1}",args.Method.DeclaringType.Name,args.Method.Name),_category);
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            Console.WriteLine("Entrado al método: " + args.Method.Name);
            Trace.WriteLine(string.Format("Entering:{0}.{1}", args.Method.DeclaringType.Name, args.Method.Name), _category);
        }
    }
}