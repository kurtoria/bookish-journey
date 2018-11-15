using System;
namespace Labb_2
{
    public class Position
    {
        private int x;
        private int y;

        public int XPos
        {
            get => x;
            set => x = value < 0 ? 0 : value;
        }

        public int YPos
        {
            get => y;
            set => y = value < 0 ? 0 : value;
        }

        public Position(int x, int y)
        {
            XPos = x;
            YPos = y;
        }

        public double Length()
        {
            return Math.Sqrt(Math.Pow(XPos, 2) + Math.Pow(YPos, 2));
        }

        public bool Equals(Position p)
        {
            return XPos == p.XPos && YPos == p.YPos;
        }

        public Position Clone()
        {
            return new Position(XPos, YPos);
        }

        public override string ToString()
        {
            return $"({XPos}, {YPos})";
        }

        public static bool operator >(Position p1, Position p2)
        {
            return Math.Abs(p1.Length() - p2.Length()) < 0.001 ? p1.XPos > p2.XPos : p1.Length() > p2.Length();
        }

        public static bool operator <(Position p1, Position p2)
        {
            return !(p1 > p2);
            //return Math.Abs(p1.Length() - p2.Length()) < 0.001 ? p1.XPos < p2.XPos : p1.Length() > p2.Length();
        }

        public static Position operator +(Position p1, Position p2)
        {
            return new Position((p1.XPos + p2.XPos), (p1.YPos + p2.YPos));
        }

        public static Position operator -(Position p1, Position p2)
        {
            return new Position((p1.XPos - p2.XPos), (p1.YPos - p2.YPos));
        }

        public static double operator %(Position p1, Position p2)
        {
            return Math.Sqrt(Math.Pow(p1.XPos - p2.XPos, 2) + Math.Pow(p1.YPos - p2.YPos, 2));
        }
    }
}
