using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLaba3Vlad
{
    public class ComplexNumbers : INormalaizer
    {
        public double Module { get; set; }

        public ComplexNumbers(double module)
        {
            Module = module;
        }
        public double Norma()
        {
            return Math.Pow(Module, 2);
        }
    }
}
