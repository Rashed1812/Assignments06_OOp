using Assignments06_OOp.First_Project;

namespace Assignments06_OOp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 2.Override the ToString Function to produce this output:

            //_3DPoint p = new _3DPoint(10, 10, 10);
            //Console.WriteLine(p.ToString());

            #endregion

            #region 3.Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).

            //Console.WriteLine(" enter point P1");
            //_3DPoint p1 = _3DPoint.Read3DPoint();
            //Console.WriteLine(" enter point P2");
            //_3DPoint p2 = _3DPoint.Read3DPoint();
            //Console.WriteLine(p1);
            //Console.WriteLine(p2);

            #endregion

            #region Define an array of points and sort this array based on X & Y coordinates.

            int size;
            bool flag;
            do
            {
                Console.Write("please enter size of array: ");
                flag =int.TryParse(Console.ReadLine(), out size);

            } while (!flag);
            _3DPoint[] ThePoint = new _3DPoint[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter cordinate of point {i+1}");
                ThePoint[i] = _3DPoint.Read3DPoint();
            }
            Console.Clear();
            Console.WriteLine("Array before sort");
            _3DPoint.Display(ThePoint);
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Array after sort");
            _3DPoint.Sortting(ThePoint);
            _3DPoint.Display(ThePoint); 

            #endregion
        }
    }
}
