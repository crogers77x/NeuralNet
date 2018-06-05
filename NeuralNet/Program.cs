using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Layer();
            test.Initialize(10);
            test.AddDendritesToEachNeuron(3);
            var nNeurons = test.nNeurons();
            for (var i = 0; i < 10; i++)
            {
                var currentNeuron = test.getNeuron(i);
                Console.WriteLine("Index: " + i);
                Console.WriteLine("currentNeuron value: " + currentNeuron.Value );
                Console.WriteLine("currentNeuron delta: " + currentNeuron.Delta);
                Console.WriteLine("currentNeuron bias: " + currentNeuron.Bias);
                foreach (var dendrite in currentNeuron.dendrites )
                {
                    Console.WriteLine("dendrite value: " + dendrite.Weight);
                }
            }

            Console.ReadLine();
        }
    }
}
