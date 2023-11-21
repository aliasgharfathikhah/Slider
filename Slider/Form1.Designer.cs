namespace Slider
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBoxZoomOut = new PictureBox();
            pictureBoxZoomin = new PictureBox();
            labelBefore = new Label();
            labelNext = new Label();
            Browse = new Label();
            pictureBoxBefore = new PictureBox();
            pictureBoxNext = new PictureBox();
            pictureBoxAddImg = new PictureBox();
            pictureBoxImag = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxZoomOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxZoomin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBefore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNext).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAddImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImag).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(pictureBoxZoomOut);
            panel1.Controls.Add(pictureBoxZoomin);
            panel1.Controls.Add(labelBefore);
            panel1.Controls.Add(labelNext);
            panel1.Controls.Add(Browse);
            panel1.Controls.Add(pictureBoxBefore);
            panel1.Controls.Add(pictureBoxNext);
            panel1.Controls.Add(pictureBoxAddImg);
            panel1.Location = new Point(-2, -14);
            panel1.Name = "panel1";
            panel1.Size = new Size(102, 562);
            panel1.TabIndex = 0;
            // 
            // pictureBoxZoomOut
            // 
            pictureBoxZoomOut.Cursor = Cursors.Hand;
            pictureBoxZoomOut.Image = Properties.Resources.icons8_zoom_out_40;
            pictureBoxZoomOut.Location = new Point(50, 496);
            pictureBoxZoomOut.Name = "pictureBoxZoomOut";
            pictureBoxZoomOut.Size = new Size(40, 40);
            pictureBoxZoomOut.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxZoomOut.TabIndex = 7;
            pictureBoxZoomOut.TabStop = false;
            pictureBoxZoomOut.Visible = false;
            pictureBoxZoomOut.Click += pictureBoxZoomOut_Click;
            // 
            // pictureBoxZoomin
            // 
            pictureBoxZoomin.Cursor = Cursors.Hand;
            pictureBoxZoomin.Image = Properties.Resources.icons8_zoom_in_40;
            pictureBoxZoomin.Location = new Point(11, 460);
            pictureBoxZoomin.Name = "pictureBoxZoomin";
            pictureBoxZoomin.Size = new Size(40, 40);
            pictureBoxZoomin.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxZoomin.TabIndex = 6;
            pictureBoxZoomin.TabStop = false;
            pictureBoxZoomin.Visible = false;
            pictureBoxZoomin.Click += pictureBoxZoomin_Click;
            // 
            // labelBefore
            // 
            labelBefore.AutoSize = true;
            labelBefore.Location = new Point(20, 364);
            labelBefore.Name = "labelBefore";
            labelBefore.Size = new Size(53, 20);
            labelBefore.TabIndex = 5;
            labelBefore.Text = "Before";
            labelBefore.Visible = false;
            // 
            // labelNext
            // 
            labelNext.AutoSize = true;
            labelNext.Location = new Point(26, 242);
            labelNext.Name = "labelNext";
            labelNext.Size = new Size(40, 20);
            labelNext.TabIndex = 4;
            labelNext.Text = "Next";
            labelNext.Visible = false;
            // 
            // Browse
            // 
            Browse.AutoSize = true;
            Browse.Location = new Point(14, 114);
            Browse.Name = "Browse";
            Browse.Size = new Size(70, 20);
            Browse.TabIndex = 1;
            Browse.Text = "Browse ...";
            // 
            // pictureBoxBefore
            // 
            pictureBoxBefore.Cursor = Cursors.Hand;
            pictureBoxBefore.Image = (Image)resources.GetObject("pictureBoxBefore.Image");
            pictureBoxBefore.Location = new Point(1, 274);
            pictureBoxBefore.Name = "pictureBoxBefore";
            pictureBoxBefore.Size = new Size(94, 87);
            pictureBoxBefore.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBefore.TabIndex = 3;
            pictureBoxBefore.TabStop = false;
            pictureBoxBefore.Visible = false;
            pictureBoxBefore.Click += pictureBoxBefore_Click;
            // 
            // pictureBoxNext
            // 
            pictureBoxNext.Cursor = Cursors.Hand;
            pictureBoxNext.Image = (Image)resources.GetObject("pictureBoxNext.Image");
            pictureBoxNext.Location = new Point(1, 152);
            pictureBoxNext.Name = "pictureBoxNext";
            pictureBoxNext.Size = new Size(94, 87);
            pictureBoxNext.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxNext.TabIndex = 2;
            pictureBoxNext.TabStop = false;
            pictureBoxNext.Visible = false;
            pictureBoxNext.Click += pictureBoxNext_Click;
            // 
            // pictureBoxAddImg
            // 
            pictureBoxAddImg.Cursor = Cursors.Hand;
            pictureBoxAddImg.Image = Properties.Resources.icons8_add_file_96;
            pictureBoxAddImg.Location = new Point(1, 26);
            pictureBoxAddImg.Name = "pictureBoxAddImg";
            pictureBoxAddImg.Size = new Size(94, 85);
            pictureBoxAddImg.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAddImg.TabIndex = 1;
            pictureBoxAddImg.TabStop = false;
            pictureBoxAddImg.Click += pictureBoxAddImg_Click;
            // 
            // pictureBoxImag
            // 
            pictureBoxImag.Location = new Point(243, 65);
            pictureBoxImag.Name = "pictureBoxImag";
            pictureBoxImag.Size = new Size(535, 403);
            pictureBoxImag.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImag.TabIndex = 1;
            pictureBoxImag.TabStop = false;
            pictureBoxImag.Visible = false;
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(959, 539);
            Controls.Add(pictureBoxImag);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Slider";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxZoomOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxZoomin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBefore).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNext).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAddImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImag).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxAddImg;
        private PictureBox pictureBoxNext;
        private PictureBox pictureBoxBefore;
        private Label labelBefore;
        private Label labelNext;
        private Label Browse;
        private PictureBox pictureBoxZoomOut;
        private PictureBox pictureBoxZoomin;
        private PictureBox pictureBoxImag;
        private System.Windows.Forms.Timer timer1;
    }
}