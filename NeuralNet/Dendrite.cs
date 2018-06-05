using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNet
{
    public class Dendrite
    {
        private double wt;
        public double Weight
        {
            get { return wt; }
            set { wt = value; }
        }

        //Provide a constructor for the class.
        //It is always better to provide a constructor instead of using
        //the compiler provided constructor
        public Dendrite()
        {
            wt = getRandom();
        }

        private double getRandom()
        {
            var randomValue = new Random().NextDouble();
            Console.WriteLine("Random dentrite value: " + randomValue);
            return randomValue;
            // return Util.GetRandomD() * (MaxValue - MinValue) + MinValue;
        }

    }
}
