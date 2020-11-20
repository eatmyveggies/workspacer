using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workspacer
{
    public class WindowLocation : IWindowLocation
    {
        public WindowLocation(int x, int y, int width, int height, WindowState state)
        {
            // hacky implementation of "gaps" between windows.
            // issue is with gaps between windows are double the expected size.
            int gapSize = 5;
            X = x + gapSize;
            Y = y + gapSize;
            Width = width - gapSize * 2;
            Height = height - gapSize * 2;
            State = state;
  
        }

        public int X { get; private set;}
        public int Y { get; private set;}
        public int Width { get; private set;}
        public int Height { get; private set;}
        public WindowState State { get; private set;}

        public bool IsPointInside(int x, int y)
        {
            return this.X <= x && x <= (this.X + this.Width) && this.Y <= y && y <= (this.Y + this.Height);
        }

        public override string ToString()
        {
            return $"{State} - {X}:{Y}/{Width}:{Height}";
        }

    }
}
