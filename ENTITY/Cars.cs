using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Data;


namespace ENTITY
{
    public class Cars
    {

        public int ESpeed;
        public string carstyle;
        public string name;
        public string colour;
        public string movingCapacity;
        public string controllBy;
        public string stopBy;
        public string extraQuality;

        public void drawCar(Graphics carBody, Graphics Wheel, Pen p, int move_direction, int _color, Panel panel1)
        {
            Pen q = new Pen(Color.Black, 6);
            if (move_direction == 1)
            {
                panel1.Height = 120;
                panel1.Width = 400;


                p = new Pen(Color.Red, 5);
                //moving to left

                carBody.DrawLine(p, new Point(10, 30), new Point(10, 90));//a,b
                carBody.DrawLine(p, new Point(10, 30), new Point(90, 30));//a,c
                carBody.DrawLine(p, new Point(90, 30), new Point(170, 5));//c,d
                carBody.DrawLine(p, new Point(170, 5), new Point(270, 5));//d,e
                carBody.DrawLine(p, new Point(270, 5), new Point(320, 35));//e,f
                carBody.DrawLine(p, new Point(320, 35), new Point(380, 35));//f,g
                carBody.DrawLine(p, new Point(380, 35), new Point(380, 90));//g,h
                carBody.DrawLine(p, new Point(380, 90), new Point(310, 90));
                carBody.DrawLine(p, new Point(118, 90), new Point(10, 90));//a,b



                carBody.DrawLine(p, new Point(183, 90), new Point(260, 90));

                //car glass
                carBody.DrawLine(p, new Point(170, 5), new Point(170, 35));
                carBody.DrawLine(p, new Point(92, 33), new Point(170, 33));

               // p = new Pen(Color.RosyBrown, 10);

                // carBody.DrawRectangle(p, 177, 5, 83, 30);
                carBody.FillRectangle(Brushes.Red, 177, 5, 83, 30);
                carBody.FillRectangle(Brushes.Red , 20, 50, 183, 10);
                carBody.FillRectangle(Brushes.Red, 360, 37, 10, 52);
                carBody.FillRectangle(Brushes.Red, 345, 37, 10, 52);

                //carBody.DrawLine(p, new Point(177, 5), new Point(177, 35));
                //carBody.DrawLine(p, new Point(176, 33), new Point(260, 33));
                //carBody.DrawLine(p, new Point(260, 5), new Point(260, 35));

                p = new Pen(Color.Red, 5);
                carBody.DrawLine(p, new Point(267, 5), new Point(267, 35));
                carBody.DrawLine(p, new Point(267, 33), new Point(315, 33));



                //car shild
                p = new Pen(Color.RosyBrown, 19);
                carBody.DrawLine(p, new Point(6, 90), new Point(6, 77));

                //car headlight
                p = new Pen(Color.Yellow, 15);

                Wheel.DrawEllipse(p, 18, 40, 13, 13);

                //  carBody wheel

                p = new Pen(Color.Black, 10);

                Wheel.DrawEllipse(p, 125, 65, 50, 50);
                Wheel.DrawEllipse(p, 260, 65, 50, 50);


                if (_color == 0)
                {
                    Wheel.DrawLine(q, new Point(130, 90), new Point(170, 90));
                }
                else if ((_color % 2) == 1)
                    Wheel.DrawLine(q, new Point(130, 90), new Point(170, 90));
                else
                    Wheel.DrawLine(q, new Point(150, 70), new Point(150, 110));
                //2nd wheel moving 
                if (_color == 0)
                {
                    Wheel.DrawLine(q, new Point(265, 90), new Point(305, 90));
                }
                else if ((_color % 2) == 1)
                    Wheel.DrawLine(q, new Point(265, 90), new Point(305, 90));
                else
                    Wheel.DrawLine(q, new Point(285, 70), new Point(285, 110));


            }
            else if (move_direction == 2)
            {//moving to right

                panel1.Height = 120;
                panel1.Width = 400;


                p = new Pen(Color.Red, 5);
                //moving to left

                carBody.DrawLine(p, new Point(10, 30), new Point(10, 90));//a,b
                carBody.DrawLine(p, new Point(10, 30), new Point(70, 30));//a,c
                carBody.DrawLine(p, new Point(70, 30), new Point(150, 5));//c,d
                carBody.DrawLine(p, new Point(150, 5), new Point(240, 5));//d,e
                carBody.DrawLine(p, new Point(240, 5), new Point(310, 35));//e,f
                carBody.DrawLine(p, new Point(310, 35), new Point(390, 35));//f,g
                carBody.DrawLine(p, new Point(390, 35), new Point(390, 90));//g,h
                carBody.DrawLine(p, new Point(390, 90), new Point(310, 90));
                carBody.DrawLine(p, new Point(118, 90), new Point(10, 90));//a,b



                carBody.DrawLine(p, new Point(187, 90), new Point(260, 90));

                //car glass
                carBody.DrawLine(p, new Point(150, 5), new Point(150, 35));
                carBody.DrawLine(p, new Point(73, 31), new Point(150, 31));

                carBody.DrawLine(p, new Point(157, 5), new Point(157, 35));
                carBody.DrawLine(p, new Point(156, 33), new Point(241, 33));
                
                carBody.DrawLine(p, new Point(239, 5), new Point(239, 35));
                carBody.DrawLine(p, new Point(246, 5), new Point(246, 35));
                carBody.DrawLine(p, new Point(246, 33), new Point(308, 33));
                
                carBody.FillRectangle(Brushes.Red, 155, 5, 83, 30);

                carBody.FillRectangle(Brushes.Red, 210, 50, 183, 10);
                carBody.FillRectangle(Brushes.Red, 30, 32, 10, 55);
                carBody.FillRectangle(Brushes.Red, 45, 32, 10, 55);

                //car shild
                p = new Pen(Color.RosyBrown, 19);
                carBody.DrawLine(p, new Point(380, 90), new Point(380, 77));

                //car headlight
                p = new Pen(Color.Yellow, 15);

                Wheel.DrawEllipse(p, 380, 40, 13, 13);

                //  carBody wheel

                p = new Pen(Color.Black, 10);

                Wheel.DrawEllipse(p, 125, 65, 50, 50);
                Wheel.DrawEllipse(p, 260, 65, 50, 50);


                if (_color == 0)
                {
                    Wheel.DrawLine(q, new Point(130, 90), new Point(170, 90));
                }
                else if ((_color % 2) == 1)
                    Wheel.DrawLine(q, new Point(130, 90), new Point(170, 90));
                else
                    Wheel.DrawLine(q, new Point(150, 70), new Point(150, 110));
                //2nd wheel moving 
                if (_color == 0)
                {
                    Wheel.DrawLine(q, new Point(265, 90), new Point(305, 90));
                }
                else if ((_color % 2) == 1)
                    Wheel.DrawLine(q, new Point(265, 90), new Point(305, 90));
                else
                    Wheel.DrawLine(q, new Point(285, 70), new Point(285, 110));
            }

            else if (move_direction == 3)
            {

                panel1.Height = 360;
                panel1.Width = 160;

                //moving up
                p = new Pen(Color.Red, 3);
                //car front glass
                carBody.DrawLine(p, new Point(100, 150), new Point(45, 150));
                carBody.DrawLine(p, new Point(115, 90), new Point(30, 90));
                carBody.DrawLine(p, new Point(45, 150), new Point(30, 105));
                carBody.DrawLine(p, new Point(30, 105), new Point(30, 90));
                carBody.DrawLine(p, new Point(115, 105), new Point(100, 150));
                carBody.DrawLine(p, new Point(115, 90), new Point(115, 105));

                //car right window
                p = new Pen(Color.Red, 5);
                carBody.DrawLine(p, new Point(40, 150), new Point(20, 90));
                carBody.DrawLine(p, new Point(20, 250), new Point(20, 90));
                carBody.DrawLine(p, new Point(20, 250), new Point(40, 200));
                carBody.DrawLine(p, new Point(40, 150), new Point(40, 200));

                //   car side glass 
                p = new Pen(Color.Red, 3);
                carBody.DrawLine(p, new Point(35, 153), new Point(24, 120));
                carBody.DrawLine(p, new Point(25, 118), new Point(25, 170));
                carBody.DrawLine(p, new Point(25, 182), new Point(25, 220));
                carBody.DrawLine(p, new Point(25, 220), new Point(35, 198));
                carBody.DrawLine(p, new Point(35, 170), new Point(35, 151));
                carBody.DrawLine(p, new Point(35, 198), new Point(35, 182));

                carBody.DrawLine(p, new Point(25, 182), new Point(35, 182));
                carBody.DrawLine(p, new Point(35, 170), new Point(25, 170));

                //car left window
                p = new Pen(Color.Red, 5);
                carBody.DrawLine(p, new Point(105, 150), new Point(126, 90));
                carBody.DrawLine(p, new Point(126, 255), new Point(126, 90));
                carBody.DrawLine(p, new Point(126, 255), new Point(105, 200));
                carBody.DrawLine(p, new Point(105, 150), new Point(105, 200));

                ////   car side glass 
                p = new Pen(Color.Red, 3);
                carBody.DrawLine(p, new Point(110, 153), new Point(120, 120));
                carBody.DrawLine(p, new Point(120, 172), new Point(120, 120));
                carBody.DrawLine(p, new Point(120, 220), new Point(120, 184));
                carBody.DrawLine(p, new Point(120, 220), new Point(110, 195));
                carBody.DrawLine(p, new Point(110, 184), new Point(110, 195));
                carBody.DrawLine(p, new Point(110, 153), new Point(110, 172));
                carBody.DrawLine(p, new Point(110, 184), new Point(120, 184));
                carBody.DrawLine(p, new Point(110, 172), new Point(120, 172));


                //car backglass

                carBody.DrawLine(p, new Point(100, 218), new Point(45, 218));
                carBody.DrawLine(p, new Point(115, 270), new Point(30, 270));
                carBody.DrawLine(p, new Point(45, 218), new Point(30, 260));

                carBody.DrawLine(p, new Point(115, 260), new Point(100, 218));
                carBody.DrawLine(p, new Point(30, 260), new Point(30, 270));
                carBody.DrawLine(p, new Point(115, 260), new Point(115, 270));

                //car border
                p = new Pen(Color.Red, 5);
                carBody.DrawLine(p, new Point(5, 14), new Point(5, 290));
                carBody.DrawLine(p, new Point(146, 14), new Point(146, 290));
                carBody.DrawLine(p, new Point(5, 14), new Point(12, 7));
                carBody.DrawLine(p, new Point(138, 7), new Point(146, 14));
                carBody.DrawLine(p, new Point(138, 7), new Point(12, 7));

                carBody.DrawLine(p, new Point(146, 290), new Point(137, 296));
                carBody.DrawLine(p, new Point(5, 290), new Point(10, 296));
                carBody.DrawLine(p, new Point(137, 296), new Point(10, 296));



                //car shild
                p = new Pen(Color.RosyBrown, 6);
                carBody.DrawLine(p, new Point(138, 2), new Point(12, 2));


                // car head light
                p = new Pen(Color.Orange, 12);
                Wheel.DrawEllipse(p, 125, 13, 15, 2);
                Wheel.DrawEllipse(p, 14, 13, 15, 2);
            }
            else if (move_direction == 4)
            {

                panel1.Height = 360;
                panel1.Width = 160;
                //moving to down
                p = new Pen(Color.Red, 3);
                //car front glass
                carBody.DrawLine(p, new Point(100, 150), new Point(45, 150));//a,b
                carBody.DrawLine(p, new Point(115, 90), new Point(30, 90));//a,c
                carBody.DrawLine(p, new Point(45, 150), new Point(30, 105));//c,d
                carBody.DrawLine(p, new Point(30, 105), new Point(30, 90));//d,e
                carBody.DrawLine(p, new Point(115, 105), new Point(100, 150));//e,f
                carBody.DrawLine(p, new Point(115, 90), new Point(115, 105));//f,g

                //car right window
                p = new Pen(Color.Red, 5);
                carBody.DrawLine(p, new Point(40, 150), new Point(20, 90));//c,d
                carBody.DrawLine(p, new Point(20, 250), new Point(20, 90));//a,c
                carBody.DrawLine(p, new Point(20, 250), new Point(40, 200));//c,d
                carBody.DrawLine(p, new Point(40, 150), new Point(40, 200));//d,e

                //   car side glass 
                p = new Pen(Color.Red, 3);
                carBody.DrawLine(p, new Point(35, 153), new Point(24, 120));//c,d
                carBody.DrawLine(p, new Point(25, 118), new Point(25, 170));//a,c
                carBody.DrawLine(p, new Point(25, 182), new Point(25, 220));//a,c
                carBody.DrawLine(p, new Point(25, 220), new Point(35, 198));//c,d
                carBody.DrawLine(p, new Point(35, 170), new Point(35, 151));//c,d
                carBody.DrawLine(p, new Point(35, 198), new Point(35, 182));//c,d

                carBody.DrawLine(p, new Point(25, 182), new Point(35, 182));//c,d
                carBody.DrawLine(p, new Point(35, 170), new Point(25, 170));//c,d

                //car left window
                p = new Pen(Color.Red, 5);
                carBody.DrawLine(p, new Point(105, 150), new Point(126, 90));//c,d
                carBody.DrawLine(p, new Point(126, 255), new Point(126, 90));//a,c
                carBody.DrawLine(p, new Point(126, 255), new Point(105, 200));//c,d
                carBody.DrawLine(p, new Point(105, 150), new Point(105, 200));//d,e

                ////   car side glass 
                p = new Pen(Color.Red, 3);
                carBody.DrawLine(p, new Point(110, 153), new Point(120, 120));//c,d
                carBody.DrawLine(p, new Point(120, 172), new Point(120, 120));//a,c
                carBody.DrawLine(p, new Point(120, 220), new Point(120, 184));//a,c
                carBody.DrawLine(p, new Point(120, 220), new Point(110, 195));//a,c
                carBody.DrawLine(p, new Point(110, 184), new Point(110, 195));//a,c 
                carBody.DrawLine(p, new Point(110, 153), new Point(110, 172));
                carBody.DrawLine(p, new Point(110, 184), new Point(120, 184));//a,c 
                carBody.DrawLine(p, new Point(110, 172), new Point(120, 172));


                //car backglass

                carBody.DrawLine(p, new Point(100, 218), new Point(45, 218));//a,b
                carBody.DrawLine(p, new Point(115, 270), new Point(30, 270));//a,c
                carBody.DrawLine(p, new Point(45, 218), new Point(30, 260));//c,d

                carBody.DrawLine(p, new Point(115, 260), new Point(100, 218));//e,f
                carBody.DrawLine(p, new Point(30, 260), new Point(30, 270));//d,e
                carBody.DrawLine(p, new Point(115, 260), new Point(115, 270));//f,g

                //car border
                p = new Pen(Color.Red, 5);
                carBody.DrawLine(p, new Point(5, 40), new Point(5, 330));//f,g
                carBody.DrawLine(p, new Point(146, 40), new Point(146, 330));//f,g
                carBody.DrawLine(p, new Point(5, 40), new Point(12, 33));//f,g
                carBody.DrawLine(p, new Point(138, 33), new Point(146, 40));//f,g
                carBody.DrawLine(p, new Point(138, 33), new Point(12, 33));//f,g

                carBody.DrawLine(p, new Point(146, 330), new Point(137, 336));//f,g
                carBody.DrawLine(p, new Point(5, 330), new Point(10, 336));//f,g
                carBody.DrawLine(p, new Point(137, 336), new Point(10, 336));//f,g



                //car shild
                p = new Pen(Color.RosyBrown, 6);
                carBody.DrawLine(p, new Point(137, 340), new Point(10, 340));//f,g


                // car head light
                p = new Pen(Color.Orange, 12);
                Wheel.DrawEllipse(p, 122, 325, 15, 2);
                Wheel.DrawEllipse(p, 15, 325, 15, 2);
            }


            p = new Pen(Color.Green, 4);

        }

