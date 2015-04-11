namespace ObjectMoving
{
    partial class Welcome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.DrawCar = new System.Windows.Forms.Button();
            this.PicCar = new System.Windows.Forms.Button();
            this.PRun = new System.Windows.Forms.Button();
            this.DRun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(167, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "       Welcome to Car Project";
            // 
            // txtSpeed
            // 
            this.txtSpeed.BackColor = System.Drawing.Color.Gray;
            this.txtSpeed.HideSelection = false;
            this.txtSpeed.Location = new System.Drawing.Point(217, 317);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(132, 21);
            this.txtSpeed.TabIndex = 1;
            this.txtSpeed.TextChanged += new System.EventHandler(this.txtSpeed_TextChanged);
            // 
            // DrawCar
            // 
            this.DrawCar.BackColor = System.Drawing.Color.Transparent;
            this.DrawCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrawCar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DrawCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawCar.ForeColor = System.Drawing.Color.Black;
            this.DrawCar.Location = new System.Drawing.Point(51, 41);
            this.DrawCar.Name = "DrawCar";
            this.DrawCar.Size = new System.Drawing.Size(92, 40);
            this.DrawCar.TabIndex = 4;
            this.DrawCar.Text = "2D Car Info";
            this.DrawCar.UseVisualStyleBackColor = false;
            this.DrawCar.Click += new System.EventHandler(this.DrawCar_Click);
            // 
            // PicCar
            // 
            this.PicCar.BackColor = System.Drawing.Color.Transparent;
            this.PicCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicCar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PicCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PicCar.ForeColor = System.Drawing.Color.Black;
            this.PicCar.Location = new System.Drawing.Point(393, 41);
            this.PicCar.Name = "PicCar";
            this.PicCar.Size = new System.Drawing.Size(102, 40);
            this.PicCar.TabIndex = 5;
            this.PicCar.Text = "Red Car Info";
            this.PicCar.UseVisualStyleBackColor = false;
            this.PicCar.Click += new System.EventHandler(this.PicCar_Click);
            // 
            // PRun
            // 
            this.PRun.BackColor = System.Drawing.Color.Transparent;
            this.PRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PRun.ForeColor = System.Drawing.Color.Black;
            this.PRun.Location = new System.Drawing.Point(347, 347);
            this.PRun.Name = "PRun";
            this.PRun.Size = new System.Drawing.Size(103, 28);
            this.PRun.TabIndex = 7;
            this.PRun.Text = "Red Car Run";
            this.PRun.UseVisualStyleBackColor = false;
            this.PRun.Click += new System.EventHandler(this.PRun_Click);
            // 
            // DRun
            // 
            this.DRun.BackColor = System.Drawing.Color.Transparent;
            this.DRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DRun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DRun.ForeColor = System.Drawing.Color.Black;
            this.DRun.Location = new System.Drawing.Point(94, 345);
            this.DRun.Name = "DRun";
            this.DRun.Size = new System.Drawing.Size(98, 28);
            this.DRun.TabIndex = 6;
            this.DRun.Text = "2D Car Run";
            this.DRun.UseVisualStyleBackColor = false;
            this.DRun.Click += new System.EventHandler(this.DRun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(228, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Set Car Speed";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ObjectMoving.Properties.Resources.Kids_Car_Toy_Photography_4_Wallpaper;
            this.ClientSize = new System.Drawing.Size(614, 425);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PRun);
            this.Controls.Add(this.DRun);
            this.Controls.Add(this.PicCar);
            this.Controls.Add(this.DrawCar);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Button DrawCar;
        private System.Windows.Forms.Button PicCar;
        private System.Windows.Forms.Button PRun;
        private System.Windows.Forms.Button DRun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
    }
}