namespace Cinnamine
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.YPosTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.XPosTB = new System.Windows.Forms.TextBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.OutputLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PMinBTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PMinGTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PMinRTB = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PMaxBTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PMaxGTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PMaxRTB = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SMaxBTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SMaxGTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SMaxRTB = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SMinBTB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SMinGTB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SMinRTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.IntervalTB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.YPosTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.XPosTB);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(71)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Possition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y:";
            // 
            // YPosTB
            // 
            this.YPosTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.YPosTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(71)))));
            this.YPosTB.Location = new System.Drawing.Point(33, 59);
            this.YPosTB.Name = "YPosTB";
            this.YPosTB.Size = new System.Drawing.Size(79, 22);
            this.YPosTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "X:";
            // 
            // XPosTB
            // 
            this.XPosTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.XPosTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(71)))));
            this.XPosTB.Location = new System.Drawing.Point(33, 31);
            this.XPosTB.Name = "XPosTB";
            this.XPosTB.Size = new System.Drawing.Size(79, 22);
            this.XPosTB.TabIndex = 0;
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(74)))));
            this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBtn.Location = new System.Drawing.Point(178, 50);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(150, 35);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.OnStartBtnClick);
            // 
            // OutputLbl
            // 
            this.OutputLbl.AutoSize = true;
            this.OutputLbl.Location = new System.Drawing.Point(18, 366);
            this.OutputLbl.Name = "OutputLbl";
            this.OutputLbl.Size = new System.Drawing.Size(0, 17);
            this.OutputLbl.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.PMinBTB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.PMinGTB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.PMinRTB);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(71)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 138);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Primary Min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "B:";
            // 
            // PMinBTB
            // 
            this.PMinBTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.PMinBTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(71)))));
            this.PMinBTB.Location = new System.Drawing.Point(33, 90);
            this.PMinBTB.Name = "PMinBTB";
            this.PMinBTB.Size = new System.Drawing.Size(79, 22);
            this.PMinBTB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "G:";
            // 
            // PMinGTB
            // 
            this.PMinGTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.PMinGTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(71)))));
            this.PMinGTB.Location = new System.Drawing.Point(33, 59);
            this.PMinGTB.Name = "PMinGTB";
            this.PMinGTB.Size = new System.Drawing.Size(79, 22);
            this.PMinGTB.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "R:";
            // 
            // PMinRTB
            // 
            this.PMinRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.PMinRTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(71)))));
            this.PMinRTB.Location = new System.Drawing.Point(33, 31);
            this.PMinRTB.Name = "PMinRTB";
            this.PMinRTB.Size = new System.Drawing.Size(79, 22);
            this.PMinRTB.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.PMaxBTB);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.PMaxGTB);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.PMaxRTB);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(71)))));
            this.groupBox3.Location = new System.Drawing.Point(178, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 138);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Primary Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "B:";
            // 
            // PMaxBTB
            // 
            this.PMaxBTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.PMaxBTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(71)))));
            this.PMaxBTB.Location = new System.Drawing.Point(33, 90);
            this.PMaxBTB.Name = "PMaxBTB";
            this.PMaxBTB.Size = new System.Drawing.Size(79, 22);
            this.PMaxBTB.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "G:";
            // 
            // PMaxGTB
            // 
            this.PMaxGTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.PMaxGTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(71)))));
            this.PMaxGTB.Location = new System.Drawing.Point(33, 59);
            this.PMaxGTB.Name = "PMaxGTB";
            this.PMaxGTB.Size = new System.Drawing.Size(79, 22);
            this.PMaxGTB.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "R:";
            // 
            // PMaxRTB
            // 
            this.PMaxRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.PMaxRTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(71)))));
            this.PMaxRTB.Location = new System.Drawing.Point(33, 31);
            this.PMaxRTB.Name = "PMaxRTB";
            this.PMaxRTB.Size = new System.Drawing.Size(79, 22);
            this.PMaxRTB.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.SMaxBTB);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.SMaxGTB);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.SMaxRTB);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(71)))));
            this.groupBox4.Location = new System.Drawing.Point(178, 329);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(150, 138);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Secondary Max";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "B:";
            // 
            // SMaxBTB
            // 
            this.SMaxBTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.SMaxBTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(71)))));
            this.SMaxBTB.Location = new System.Drawing.Point(33, 90);
            this.SMaxBTB.Name = "SMaxBTB";
            this.SMaxBTB.Size = new System.Drawing.Size(79, 22);
            this.SMaxBTB.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "G:";
            // 
            // SMaxGTB
            // 
            this.SMaxGTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.SMaxGTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(71)))));
            this.SMaxGTB.Location = new System.Drawing.Point(33, 59);
            this.SMaxGTB.Name = "SMaxGTB";
            this.SMaxGTB.Size = new System.Drawing.Size(79, 22);
            this.SMaxGTB.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "R:";
            // 
            // SMaxRTB
            // 
            this.SMaxRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.SMaxRTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(71)))));
            this.SMaxRTB.Location = new System.Drawing.Point(33, 31);
            this.SMaxRTB.Name = "SMaxRTB";
            this.SMaxRTB.Size = new System.Drawing.Size(79, 22);
            this.SMaxRTB.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.SMinBTB);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.SMinGTB);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.SMinRTB);
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(71)))));
            this.groupBox5.Location = new System.Drawing.Point(12, 329);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(150, 138);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Secondary Min";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "B:";
            // 
            // SMinBTB
            // 
            this.SMinBTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.SMinBTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(71)))));
            this.SMinBTB.Location = new System.Drawing.Point(33, 90);
            this.SMinBTB.Name = "SMinBTB";
            this.SMinBTB.Size = new System.Drawing.Size(79, 22);
            this.SMinBTB.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "G:";
            // 
            // SMinGTB
            // 
            this.SMinGTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.SMinGTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(71)))));
            this.SMinGTB.Location = new System.Drawing.Point(33, 59);
            this.SMinGTB.Name = "SMinGTB";
            this.SMinGTB.Size = new System.Drawing.Size(79, 22);
            this.SMinGTB.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "R:";
            // 
            // SMinRTB
            // 
            this.SMinRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.SMinRTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(71)))));
            this.SMinRTB.Location = new System.Drawing.Point(33, 31);
            this.SMinRTB.Name = "SMinRTB";
            this.SMinRTB.Size = new System.Drawing.Size(79, 22);
            this.SMinRTB.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(74)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(178, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.SaveBtnClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(74)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(178, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.LoadBtnClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(71)))));
            this.label15.Location = new System.Drawing.Point(12, 478);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 17);
            this.label15.TabIndex = 12;
            this.label15.Text = "Interval:";
            // 
            // IntervalTB
            // 
            this.IntervalTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.IntervalTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(105)))), ((int)(((byte)(71)))));
            this.IntervalTB.Location = new System.Drawing.Point(76, 473);
            this.IntervalTB.Name = "IntervalTB";
            this.IntervalTB.Size = new System.Drawing.Size(86, 22);
            this.IntervalTB.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(341, 518);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.IntervalTB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.OutputLbl);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Cinnamine";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox YPosTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox XPosTB;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label OutputLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PMinBTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PMinGTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PMinRTB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PMaxBTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PMaxGTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PMaxRTB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SMaxBTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SMaxGTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox SMaxRTB;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox SMinBTB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox SMinGTB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox SMinRTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox IntervalTB;
    }
}