        public void drawTree4(Graphics Tree, Pen p)
        {
            Tree.DrawLine(p, new Point(10, 75), new Point(35, 90));

            Tree.DrawLine(p, new Point(10, 75), new Point(10, 100));

            Tree.DrawLine(p, new Point(35, 115), new Point(35, 90));
            Tree.DrawLine(p, new Point(35, 115), new Point(10, 100));

            Tree.DrawLine(p, new Point(82, 95), new Point(82, 70));

            //p = new Pen(Color.SandyBrown, 12);
            Tree.DrawLine(p, new Point(82, 95), new Point(35, 115));
            Tree.DrawLine(p, new Point(35, 90), new Point(82, 70));

            //b= new Brush();
            // Tree.FillRegion()

            Tree.DrawLine(p, new Point(10, 75), new Point(58, 58));
            Tree.DrawLine(p, new Point(82, 70), new Point(58, 58));

            p = new Pen(Color.Cornsilk, 2);
            Tree.DrawLine(p, new Point(21, 76), new Point(35, 84));
            Tree.DrawLine(p, new Point(21, 76), new Point(55, 64));
            Tree.DrawLine(p, new Point(55, 64), new Point(70, 69));
            Tree.DrawLine(p, new Point(35, 84), new Point(70, 69));

            p = new Pen(Color.SandyBrown, 3);
            Tree.DrawLine(p, new Point(50, 150), new Point(50, 110));
            Tree.DrawLine(p, new Point(60, 145), new Point(60, 105));
            Tree.DrawLine(p, new Point(55, 155), new Point(55, 106));

            p = new Pen(Color.SandyBrown, 2);
            Tree.DrawLine(p, new Point(55, 155), new Point(60, 145));
            Tree.DrawLine(p, new Point(55, 155), new Point(50, 150));

            p = new Pen(Color.Red, 7);
            Tree.DrawEllipse(p, 41, 95, 7, 7);
            p = new Pen(Color.Yellow, 7);
            Tree.DrawEllipse(p, 55, 89, 7, 7);

            p = new Pen(Color.Green, 7);
            Tree.DrawEllipse(p, 70, 82, 7, 7);
        }

