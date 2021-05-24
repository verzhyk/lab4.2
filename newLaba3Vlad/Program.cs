using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLaba3Vlad
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumbers num = new ComplexNumbers(5);
            Matrix matrix = new Matrix();
            Vector vector = new Vector();


            Console.WriteLine(num.Norma());
            Console.WriteLine(matrix.Norma());
            Console.WriteLine(vector.Norma());
        }
    }
}
