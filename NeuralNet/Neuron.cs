using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNet
{
    class Neuron
    {
        public List<Dendrite> dendrites;
        private double bias, delta, _value;

        public double Bias
        {
            get
            { return bias; }
            set
            { bias = value; }
        }
        public double Delta
        {
            get
            { return delta; }
            set
            { delta = value; }
        }
        public double Value
        {
            get
            { return _value; }
            set
            { _value = value; }
        }

        public void AddDendrites(int nDendrites)
        {
            int i;
            //Dendrite d;
            for (i = 0; i < nDendrites; i++)
            {
                //d = new Dendrite();
                dendrites.Add(new Dendrite());
            }
        }

        public int nDendrites()
        {
            return dendrites.Count;
        }

        public Dendrite getDendrite(int index)
        {
            return dendrites[index];
        }

        public Neuron()
        {
            bias = new Random().NextDouble();
            dendrites = new List<Dendrite>();
        }

    }
}
