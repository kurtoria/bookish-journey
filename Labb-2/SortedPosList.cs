using System;
using System.Collections.Generic;
using System.Linq;

namespace Labb_2
{
    public class SortedPosList
    {
        private List<Position> PositionList = new List<Position>();

        public SortedPosList()
        {
        }

        public override string ToString()
        {
            return string.Join(", ", PositionList);
        }

        public int Count()
        {
            return PositionList.Count;
        }

        public void Add(Position pos)
        {
            PositionList.Add(pos);
            PositionList = PositionList.OrderBy(o => o.Length()).ToList();
        }

        public bool Remove(Position pos)
        {
            if (PositionList.Contains(pos))
            {
                PositionList.Remove(pos);
                return true;
            }
            return false;

        }

        public SortedPosList Clone()
        {
            SortedPosList copy = new SortedPosList();
            foreach (var pos in PositionList)
            {
                copy.PositionList.Add(pos.Clone());
            }
            return copy;
        }

        public SortedPosList CircleContent(Position centerPos, double radius)
        {

            SortedPosList circleList = new SortedPosList();
            foreach (var pos in PositionList)
            {
                var dist = Math.Sqrt(Math.Pow(centerPos.XPos - pos.XPos, 2) + Math.Pow(centerPos.YPos - pos.YPos, 2));
                if (dist < radius)
                {
                    circleList.Add(pos.Clone());
                }
            }
            return circleList;
        }

        public static SortedPosList operator +(SortedPosList sp1, SortedPosList sp2)
        {
            SortedPosList copy = sp1.Clone();
            foreach (var pos in sp2.PositionList)
            {
                copy.Add(pos);
            }
            return copy;
        }

        public Position this[int index] => PositionList[index];

    }
}
