using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BO;
using DALL;
using ENTITY;

namespace ObjectMoving
{
    public partial class _2DCarInfo : Form
    {
        public _2DCarInfo()
        {
            InitializeComponent();

            CarBO objB = new CarBO();
            Cars DrawCar = new Cars();
            DrawCar = objB.getDrawInfo();

            style.Text = DrawCar.carstyle;
            name.Text = DrawCar.name;
            colour.Text = DrawCar.colour;
            move.Text = DrawCar.movingCapacity;
            control.Text = DrawCar.controllBy;
            stop.Text = DrawCar.stopBy;
            quality.Text = DrawCar.extraQuality;
        }



        private void Show2d_Paint(object sender, PaintEventArgs e)
        {
            Graphics carBody = Show2d.CreateGraphics();

            Pen g = new Pen(Color.Green, 3);
            carBody.DrawLine(g, new Point(100, 40), new Point(100, 75));//a,b
            carBody.DrawLine(g, new Point(100, 40), new Point(150, 40));//a,c
            carBody.DrawLine(g, new Point(150, 40), new Point(200, 10));//c,d
            carBody.DrawLine(g, new Point(200, 10), new Point(250, 10));//d,e
            carBody.DrawLine(g, new Point(250, 10), new Point(300, 40));//e,f
            carBody.DrawLine(g, new Point(300, 40), new Point(350, 40));//f,g
            carBody.DrawLine(g, new Point(350, 40), new Point(350, 75));//g,h
            carBody.DrawLine(g, new Point(100, 75), new Point(150, 75));
            carBody.DrawLine(g, new Point(300, 75), new Point(350, 75));

            carBody.DrawEllipse(g, 150, 55, 40, 40);
            carBody.DrawEllipse(g, 260, 55, 40, 40);

            carBody.DrawLine(g, new Point(150, 75), new Point(190, 75));//caka 1 --
            carBody.DrawLine(g, new Point(170, 55), new Point(170, 95));//caka 1 |

            carBody.DrawLine(g, new Point(260, 75), new Point(300, 75));//caka 2 --
            carBody.DrawLine(g, new Point(280, 55), new Point(280, 95));//caka 2 |

            carBody.DrawLine(g, new Point(190, 75), new Point(260, 75));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
