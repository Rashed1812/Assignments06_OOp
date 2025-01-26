using Assignments06_OOp.First_Project;
using Assignments06_OOp.Second_Project;
using Assignments06_OOp.Third_Project;

namespace Assignments06_OOp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Project One

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

            //int size;
            //bool flag;
            //do
            //{
            //    Console.Write("please enter size of array: ");
            //    flag =int.TryParse(Console.ReadLine(), out size);

            //} while (!flag);
            //_3DPoint[] ThePoint = new _3DPoint[size];
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Enter cordinate of point {i+1}");
            //    ThePoint[i] = _3DPoint.Read3DPoint();
            //}
            //Console.Clear();
            //Console.WriteLine("Array before sort");
            //_3DPoint.Display(ThePoint);
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Array after sort");
            //_3DPoint.Sortting(ThePoint);
            //_3DPoint.Display(ThePoint); 

            #endregion

            #endregion

            #region Project two

            #region 1.Define Class Maths that has four methods By Object:
            //Maths m = new Maths();
            //Console.WriteLine(m.Add(1 , 2));
            //Console.WriteLine(m.Subtract(10 , 5));
            //Console.WriteLine(m.Multiply(3 , 10));
            //Console.WriteLine(m.Divide(10 , 2)); 
            #endregion

            #region 2.Modify the program so that you do not have to create an instance of class to call the four methods.
            //Console.WriteLine(Maths.Add(1, 2));
            //Console.WriteLine(Maths.Subtract(10, 5));
            //Console.WriteLine(Maths.Multiply(3, 10));
            //Console.WriteLine(Maths.Divide(10, 2)); 
            #endregion

            #endregion

            #region Project Three

            Console.WriteLine("Enter user type (Regular, Permium, Guest) ");

            string usertype = Console.ReadLine();

            User user = usertype.ToLower() switch
            {
            	"regular" => new RegularUser(),
            	"permium"=> new PerimumUser(),
            	"guest"=> new Guestuser(),
            	_ => throw new Exception("invalid")
            };

            Console.WriteLine("Enter product price");
            decimal price= decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter product quantity");
            int quantity= int.Parse(Console.ReadLine());

            Discount discount = user.GetDiscount();
            decimal Discountamount= discount.CalculateDiscount(price, quantity);
            decimal finalprice = (price * quantity) - Discountamount;

            Console.WriteLine($"Discount Amount Is {Discountamount}");
            Console.WriteLine($"Final Price Is {finalprice}");

            #endregion
        }
    }
}