        public void drawTree3(Graphics Tree, Pen p)
        {
            Tree.DrawLine(p, new Point(90, 60), new Point(90, 105));

            p = new Pen(Color.Brown, 5);
            Tree.DrawLine(p, new Point(90, 80), new Point(105, 45));
            p = new Pen(Color.Brown, 3);
            Tree.DrawLine(p, new Point(90, 95), new Point(60, 45));

            p = new Pen(Color.GreenYellow, 10);
            Tree.DrawEllipse(p, 90, 50, 13, 7);

            Tree.DrawEllipse(p, 47, 50, 13, 7);
            Tree.DrawEllipse(p, 60, 50, 13, 7);
            Tree.DrawEllipse(p, 75, 50, 13, 7);
            Tree.DrawEllipse(p, 105, 50, 13, 7);
            Tree.DrawEllipse(p, 120, 50, 13, 7);


            Tree.DrawEllipse(p, 65, 35, 13, 7);
            Tree.DrawEllipse(p, 85, 35, 13, 7);
            Tree.DrawEllipse(p, 105, 35, 13, 7);

            Tree.DrawEllipse(p, 73, 20, 13, 7);
            Tree.DrawEllipse(p, 93, 20, 13, 7);


            p = new Pen(Color.Brown, 15);
            Tree.DrawLine(p, new Point(170, 60), new Point(170, 105));

            p = new Pen(Color.Brown, 5);
            Tree.DrawLine(p, new Point(170, 90), new Point(190, 45));

            p = new Pen(Color.GreenYellow, 10);

            Tree.DrawEllipse(p, 170, 50, 13, 13);

            Tree.DrawEllipse(p, 140, 50, 13, 13);
            Tree.DrawEllipse(p, 155, 50, 13, 13);
            Tree.DrawEllipse(p, 185, 50, 13, 13);
            Tree.DrawEllipse(p, 200, 50, 13, 13);

            Tree.DrawEllipse(p, 145, 35, 13, 13);
            Tree.DrawEllipse(p, 165, 35, 13, 13);
            Tree.DrawEllipse(p, 185, 35, 13, 13);

            Tree.DrawEllipse(p, 153, 20, 13, 13);
            Tree.DrawEllipse(p, 173, 20, 13, 13);

            p = new Pen(Color.SeaGreen, 9);
            Tree.DrawEllipse(p, 130, 100, 10, 2);
            Tree.DrawEllipse(p, 120, 90, 10, 2);
            Tree.DrawEllipse(p, 110, 110, 10, 2);
            Tree.DrawEllipse(p, 53, 90, 10, 2);
            Tree.DrawEllipse(p, 200, 90, 10, 2);
            Tree.DrawEllipse(p, 20, 100, 10, 2);
            Tree.DrawEllipse(p, 200, 90, 10, 2);

            Tree.DrawEllipse(p, 225, 90, 10, 2);
            Tree.DrawEllipse(p, 95, 100, 10, 2);

        }

