namespace SImpleSystemSpecs
{
    partial class Form1
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
            System.Windows.Forms.Label cpu_l3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mboard_serial = new System.Windows.Forms.Label();
            this.mboard_model = new System.Windows.Forms.Label();
            this.mboard_maker = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.ram_serial = new System.Windows.Forms.Label();
            this.ram_speed = new System.Windows.Forms.Label();
            this.ram_maker = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cpu_l2 = new System.Windows.Forms.Label();
            this.cpu_logical = new System.Windows.Forms.Label();
            this.cpuimg = new System.Windows.Forms.PictureBox();
            this.cpu_maxcore = new System.Windows.Forms.Label();
            this.cpu_model = new System.Windows.Forms.Label();
            this.cpu_maker = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cpu_level3 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.gpu_driver = new System.Windows.Forms.Label();
            this.gpu_mem = new System.Windows.Forms.Label();
            this.gpu_name = new System.Windows.Forms.Label();
            cpu_l3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuimg)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cpu_l3
            // 
            cpu_l3.AutoSize = true;
            cpu_l3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cpu_l3.Location = new System.Drawing.Point(16, 256);
            cpu_l3.Name = "cpu_l3";
            cpu_l3.Size = new System.Drawing.Size(0, 24);
            cpu_l3.TabIndex = 10;
            cpu_l3.Click += new System.EventHandler(this.cpu_l3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(675, 312);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(23, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(648, 304);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Intro";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "<---- Click the tabs for specs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Simple System Info";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mboard_serial);
            this.tabPage2.Controls.Add(this.mboard_model);
            this.tabPage2.Controls.Add(this.mboard_maker);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(23, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(648, 304);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MotherBoard";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // mboard_serial
            // 
            this.mboard_serial.AutoSize = true;
            this.mboard_serial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mboard_serial.Location = new System.Drawing.Point(6, 141);
            this.mboard_serial.Name = "mboard_serial";
            this.mboard_serial.Size = new System.Drawing.Size(131, 24);
            this.mboard_serial.TabIndex = 3;
            this.mboard_serial.Text = "Serial Number";
            this.mboard_serial.Click += new System.EventHandler(this.label4_Click);
            // 
            // mboard_model
            // 
            this.mboard_model.AutoSize = true;
            this.mboard_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mboard_model.Location = new System.Drawing.Point(7, 104);
            this.mboard_model.Name = "mboard_model";
            this.mboard_model.Size = new System.Drawing.Size(63, 24);
            this.mboard_model.TabIndex = 2;
            this.mboard_model.Text = "Model";
            // 
            // mboard_maker
            // 
            this.mboard_maker.AutoSize = true;
            this.mboard_maker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mboard_maker.Location = new System.Drawing.Point(7, 65);
            this.mboard_maker.Name = "mboard_maker";
            this.mboard_maker.Size = new System.Drawing.Size(62, 24);
            this.mboard_maker.TabIndex = 1;
            this.mboard_maker.Text = "Maker";
            this.mboard_maker.Click += new System.EventHandler(this.mboard_maker_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Motherboard Specs";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.ram_serial);
            this.tabPage3.Controls.Add(this.ram_speed);
            this.tabPage3.Controls.Add(this.ram_maker);
            this.tabPage3.Location = new System.Drawing.Point(23, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(648, 304);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Memory";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label5.Location = new System.Drawing.Point(4, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Memory Specs";
            // 
            // ram_serial
            // 
            this.ram_serial.AutoSize = true;
            this.ram_serial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ram_serial.Location = new System.Drawing.Point(5, 148);
            this.ram_serial.Name = "ram_serial";
            this.ram_serial.Size = new System.Drawing.Size(131, 24);
            this.ram_serial.TabIndex = 6;
            this.ram_serial.Text = "Serial Number";
            // 
            // ram_speed
            // 
            this.ram_speed.AutoSize = true;
            this.ram_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ram_speed.Location = new System.Drawing.Point(6, 111);
            this.ram_speed.Name = "ram_speed";
            this.ram_speed.Size = new System.Drawing.Size(63, 24);
            this.ram_speed.TabIndex = 5;
            this.ram_speed.Text = "Model";
            // 
            // ram_maker
            // 
            this.ram_maker.AutoSize = true;
            this.ram_maker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ram_maker.Location = new System.Drawing.Point(6, 72);
            this.ram_maker.Name = "ram_maker";
            this.ram_maker.Size = new System.Drawing.Size(62, 24);
            this.ram_maker.TabIndex = 4;
            this.ram_maker.Text = "Maker";
            this.ram_maker.Click += new System.EventHandler(this.ram_maker_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cpu_level3);
            this.tabPage4.Controls.Add(cpu_l3);
            this.tabPage4.Controls.Add(this.cpu_l2);
            this.tabPage4.Controls.Add(this.cpu_logical);
            this.tabPage4.Controls.Add(this.cpuimg);
            this.tabPage4.Controls.Add(this.cpu_maxcore);
            this.tabPage4.Controls.Add(this.cpu_model);
            this.tabPage4.Controls.Add(this.cpu_maker);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(23, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(648, 304);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "CPU";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // cpu_l2
            // 
            this.cpu_l2.AutoSize = true;
            this.cpu_l2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_l2.Location = new System.Drawing.Point(16, 221);
            this.cpu_l2.Name = "cpu_l2";
            this.cpu_l2.Size = new System.Drawing.Size(90, 24);
            this.cpu_l2.TabIndex = 9;
            this.cpu_l2.Text = "L2 Cache";
            // 
            // cpu_logical
            // 
            this.cpu_logical.AutoSize = true;
            this.cpu_logical.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_logical.Location = new System.Drawing.Point(16, 181);
            this.cpu_logical.Name = "cpu_logical";
            this.cpu_logical.Size = new System.Drawing.Size(169, 24);
            this.cpu_logical.TabIndex = 8;
            this.cpu_logical.Text = "Logical Processors";
            this.cpu_logical.Click += new System.EventHandler(this.label5_Click);
            // 
            // cpuimg
            // 
            this.cpuimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cpuimg.Location = new System.Drawing.Point(498, 5);
            this.cpuimg.Name = "cpuimg";
            this.cpuimg.Size = new System.Drawing.Size(142, 61);
            this.cpuimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cpuimg.TabIndex = 7;
            this.cpuimg.TabStop = false;
            this.cpuimg.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // cpu_maxcore
            // 
            this.cpu_maxcore.AutoSize = true;
            this.cpu_maxcore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_maxcore.Location = new System.Drawing.Point(16, 146);
            this.cpu_maxcore.Name = "cpu_maxcore";
            this.cpu_maxcore.Size = new System.Drawing.Size(101, 24);
            this.cpu_maxcore.TabIndex = 6;
            this.cpu_maxcore.Text = "Max Cores";
            // 
            // cpu_model
            // 
            this.cpu_model.AutoSize = true;
            this.cpu_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_model.Location = new System.Drawing.Point(16, 110);
            this.cpu_model.Name = "cpu_model";
            this.cpu_model.Size = new System.Drawing.Size(63, 24);
            this.cpu_model.TabIndex = 5;
            this.cpu_model.Text = "Model";
            // 
            // cpu_maker
            // 
            this.cpu_maker.AutoSize = true;
            this.cpu_maker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_maker.Location = new System.Drawing.Point(16, 74);
            this.cpu_maker.Name = "cpu_maker";
            this.cpu_maker.Size = new System.Drawing.Size(62, 24);
            this.cpu_maker.TabIndex = 4;
            this.cpu_maker.Text = "Maker";
            this.cpu_maker.Click += new System.EventHandler(this.cpu_maker_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label4.Location = new System.Drawing.Point(6, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "CPU Specs";
            // 
            // cpu_level3
            // 
            this.cpu_level3.AutoSize = true;
            this.cpu_level3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_level3.Location = new System.Drawing.Point(16, 256);
            this.cpu_level3.Name = "cpu_level3";
            this.cpu_level3.Size = new System.Drawing.Size(90, 24);
            this.cpu_level3.TabIndex = 11;
            this.cpu_level3.Text = "L3 Cache";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.gpu_driver);
            this.tabPage5.Controls.Add(this.gpu_mem);
            this.tabPage5.Controls.Add(this.gpu_name);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Location = new System.Drawing.Point(23, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(648, 304);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "GPU";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label6.Location = new System.Drawing.Point(6, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "GPU Specs";
            // 
            // gpu_driver
            // 
            this.gpu_driver.AutoSize = true;
            this.gpu_driver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpu_driver.Location = new System.Drawing.Point(6, 172);
            this.gpu_driver.Name = "gpu_driver";
            this.gpu_driver.Size = new System.Drawing.Size(129, 24);
            this.gpu_driver.TabIndex = 11;
            this.gpu_driver.Text = "Driver Version";
            // 
            // gpu_mem
            // 
            this.gpu_mem.AutoSize = true;
            this.gpu_mem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpu_mem.Location = new System.Drawing.Point(7, 128);
            this.gpu_mem.Name = "gpu_mem";
            this.gpu_mem.Size = new System.Drawing.Size(120, 24);
            this.gpu_mem.TabIndex = 10;
            this.gpu_mem.Text = "Memory Size";
            // 
            // gpu_name
            // 
            this.gpu_name.AutoSize = true;
            this.gpu_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpu_name.Location = new System.Drawing.Point(7, 80);
            this.gpu_name.Name = "gpu_name";
            this.gpu_name.Size = new System.Drawing.Size(61, 24);
            this.gpu_name.TabIndex = 9;
            this.gpu_name.Text = "Name";
            this.gpu_name.Click += new System.EventHandler(this.gpu_name_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(675, 312);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Simple Memory Specs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuimg)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mboard_maker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mboard_model;
        private System.Windows.Forms.Label mboard_serial;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox cpuimg;
        private System.Windows.Forms.Label cpu_maxcore;
        private System.Windows.Forms.Label cpu_model;
        private System.Windows.Forms.Label cpu_maker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cpu_logical;
        private System.Windows.Forms.Label ram_serial;
        private System.Windows.Forms.Label ram_speed;
        private System.Windows.Forms.Label ram_maker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cpu_l2;
        private System.Windows.Forms.Label cpu_level3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label gpu_driver;
        private System.Windows.Forms.Label gpu_mem;
        private System.Windows.Forms.Label gpu_name;
    }
}

