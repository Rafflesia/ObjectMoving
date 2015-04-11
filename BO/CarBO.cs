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
/*
        public void timer(int _color, global::ObjectMoving.DrawCar.Position objPosition, int X, int Y, int Uspeed)
        {
            _color += 1;

            if (objPosition == Position.Right)
            {

                X += Uspeed;
                if (X >= 1000)
                {
                    objPosition = Position.Stop;
                }
                else if ((X >= 350) && (X <= 370) && (Y >= 175))
                {
                    objPosition = Position.Stop;

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
                }
                else if ((X >= 350) && (X <= 370) && (Y >= 175))
                {
                    objPosition = Position.Stop;

                }
                else if ((X <= 470) && (Y <= 80))
                {

                    objPosition = Position.Stop;
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
                }
                else if ((Y <= 67) || (Y >= 350))
                {
                    objPosition = Position.Stop;
                }

            }

            else if (objPosition == Position.Down)
            {
                X = 500;
                Y += Uspeed;

                if (Y >= 400)
                {
                    objPosition = Position.Stop;
                }

            }

            if (objPosition == Position.Stop)
            {
                X = X;
                Y = Y;
                _color = 0;
            }

            Invalidate();
        }
 * */
    }
}
