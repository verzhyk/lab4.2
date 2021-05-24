using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLaba3Vlad
{
    public class Vector : INormalaizer
    {
        public List<double> VectorList { get; set; }

        public Vector()
        {
            this.VectorList = new List<double>();
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                VectorList.Add(rnd.Next(-100, 100));
            }
        }
        public double Norma()
        {
            double sum = 0;
            for (int i = 0; i < VectorList.Count; i++)
            {
                sum += VectorList[i];
            }

            return sum;
        }
    }
}