        public void drawTree2(Graphics Tree, Pen p)
        {
            Tree.DrawLine(p, new Point(90, 60), new Point(90, 105));

            p = new Pen(Color.Brown, 5);
            Tree.DrawLine(p, new Point(90, 80), new Point(105, 45));
            p = new Pen(Color.Brown, 3);
            Tree.DrawLine(p, new Point(90, 95), new Point(60, 45));

            p = new Pen(Color.Green, 10);
            Tree.DrawEllipse(p, 90, 50, 13, 7);

            Tree.DrawEllipse(p, 47, 50, 13, 7);
            Tree.DrawEllipse(p, 60, 50, 13, 7);
            Tree.DrawEllipse(p, 75, 50, 13, 7);
            Tree.DrawEllipse(p, 105, 50, 13, 7);
            Tree.DrawEllipse(p, 120, 50, 13, 7);


            Tree.DrawEllipse(p, 65, 35, 13, 7);
            Tree.DrawEllipse(p, 85, 35, 13, 7);
            Tree.DrawEllipse(p, 105, 35, 13, 7);

            Tree.DrawEllipse(p, 73, 20, 13, 7);
            Tree.DrawEllipse(p, 93, 20, 13, 7);


            p = new Pen(Color.Brown, 15);
            Tree.DrawLine(p, new Point(170, 60), new Point(170, 105));

            p = new Pen(Color.Brown, 5);
            Tree.DrawLine(p, new Point(170, 90), new Point(190, 45));

            p = new Pen(Color.Olive, 10);

            Tree.DrawEllipse(p, 170, 50, 13, 13);

            Tree.DrawEllipse(p, 140, 50, 13, 13);
            Tree.DrawEllipse(p, 155, 50, 13, 13);
            Tree.DrawEllipse(p, 185, 50, 13, 13);
            Tree.DrawEllipse(p, 200, 50, 13, 13);

            Tree.DrawEllipse(p, 145, 35, 13, 13);
            Tree.DrawEllipse(p, 165, 35, 13, 13);
            Tree.DrawEllipse(p, 185, 35, 13, 13);

            Tree.DrawEllipse(p, 153, 20, 13, 13);
            Tree.DrawEllipse(p, 173, 20, 13, 13);


            p = new Pen(Color.Brown, 15);
            Tree.DrawLine(p, new Point(300, 60), new Point(300, 105));
            p = new Pen(Color.Brown, 5);
            Tree.DrawLine(p, new Point(300, 90), new Point(320, 45));


            p = new Pen(Color.Green, 10);

            Tree.DrawEllipse(p, 300, 50, 13, 5);

            Tree.DrawEllipse(p, 270, 50, 13, 5);
            Tree.DrawEllipse(p, 285, 50, 13, 5);
            Tree.DrawEllipse(p, 315, 50, 13, 5);
            Tree.DrawEllipse(p, 330, 50, 13, 5);

            Tree.DrawEllipse(p, 275, 35, 13, 5);
            Tree.DrawEllipse(p, 295, 35, 13, 5);
            Tree.DrawEllipse(p, 315, 35, 13, 5);

            Tree.DrawEllipse(p, 283, 20, 13, 5);
            Tree.DrawEllipse(p, 303, 20, 13, 5);


            p = new Pen(Color.SeaGreen, 9);
            Tree.DrawEllipse(p, 130, 100, 10, 2);
            Tree.DrawEllipse(p, 120, 90, 10, 2);
            Tree.DrawEllipse(p, 110, 110, 10, 2);
            Tree.DrawEllipse(p, 53, 90, 10, 2);
            Tree.DrawEllipse(p, 200, 90, 10, 2);
            Tree.DrawEllipse(p, 20, 100, 10, 2);
            Tree.DrawEllipse(p, 200, 90, 10, 2);
            Tree.DrawEllipse(p, 250, 85, 10, 2);
            Tree.DrawEllipse(p, 225, 90, 10, 2);
            Tree.DrawEllipse(p, 95, 100, 10, 2);
            Tree.DrawEllipse(p, 250, 100, 10, 2);
            Tree.DrawEllipse(p, 235, 100, 10, 2);

            Tree.DrawEllipse(p, 305, 100, 10, 2);
            Tree.DrawEllipse(p, 315, 90, 10, 2);
        }

