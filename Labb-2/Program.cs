using System;

namespace Labb_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Position p1 = new Position(2, 4);
            Position p2 = new Position(4, 2);
            Console.WriteLine($"P1: {p1}");
            Console.WriteLine($"P2: {p2}");
            Console.WriteLine(p1.Length());
            Console.WriteLine(p1.Equals(p2));
            Position p3 = p2.Clone();
            Console.WriteLine($"P3: {p3}");
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p1 > p2);
            Console.WriteLine(p1 < p2);
            Console.WriteLine(p1 + p2);
            Console.WriteLine(p1 - p2);
            Console.WriteLine(p1 % p2);


            SortedPosList sp1 = new SortedPosList();
            SortedPosList sp2 = new SortedPosList();
            sp1.Add(new Position(2, 4));
            sp1.Add(new Position(3, 5));
            sp1.Add(new Position(1, 5));
            sp1.Add(new Position(1, 1));
            sp2.Add(new Position(2, 2));
            sp2.Add(new Position(5, 5));
            sp1.Add(p1);
            Console.WriteLine(sp1.ToString());
            Console.WriteLine(sp1.Count());
            sp1.Remove(p1);
            Console.WriteLine(sp1);
            SortedPosList sp3 = sp1.Clone();
            Console.WriteLine(sp3);
            SortedPosList sp4 = sp1.CircleContent(new Position(5,5), 4);
            Console.WriteLine("Circle: " + sp4);
            Console.WriteLine(sp1 + sp2);
            Console.WriteLine(sp1[1]);

        }
    }
}
