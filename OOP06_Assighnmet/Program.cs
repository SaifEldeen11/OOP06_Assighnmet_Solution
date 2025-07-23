// This Code was made by Eng Saif :)
namespace OOP06_Assighnmet
{

    internal class Program
    {
        public static int ReadPointCoordinates(string name)
        {
            int result;
            while (true) 
            {
                Console.WriteLine($"enter {name}:");
                string input = Console.ReadLine();
                //Try Parse
                if (int.TryParse(input, out result)) 
                {
                    return result;
                }
                try
                {
                    result = Convert.ToInt32(input);
                    return result;
                }
                catch { }
                // Parse
                try
                {
                    result = int.Parse(input);
                    return result;
                }
                catch 
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }

        static void Main(string[] args)
        {
            #region Task one 
            //int x1= ReadPointCoordinates("X1");
            //int y1 = ReadPointCoordinates("Y1");
            //int z1 = ReadPointCoordinates("Z1");
            //int x2= ReadPointCoordinates("X2");
            //int y2 = ReadPointCoordinates("Y2");
            //int z2 = ReadPointCoordinates("Z2");



            //Point3D point1 = new Point3D(x1,y1,z1);
            //Point3D point2 = new Point3D(x2,y2,z2);

            ///*the p1==p2 wont work as we need to over load it */
            //if (point1 == point2)
            //{
            //    Console.WriteLine("Equals");
            //}
            //else 
            //{
            //    Console.WriteLine("Not Equals");
            //}

            //Point3D [] arr = new Point3D[5];
            //Array.Sort(arr, new Point3D());
            //Console.WriteLine("Sorted Points:");
            //foreach (var point in arr)
            //{
            //    if (point is not null)
            //    {
            //        Console.WriteLine(point);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Null Point");
            //    }
            //}
            //Point3D Original= new Point3D(1, 2, 3);
            //Point3D Clone = (Point3D)Original.Clone(); // 
            //Point3D copy = new Point3D(1, 2, 3); // Cast required because Clone() returns object

            //Console.WriteLine(copy);  // Point Coordinates: (1, 2, 3)
            //Console.WriteLine(copy);      // Point Coordinates: (1, 2, 3)

            //copy.X = 99;

            //Console.WriteLine(Original);  // Still (1, 2, 3) — proves it's a clone, not reference
            //Console.WriteLine(copy); 
            #endregion

            #region Task Two
            //int sum = Maths.Add(1, 2);
            //int diff = Maths.Subtract(1, 2);
            //int prod = Maths.Multiply(1, 2);
            //int div = Maths.Divide(1, 2);

            //Console.WriteLine($"Add: {sum}");
            //Console.WriteLine($"Subtract: {diff}");
            //Console.WriteLine($"Multiply: {prod}");
            //Console.WriteLine($"Divide: {div}");
            #endregion
        }
    }

}
