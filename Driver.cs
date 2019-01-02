using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Bell
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                long a = addTwoInts.Run(qsim,1,5).Result;
                System.Console.WriteLine(""+a);
            }
        }
    }
}