using System;
namespace Labb_2
{
    public class Position
    {
        public int XPos
        {
            get => XPos;
            set => XPos = value < 0 ? 0 : value;
        }

        public int YPos
        {
            get => YPos;
            set => YPos = value < 0 ? 0 : value;
        }

        public Position()
        {
        }


    }
}
