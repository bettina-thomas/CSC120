using System;
using LogicCircuit;
//#pragma warning restore CS1634 // Expected 'disable' or 'restore' after #pragma warning

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circuit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var inputs = new List<IdentityInput>();
            inputs.Add(new IdentityInput() { A = false, D = false, X = false });
            inputs.Add(new IdentityInput() { A = false, D = false, X = false });
            inputs.Add(new IdentityInput() { A = false, D = true, X = true });
            inputs.Add(new IdentityInput() { A = false, D = true, X = true });
            inputs.Add(new IdentityInput() { A = true, D = false, X = true });
            inputs.Add(new IdentityInput() { A = true, D = false, X = false });
            inputs.Add(new IdentityInput() { A = true, D = true, X = true });
            inputs.Add(new IdentityInput() { A = true, D = true, X = true });

            /*var notGate = new NOT();
            notGate.SetInputA(true);
            notGate.SetInputA(false);
            bool state = notGate.Output.State;
            var orGate = new OR();
            orGate.SetInputA(state);
            orGate.SetInputA(false);
            orGate.SetInputB(state);
            orGate.SetInputB(false);
            var andGate = new AND();*/

            foreach (var item in inputs)
            {
                var identity = new Identity();
                identity.SetInputD = item.D;
                identity.SetInputA = item.A;
                identity.SetInputX = item.X;

                var output = identity.Validate();
                Console.WriteLine($" D = {identity.SetInputD }," +
                    $" A = {identity.SetInputA}, " +
                   $" X= { identity.SetInputX}, " +  $"OutPut = {output}"
                 );
            }
        }
         public class IdentityInput
        {
            public bool D { get; set; }
            public bool A { get; set; }
            public bool X { get; set; }

        }
        public class Identity
        {
            public bool SetInputD { get; set; }
            public bool SetInputA { get; set; }
            public bool SetInputX { get; set; }
            
            public bool Validate()
            {
                var notGate = new NOT();
                notGate.SetInputA(true);
                notGate.SetInputA(false);
                bool state = notGate.Output.State;
                var andGate = new AND();
                var andGate2 = new AND();
                andGate.SetInputA(state);
                andGate2.SetInputA(state);
                andGate.SetInputB(state);
                andGate2.SetInputB(state);


                var result = andGate.Output.State;
                var result2 = andGate2.Output.State;
                var orGate = new OR();
                var orGate1 = new OR();
                orGate.SetInputA(result);
                orGate.SetInputB(result);
                orGate1.SetInputA(result2);
                orGate1.SetInputB(result2);
                
                var newstate = orGate.Output.State;
                var newstate1 = orGate1.Output.State;
                var orlast = new OR();
                orlast.SetInputA(newstate);
                orlast.SetInputB(newstate1);

                var finalresult = orlast.Output.State;
                return finalresult;

            }
        }

    }
}
