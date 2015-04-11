using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BO;
using ENTITY;
using System.Media;


namespace ObjectMoving
{
    public partial class DrawCar : Form
    {
        CarBO objB = new CarBO();
        Cars objE = new Cars();
        Pen p;
        Brush b;
        Pen q = new Pen(Color.Red, 4);
        enum Position
        {
            Left, Right, Up, Down, Stop
        }

        private int X;
        private int Y;
        private Position objPosition;
        private int _color = 0;
        private int Uspeed;
        int move_direction = 1;


        public DrawCar()
        {
            InitializeComponent();

            X = 7;
            Y = 350;
            objPosition = Position.Left;

            Uspeed = objE.ESpeed = objB.getSpeed();
            this.speedshow.Text = Convert.ToString(Uspeed) + " ms^-1";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics carBody = panel1.CreateGraphics();
            Graphics Wheel = panel1.CreateGraphics();
            objE.drawCar(carBody, Wheel, p, move_direction, _color, panel1);

        }
        private void FormView_Paint(object sender, PaintEventArgs e)
        {
            panel1.Location = new Point(X, Y);
            panel2.Location = new Point(4, 207);
            panel3.Location = new Point(773, 474);
            panel4.Location = new Point(1119, 474);
            panel5.Location = new Point(370, 162);

        }

        private void tmrMoving_Tick(object sender, EventArgs e)
        {


            _color += 1;
            //objB.timer(_color, objPosition, X, Y, Uspeed);
            
             if (objPosition == Position.Right)
             {
               
                 X += Uspeed;
                 if (X >= 1000)
                 {
                     objPosition = Position.Stop;
                 }
                 else if ((X >= 350)&&(X<=370)&&(Y>=175))
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
                 else if ((Y <=67)||(Y>=350))
                 {
                     objPosition = Position.Stop;
                 }
               
             }
            
             else if (objPosition == Position.Down)
             {
                 X = 500;
                 Y += Uspeed;

                 if (Y >=400)
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

        private void FormView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                move_direction = 1;
                objPosition = Position.Left;
            }
            else if (e.KeyCode == Keys.Right)
            {
                objPosition = Position.Right;
                move_direction = 2; // will be used to reverse the direction of car
            }
            else if (e.KeyCode == Keys.Space)
            {
                objPosition = Position.Stop;
                //q.Dispose();
                timerColour.Stop();

            }
            else if (e.KeyCode == Keys.Up)
            {
                objPosition = Position.Up;

                move_direction = 3;

            }
            else if (e.KeyCode == Keys.Down)
            {
                objPosition = Position.Down;

                move_direction = 4;

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

            Graphics Tree = panel2.CreateGraphics();
            p = new Pen(Color.Brown, 15);
            objE.drawTree1(Tree, p);
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Graphics Tree = panel3.CreateGraphics();
            p = new Pen(Color.Brown, 15);
            objE.drawTree2(Tree, p);
        }



        private void panel4_Paint(object sender, PaintEventArgs e)
        {

            Graphics Tree = panel4.CreateGraphics();
            p = new Pen(Color.Brown, 15);
            objE.drawTree3(Tree, p);
        }


        private void panel5_Paint(object sender, PaintEventArgs e)
        {

            Graphics Tree = panel5.CreateGraphics();
            p = new Pen(Color.Cornsilk, 3);
            objE.drawTree4(Tree, p);

        }

        private void FormView_Load(object sender, EventArgs e)
        {

        }

        private void timerColour_Tick(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

    }
}
