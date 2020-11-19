using System;
using LogicCircuit;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demorgan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ored then Notted");
            var inputs = new List<IdentityInput>();
            //var orgate = new OR();
            inputs.Add(new IdentityInput() { X = false, Y = false });
            inputs.Add(new IdentityInput() { X = false, Y = true });
            inputs.Add(new IdentityInput() { X = true, Y = false });
            inputs.Add(new IdentityInput() { X = true, Y = true });


            foreach (var tes in inputs)
            {
                //var identity1 = new Identity();
                var identity1 = new Identity();
                var identity2 = new Identity();

                identity1.SetInputX = tes.X;
                identity2.SetInputY = tes.Y;

                string result = string.Join(",", identity1.SetInputX, identity2.SetInputY);
                new OR(result);
                Console.WriteLine($"RESULT: {result}");
                if (identity1.SetInputX == true)
                {
                    Console.WriteLine(false);
                }
                else if (identity2.SetInputY == true)
                {
                    Console.WriteLine(false);
                }
                else
                {
                    Console.WriteLine(true);
                }
            }
            Console.WriteLine("results after notting variable and anding");
            foreach (var tes2 in inputs)
            {
                var identity1 = new Identity();
                var identity2 = new Identity();

                identity1.SetInputX = tes2.X;
                identity2.SetInputY = tes2.Y;

                string result = string.Join(",", identity1.SetInputX, identity2.SetInputY);
                new AND(result);
                Console.WriteLine($"RESULT2: {result}");
                if (identity1.SetInputX != identity2.SetInputY)
                {
                    Console.WriteLine(false);
                }
                else if(identity1.SetInputX == true)
                {
                    Console.WriteLine(false);
                }
                else { Console.WriteLine(true); }
            }
            Console.WriteLine("RESULT == RESULT2. Proves demorgan's theorem" + "\n\n");
            Console.WriteLine("Anded and then Notted");
            foreach (var tes3 in inputs)
            {
                var identity1 = new Identity();
                var identity2 = new Identity();

                identity1.SetInputX = tes3.X;
                identity2.SetInputY = tes3.Y;

                string result = string.Join(",", identity1.SetInputX, identity2.SetInputY);
                new AND(result);
                Console.WriteLine($"RESULT3: {result}");
                if (identity1.SetInputX != identity2.SetInputY)
                {
                    Console.WriteLine(true);
                }
                else if (identity1.SetInputX == true)
                {
                    Console.WriteLine(false);
                }
                else { Console.WriteLine(true); }
            }
            Console.WriteLine("Not each variable then add");
            foreach (var tes4 in inputs)
            {
                var identity1 = new Identity();
                var identity2 = new Identity();

                identity1.SetInputX = tes4.X;
                identity2.SetInputY = tes4.Y;

                string result = string.Join(",", identity1.SetInputX, identity2.SetInputY);
                new OR(result);
                Console.WriteLine($"RESULT4: {result}");
                if (identity1.SetInputX != identity2.SetInputY)
                {
                    Console.WriteLine(true);
                }
                else if (identity1.SetInputX == true)
                {
                    Console.WriteLine(false);
                }
                else { Console.WriteLine(true); }
            }
            Console.WriteLine("RESULT3 == RESULT4. Proves demorgan's theorem");
        }
        class IdentityInput
        {
            public bool X { get; set; }
            public bool Y { get; set; }

        }
        class Identity
        {
            public bool SetInputX { get; set; }
            public bool SetInputY { get; set; }
            
        }
       
    }
    
}
