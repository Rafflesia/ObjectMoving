using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALL;
using ENTITY;

namespace BO
{
    public class CarBO
    {
        //int Speed;
        CarBasic objD = new CarBasic();
        public enum Position
        {
            Left, Right, Up, Down, Stop
        }

        public int getSpeed()
        {
            //int spd = objD.getSpeed();
            //int speed = Convert.ToInt32(sped);
            return objD.getSpeed();
        }

        public bool setSpeed(int s)
        {
            return objD.setSpeed(s);//throw new NotImplementedException();
        }

        public Cars getDrawInfo()
        {
            return objD.getDrawInfo();
        }

        public Cars getPictureInfo()
        {
            return objD.getPictureInfo();
        }

        public Direction ChangePosition(int _color, Position objPosition, int X, int Y, int Uspeed)
        {
            _color += 2;

            if (objPosition == Position.Right)
            {

                X += Uspeed;
                if (X >= 1000)
                {
                    objPosition = Position.Stop;
                    //_color = 0;
                }
                else if ((X >= 350) && (X <= 370) && (Y >= 175))
                {
                    objPosition = Position.Stop;
                    //_color = 0;
                }
                else if ((X >= 370) && (Y >= 175))
                {
                    Y = 350;
                }
                else if ((X >= 350) && (Y <= 67))
                {
                    Y = 75;

                }
            }
            else if (objPosition == Position.Left)
            {

                X -= Uspeed;

                if (X <= 0)
                {
                    objPosition = Position.Stop;
                    //_color = 0;
                }
                else if ((X >= 350) && (X <= 370) && (Y >= 175))
                {
                    objPosition = Position.Stop;
                    //_color = 0;
                }
                else if ((X <= 470) && (Y <= 80))
                {

                    objPosition = Position.Stop;
                    //_color = 0;
                }
                else if ((Y > 300) && (X <= 470))
                {
                    Y = 350;
                }
            }
            else if (objPosition == Position.Up)
            {
                X = 500;
                Y -= Uspeed;

                if (Y <= 0)
                {
                    objPosition = Position.Stop;
                   // _color = 0;
                }
                else if ((Y <= 67) || (Y >= 350))
                {
                    objPosition = Position.Stop;
                   // _color = 0;
                }

            }

            else if (objPosition == Position.Down)
            {
                X = 500;
                Y += Uspeed;

                if (Y >= 400)
                {
                    objPosition = Position.Stop;
                   // _color = 0;
                }

            }

            if (objPosition == Position.Stop)
            {
                X = X;
                Y = Y;
                _color = 1;
            }
            Direction newPosition = new Direction(X, Y, objPosition,_color);
            return newPosition;
        }

    }
}
