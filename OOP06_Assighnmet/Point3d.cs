using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06_Assighnmet
{
    internal class Point3D:IComparer<Point3D>,ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point3D():this(0, 0, 0)
        {
        }
        public Point3D(int x , int y , int z)
        {
            X=x;
            Y=y;
            Z=z;
        }
        public Point3D(int x , int y ):this(x,y,0)
        { }
        public Point3D(int x) : this(x, 0, 0)
        { }
        public static bool operator == (Point3D p1, Point3D p2) 
        {
            if(p1 is not null && p2 is not null)
            {
                return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
            }
            return false;
        }
        public static bool operator !=(Point3D p1, Point3D p2)
        {
            if (p1 is not null && p2 is not null)
            {
                return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
            }
            return true;
        }
        public override string ToString()
        {
            return $"Point Coordinates:({X},{Y},{Z})";
        }

        public int Compare(Point3D? x, Point3D? y)
        {
            if (ReferenceEquals(x, y)) return 0; // if both are same object

            if (x is null) return -1;
            if (y is null) return -1;

            // Compare X coordinates first
            if (x.X != y.X)
                return x.X.CompareTo(y.X);

            // If X is equal, compare Y coordinates
            return x.Y.CompareTo(y.Y);
        }

        public object Clone()
        {
            return new Point3D(X,Y,Z);
        }
    }
}
