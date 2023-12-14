using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.KozhevnikovDG.SprintReview6.TaskReview.V26.Lib
{
    public class DataService
    {
        
            public int GetMatrix(int[,] array, int n1, int n2, int c, int k, int l)
            {
                if (n1 >= n2 || k >= l || c < 0 || c >= array.GetLength(1) || k < 0 || l >= array.GetLength(0))
                {
                    throw new ArgumentException("введены не верные значения");
                }

                int res = 1;
                for (int i = k; i <= l; i++)
                {
                    if (array[i, c] % 2 != 0)
                    {
                       res *= array[c, i];
                    }
                }

                return res;
            }
        
    }
}
