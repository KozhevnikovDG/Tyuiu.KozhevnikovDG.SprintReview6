using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KozhevnikovDG.SprintReview6.TaskReview.V26.Lib;

namespace Tyuiu.KozhevnikovDG.SprintReview6.TaskReview.V26.Test
{
    [TestClass]
    public class DaraServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = new int[,]
        {
            {1,   2,  3},
            {-4, -5, -6},
            {1,   8,  1}
        };
            int n1 = 1;
            int n2 = 9;
            int c = 2;
            int k = 0;
            int l = 2;

            

            
            int result = ds.GetMatrix(array, n1, n2, c, k, l);

            
            Assert.AreEqual(1, result);
        }
    }
    
}
