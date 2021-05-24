using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newLaba3Vlad
{
    public class Matrix : INormalaizer
    {
        public double[,] Matrix2D { get; set; }

        public Matrix()
        {
            Matrix2D = new double[2,2];
            for (int i = 0; i < Matrix2D.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix2D.GetLength(1); j++)
                {
                    Random rnd = new Random();
                    Matrix2D[i, j] = rnd.Next(-100, 101);
                }
            }
        }

        public double Norma()
        {
            double max = double.MinValue;
            for (int i = 0; i < Matrix2D.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix2D.GetLength(1); j++)
                {
                    if (Matrix2D[i, j] < 0 && max < Matrix2D[i,j] * -1)
                    {
                        max = Matrix2D[i, j] * -1;
                    }
                    else if (max < Matrix2D[i, j]) max = Matrix2D[i, j];
                }
            }

            return max;
        }
    }
}
