using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ENTITY;
using BO;

namespace ObjectMoving
{
    public partial class Welcome : Form
    {
        int choice_car_id;
        Cars objE = new Cars();
        CarBO objBO = new CarBO();
        public Welcome()
        {
            InitializeComponent();
        }
        public void setSpeed()
        {

        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            
        }

        private void DRun_Click(object sender, EventArgs e)
        {
            int s = objE.ESpeed = Convert.ToInt32(txtSpeed.Text);
            objBO.setSpeed(s);
            DrawCar p = new DrawCar();

            p.Show();
        }

        private void PRun_Click(object sender, EventArgs e)
        {
            int k = objE.ESpeed = Convert.ToInt32(txtSpeed.Text);
            objBO.setSpeed(k);
            FormView l = new FormView();
            //l.Height = 1220;
            //l.Width = 850;
            l.Show();
        }

        private void txtSpeed_TextChanged(object sender, EventArgs e)
        {
            String a = txtSpeed.Text;
            char[] b = a.ToCharArray();
            for (int i = 0; i < b.Length; i++)
            {
                if(b[i]<48 || b[i]>57)
                {
                    MessageBox.Show("Please Input an Integer Number as Speed");
                }
            }
        }

        private void DrawCar_Click(object sender, EventArgs e)
        {
            _2DCarInfo b=new _2DCarInfo();
            b.Show();
        }

        private void PicCar_Click(object sender, EventArgs e)
        {
            PictureCarInfo a = new PictureCarInfo();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pb1.BackgroundImage = Image.FromFile(@"F:\rafflesia\New folder (2)\car on road\ObjectMoving(1)\ObjectMoving\a1.jpg"); 
           
        }

        private void pb1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
