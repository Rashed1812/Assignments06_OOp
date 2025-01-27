using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments06_OOp.First_Project
{
    internal class _3DPoint : IComparable
    {
        #region Attributes

        private int x;
        private int y;
        private int z;

        #endregion

        #region Properties
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        #endregion

        #region Constrctors
        public _3DPoint(int _x, int _y, int _z)
        {
            x= _x;
            y= _y;
            z= _z;

        }
        public _3DPoint(int _x, int _y) : this(_x, _y, 0)
        {


        }
        public _3DPoint(int _x) : this(_x, 0, 0)
        {


        }
        #endregion

        #region Override ToString()
        public override string ToString()
        {
            return $"Point Coordinates:{x},{y},{z}";
        } 
        #endregion

        #region 3.Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).

        public static _3DPoint Read3DPoint()
        {
            int x, y, z;
            bool flag;

            do
            {
                Console.Write(" Enter X:");
                flag = int.TryParse(Console.ReadLine(), out x);

            } while (!flag);
            do
            {
                Console.Write(" Enter Y:");
                flag = int.TryParse(Console.ReadLine(), out y);

            } while (!flag);
            do
            {
                Console.Write(" Enter Z:");
                flag = int.TryParse(Console.ReadLine(), out z);

            } while (!flag);

            return new _3DPoint(x, y, z);
        }

        #endregion

        #region 4.Try to use  == If(P1 == P2)   Does it work properly? 

        public static bool operator ==(_3DPoint p1, _3DPoint p2)
        {
            return p1.x == p2.x && p1.y == p2.y && p1.z == p2.z;
        }
        public static bool operator !=(_3DPoint p1, _3DPoint p2)
        {

            return p1.x != p2.x || p1.y != p2.y || p1.z != p2.z;
        }

        #endregion

        #region Define an array of points and sort this array based on X & Y coordinates
        public static void Display(_3DPoint[] Nums)
        {
            for (int i = 0; i < Nums.Length; i++)
                Console.WriteLine(Nums[i]);
        }

        public static void Sortting(_3DPoint[] Nums)
        {
            Array.Sort(Nums);
        }

        public int CompareTo(object? obj)
        {
            _3DPoint pp = (_3DPoint)obj;
            if (x > pp.x)
                return 1;
            else if (x<pp.x)
                return -1;
            else
            {
                if (y>pp.y)
                    return 1;
                else if (y<pp.y)
                    return -1;
                else
                {
                    if (z > pp.z)
                        return 1;
                    else if (z<pp.z)
                        return -1;
                    return 0;
                }
            }

        }

        #endregion

    }
}
