using System;

namespace Point
{
    class Point2D
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Point2D(float x, float y)
        {
            X = x;
            Y = y;
        }

        public float[] GetXY()
        {
            return new float[] { X, Y };
        }

        public override string ToString()
        {
            return $"Point2D - X: {X}, Y: {Y}";
        }
    }

    class Point3D : Point2D
    {
        public float Z { get; set; }

        public Point3D(float x, float y, float z) : base(x, y)
        {
            Z = z;
        }

        public float[] GetXYZ()
        {
            return new float[] { X, Y, Z };
        }

        public override string ToString()
        {
            return $"Point3D - X: {X}, Y: {Y}, Z: {Z}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point2D point2D = new Point2D(2, 3);
            Point3D point3D = new Point3D(3, 4, 5);

            Console.WriteLine(point2D.ToString());
            Console.WriteLine(point3D.ToString());

            float[] xy = point2D.GetXY();
            Console.WriteLine($"Point2D XY: ({xy[0]}, {xy[1]})");

            float[] xyz = point3D.GetXYZ();
            Console.WriteLine($"Point3D XYZ: ({xyz[0]}, {xyz[1]}, {xyz[2]})");
        }
    }
}
