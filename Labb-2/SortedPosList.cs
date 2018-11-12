using System;
using System.Collections.Generic;

namespace Labb_2
{
    public class SortedPosList
    {
        private List<Position> PositionList { get; set; }
        public SortedPosList()
        {
        }

        public override string ToString()
        {
            return string.Join(", ", PositionList);
        }
    }
}
