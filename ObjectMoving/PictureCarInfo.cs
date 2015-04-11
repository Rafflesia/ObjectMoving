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
    public partial class PictureCarInfo : Form
    {
        public PictureCarInfo()
        {
            InitializeComponent();

            CarBO objB = new CarBO();
            Cars PictureCar = new Cars();
            PictureCar = objB.getPictureInfo();

            style.Text = PictureCar.carstyle;
            name.Text = PictureCar.name;
            colour.Text = PictureCar.colour;
            move.Text = PictureCar.movingCapacity;
            control.Text = PictureCar.controllBy;
            stop.Text = PictureCar.stopBy;
            quality.Text = PictureCar.extraQuality;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void control_Click(object sender, EventArgs e)
        {

        }
    }
}
