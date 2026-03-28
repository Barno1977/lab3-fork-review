using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace барно_нурдай
{
    internal class Combinational
    {
        private int[] inputs;
        private int outputs;

        public string Name { get; set; }
    
        public Combinational(string name, int inputCount)
        {
            Name = name;
            inputs = new int[inputCount];
        }

        
        public void SetInputs(params int[] values)
        {
            if (values.Length != inputs.Length)
                throw new ArgumentException("Неверное количество входных значений");

            values.CopyTo(inputs, 0);
        }

        public void ComputeOutput()
        {
            outputs = 1;
            foreach (var input in inputs)
            {
                outputs &= input;
            }
        }

   
        public int GetOutput() => outputs;
    }
}
