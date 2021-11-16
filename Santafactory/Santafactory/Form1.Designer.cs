
namespace Santafactory
{
    partial class mainPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.createtimer = new System.Windows.Forms.Timer(this.components);
            this.conventorytimer = new System.Windows.Forms.Timer(this.components);
            this.btn_car = new System.Windows.Forms.Button();
            this.btn_ball = new System.Windows.Forms.Button();
            this.lbl_next = new System.Windows.Forms.Label();
            this.btn_color = new System.Windows.Forms.Button();
            this.btn_present = new System.Windows.Forms.Button();
            this.btn_boxcolor = new System.Windows.Forms.Button();
            this.btn_ribboncolor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(0, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 301);
            this.panel1.TabIndex = 0;
            // 
            // createtimer
            // 
            this.createtimer.Enabled = true;
            this.createtimer.Interval = 3000;
            this.createtimer.Tick += new System.EventHandler(this.createtimer_Tick);
            // 
            // conventorytimer
            // 
            this.conventorytimer.Enabled = true;
            this.conventorytimer.Interval = 10;
            this.conventorytimer.Tick += new System.EventHandler(this.conventorytimer_Tick);
            // 
            // btn_car
            // 
            this.btn_car.Location = new System.Drawing.Point(29, 13);
            this.btn_car.Name = "btn_car";
            this.btn_car.Size = new System.Drawing.Size(75, 23);
            this.btn_car.TabIndex = 1;
            this.btn_car.Text = "Car";
            this.btn_car.UseVisualStyleBackColor = true;
            this.btn_car.Click += new System.EventHandler(this.btn_car_Click);
            // 
            // btn_ball
            // 
            this.btn_ball.Location = new System.Drawing.Point(121, 13);
            this.btn_ball.Name = "btn_ball";
            this.btn_ball.Size = new System.Drawing.Size(75, 23);
            this.btn_ball.TabIndex = 2;
            this.btn_ball.Text = "Ball";
            this.btn_ball.UseVisualStyleBackColor = true;
            this.btn_ball.Click += new System.EventHandler(this.btn_ball_Click);
            // 
            // lbl_next
            // 
            this.lbl_next.AutoSize = true;
            this.lbl_next.Location = new System.Drawing.Point(348, 13);
            this.lbl_next.Name = "lbl_next";
            this.lbl_next.Size = new System.Drawing.Size(29, 13);
            this.lbl_next.TabIndex = 3;
            this.lbl_next.Text = "Next";
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.Color.Blue;
            this.btn_color.Location = new System.Drawing.Point(132, 42);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(53, 23);
            this.btn_color.TabIndex = 4;
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_present
            // 
            this.btn_present.Location = new System.Drawing.Point(210, 13);
            this.btn_present.Name = "btn_present";
            this.btn_present.Size = new System.Drawing.Size(75, 23);
            this.btn_present.TabIndex = 5;
            this.btn_present.Text = "Present";
            this.btn_present.UseVisualStyleBackColor = true;
            this.btn_present.Click += new System.EventHandler(this.btn_present_Click);
            // 
            // btn_boxcolor
            // 
            this.btn_boxcolor.BackColor = System.Drawing.Color.Red;
            this.btn_boxcolor.Location = new System.Drawing.Point(221, 42);
            this.btn_boxcolor.Name = "btn_boxcolor";
            this.btn_boxcolor.Size = new System.Drawing.Size(53, 23);
            this.btn_boxcolor.TabIndex = 6;
            this.btn_boxcolor.UseVisualStyleBackColor = false;
            this.btn_boxcolor.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_ribboncolor
            // 
            this.btn_ribboncolor.BackColor = System.Drawing.Color.Yellow;
            this.btn_ribboncolor.Location = new System.Drawing.Point(221, 71);
            this.btn_ribboncolor.Name = "btn_ribboncolor";
            this.btn_ribboncolor.Size = new System.Drawing.Size(53, 23);
            this.btn_ribboncolor.TabIndex = 7;
            this.btn_ribboncolor.UseVisualStyleBackColor = false;
            this.btn_ribboncolor.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // mainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ribboncolor);
            this.Controls.Add(this.btn_boxcolor);
            this.Controls.Add(this.btn_present);
            this.Controls.Add(this.btn_color);
            this.Controls.Add(this.lbl_next);
            this.Controls.Add(this.btn_ball);
            this.Controls.Add(this.btn_car);
            this.Controls.Add(this.panel1);
            this.Name = "mainPanel";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer createtimer;
        private System.Windows.Forms.Timer conventorytimer;
        private System.Windows.Forms.Button btn_car;
        private System.Windows.Forms.Button btn_ball;
        private System.Windows.Forms.Label lbl_next;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button btn_present;
        private System.Windows.Forms.Button btn_boxcolor;
        private System.Windows.Forms.Button btn_ribboncolor;
    }
}

