using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using PostSharp.Aspects;
using static POA_Aplicacion.Program;

namespace POA_Aplicacion
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Hola();
            Adios();
        }
        [Trace("HolaCategoria")]
        public static void Hola ()
            {
            Console.WriteLine("Hola Mundo!");
        }
        [Trace("AdiosCategoria")]
        public static void Adios()
        {
            Console.WriteLine("Adios Mundo!");
        }
        [Serializable]
        public sealed class TraceAttribute : OnMethodBoundaryAspect
        {
            private readonly string _category;
            public TraceAttribute(string category)
            {
                _category = category;
            }
            public override void OnEntry(MethodExecutionArgs args)
            {
                //Console.WriteLine("Entrado al método: " + args.Method.Name);
                Trace.WriteLine(string.Format("Entering:{0}.{1}", args.Method.DeclaringType.Name, args.Method.Name), _category);
            }

            public override void OnExit(MethodExecutionArgs args)
            {
                //Console.WriteLine("Entrado al método: " + args.Method.Name);
                Trace.WriteLine(string.Format("Entering:{0}.{1}", args.Method.DeclaringType.Name, args.Method.Name), _category);
            }
        }
    }
}

