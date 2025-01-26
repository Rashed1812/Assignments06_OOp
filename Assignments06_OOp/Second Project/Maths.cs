using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments06_OOp.Second_Project
{
    internal class Maths
    {
        #region 1.Define Class Maths that has four methods: From Object
        //public int Add(int x, int y)
        //{
        //    return x + y;
        //}
        //public int Subtract(int x, int y)
        //{
        //    return x - y;
        //}
        //public int Multiply(int x, int y)
        //{
        //    return x * y;
        //}
        //public int Divide(int x, int y)
        //{
        //    if (y==0)
        //        return 0;
        //    return x / y;
        //} 
        #endregion


        #region 2. Modify the program so that you do not have to create an instance of class to call the four methods
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Subtract(int x, int y)
        {
            return x - y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static int Divide(int x, int y)
        {
            if (y==0)
                return 0;
            return x / y;
        }
        #endregion
    }
}
