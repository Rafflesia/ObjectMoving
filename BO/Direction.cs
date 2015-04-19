using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BO
{
    public class Direction
    {
        int X; int Y;
        CarBO.Position position;
        private CarBO.Position objPosition;
        int _color;

        public Direction(int X, int Y, CarBO.Position objPosition,int _color)
        {
            // TODO: Complete member initialization
            this.X = X;
            this.Y = Y;
            this.objPosition = objPosition;
            this._color = _color;
        }

        public CarBO.Position getObjPosition() {
            return this.objPosition;

        }

        public int getY() {
            return this.Y;
        }

        public int getX()
        {
            return this.X;
        }

        public int getColor()
        {
            return this._color;
        }
    }
}
