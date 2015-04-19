using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using ENTITY;

namespace DALL
{
    public class CarBasic
    {
        Cars onjE = new Cars();
        
        public bool setSpeed(int s)
        {
            try {
                onjE.ESpeed = s;
                StreamWriter write = new StreamWriter(@"E:\recent importent\Its New\car on road\ObjectMoving(1)\ObjectMoving\speed.txt");
                write.WriteLine(onjE.ESpeed);
                write.Close();
                return true;
            }
            
            catch { 
                return false;
            }
        }
        
        
        
        public int getSpeed()
        {

            StreamReader read = new StreamReader(@"E:\recent importent\Its New\car on road\ObjectMoving(1)\ObjectMoving\speed.txt");
            onjE.ESpeed=Convert.ToInt32(read.ReadLine());
            return onjE.ESpeed;
        }


        public Cars getDrawInfo()
        {
            Cars DrawCar = new Cars();

            StreamReader read = new StreamReader(@"E:\recent importent\Its New\car on road\ObjectMoving(1)\ObjectMoving\DrawCar.txt");

            try{
                DrawCar.carstyle=read.ReadLine();
                DrawCar.name=read.ReadLine();
                DrawCar.colour=read.ReadLine();
                DrawCar.movingCapacity=read.ReadLine();
                DrawCar.controllBy=read.ReadLine();
                DrawCar.stopBy=read.ReadLine();
                DrawCar.extraQuality=read.ReadLine();

                read.Close();
                return DrawCar;
            }
            catch (Exception e)
            {
                return null;
            }
            
        }


        public Cars getPictureInfo()
        {
            Cars PicCar = new Cars();

            StreamReader read = new StreamReader(@"E:\recent importent\Its New\car on road\ObjectMoving(1)\ObjectMoving\PicCar.txt");

            try
            {
                PicCar.carstyle = read.ReadLine();
                PicCar.name = read.ReadLine();
                PicCar.colour = read.ReadLine();
                PicCar.movingCapacity = read.ReadLine();
                PicCar.controllBy = read.ReadLine();
                PicCar.stopBy = read.ReadLine();
                PicCar.extraQuality = read.ReadLine();

                read.Close();
                return PicCar;
            }
            catch (Exception e)
            {
                return null;
            }

        }
    }
}