        public void drawTree1(Graphics Tree, Pen p)
        {
            Tree.DrawLine(p, new Point(90, 60), new Point(90, 105));

            p = new Pen(Color.Brown, 5);
            Tree.DrawLine(p, new Point(90, 80), new Point(105, 45));
            p = new Pen(Color.Brown, 3);
            Tree.DrawLine(p, new Point(90, 95), new Point(60, 45));

            p = new Pen(Color.Purple, 10);
            Tree.DrawEllipse(p, 90, 50, 13, 7);

            Tree.DrawEllipse(p, 47, 50, 13, 7);
            Tree.DrawEllipse(p, 60, 50, 13, 7);
            Tree.DrawEllipse(p, 75, 50, 13, 7);
            Tree.DrawEllipse(p, 105, 50, 13, 7);
            Tree.DrawEllipse(p, 120, 50, 13, 7);


            Tree.DrawEllipse(p, 65, 35, 13, 7);
            Tree.DrawEllipse(p, 85, 35, 13, 7);
            Tree.DrawEllipse(p, 105, 35, 13, 7);

            Tree.DrawEllipse(p, 73, 20, 13, 7);
            Tree.DrawEllipse(p, 93, 20, 13, 7);


            p = new Pen(Color.Brown, 15);
            Tree.DrawLine(p, new Point(170, 60), new Point(170, 105));

            p = new Pen(Color.Brown, 5);
            Tree.DrawLine(p, new Point(170, 90), new Point(190, 45));

            p = new Pen(Color.OrangeRed, 10);

            Tree.DrawEllipse(p, 170, 50, 13, 13);

            Tree.DrawEllipse(p, 140, 50, 13, 13);
            Tree.DrawEllipse(p, 155, 50, 13, 13);
            Tree.DrawEllipse(p, 185, 50, 13, 13);
            Tree.DrawEllipse(p, 200, 50, 13, 13);

            Tree.DrawEllipse(p, 145, 35, 13, 13);
            Tree.DrawEllipse(p, 165, 35, 13, 13);
            Tree.DrawEllipse(p, 185, 35, 13, 13);

            Tree.DrawEllipse(p, 153, 20, 13, 13);
            Tree.DrawEllipse(p, 173, 20, 13, 13);


            p = new Pen(Color.Brown, 15);
            Tree.DrawLine(p, new Point(300, 60), new Point(300, 105));
            p = new Pen(Color.Brown, 5);
            Tree.DrawLine(p, new Point(300, 90), new Point(320, 45));


            p = new Pen(Color.Orchid, 10);

            Tree.DrawEllipse(p, 300, 50, 13, 5);

            Tree.DrawEllipse(p, 270, 50, 13, 5);
            Tree.DrawEllipse(p, 285, 50, 13, 5);
            Tree.DrawEllipse(p, 315, 50, 13, 5);
            Tree.DrawEllipse(p, 330, 50, 13, 5);

            Tree.DrawEllipse(p, 275, 35, 13, 5);
            Tree.DrawEllipse(p, 295, 35, 13, 5);
            Tree.DrawEllipse(p, 315, 35, 13, 5);

            Tree.DrawEllipse(p, 283, 20, 13, 5);
            Tree.DrawEllipse(p, 303, 20, 13, 5);


            p = new Pen(Color.SeaGreen, 9);
            Tree.DrawEllipse(p, 130, 100, 10, 2);
            Tree.DrawEllipse(p, 120, 90, 10, 2);
            Tree.DrawEllipse(p, 110, 110, 10, 2);
            Tree.DrawEllipse(p, 53, 90, 10, 2);
            Tree.DrawEllipse(p, 200, 90, 10, 2);
            Tree.DrawEllipse(p, 20, 100, 10, 2);
            Tree.DrawEllipse(p, 200, 90, 10, 2);
            Tree.DrawEllipse(p, 250, 85, 10, 2);
            Tree.DrawEllipse(p, 225, 90, 10, 2);
            Tree.DrawEllipse(p, 95, 100, 10, 2);
            Tree.DrawEllipse(p, 250, 100, 10, 2);
            Tree.DrawEllipse(p, 235, 100, 10, 2);

            Tree.DrawEllipse(p, 305, 100, 10, 2);
            Tree.DrawEllipse(p, 315, 90, 10, 2);
        }
    }
}
