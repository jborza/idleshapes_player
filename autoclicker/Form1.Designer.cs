
namespace autoclicker
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label3;
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.timerClick = new System.Windows.Forms.Timer(this.components);
            this.textTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBoxCoords = new System.Windows.Forms.TextBox();
            this.checkBoxIdleShapes = new System.Windows.Forms.CheckBox();
            this.nudShapes = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudShapes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 18);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(112, 35);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(18, 77);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(112, 35);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // timerClick
            // 
            this.timerClick.Interval = 1000;
            this.timerClick.Tick += new System.EventHandler(this.timerClick_Tick);
            // 
            // textTime
            // 
            this.textTime.Location = new System.Drawing.Point(134, 225);
            this.textTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textTime.Name = "textTime";
            this.textTime.Size = new System.Drawing.Size(148, 26);
            this.textTime.TabIndex = 2;
            this.textTime.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 225);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "click time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "MS";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(208, 18);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "Set hotkey";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(384, 120);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 133);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(193, 24);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Move mouse randomly";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(18, 174);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(68, 24);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Click";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBoxCoords
            // 
            this.textBoxCoords.Location = new System.Drawing.Point(18, 278);
            this.textBoxCoords.Multiline = true;
            this.textBoxCoords.Name = "textBoxCoords";
            this.textBoxCoords.Size = new System.Drawing.Size(514, 254);
            this.textBoxCoords.TabIndex = 9;
            // 
            // checkBoxIdleShapes
            // 
            this.checkBoxIdleShapes.AutoSize = true;
            this.checkBoxIdleShapes.Location = new System.Drawing.Point(151, 174);
            this.checkBoxIdleShapes.Name = "checkBoxIdleShapes";
            this.checkBoxIdleShapes.Size = new System.Drawing.Size(147, 24);
            this.checkBoxIdleShapes.TabIndex = 10;
            this.checkBoxIdleShapes.Text = "play idle shapes";
            this.checkBoxIdleShapes.UseVisualStyleBackColor = true;
            // 
            // nudShapes
            // 
            this.nudShapes.Location = new System.Drawing.Point(384, 67);
            this.nudShapes.Name = "nudShapes";
            this.nudShapes.Size = new System.Drawing.Size(120, 26);
            this.nudShapes.TabIndex = 11;
            this.nudShapes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(314, 69);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(64, 20);
            label3.TabIndex = 12;
            label3.Text = "Shapes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 544);
            this.Controls.Add(label3);
            this.Controls.Add(this.nudShapes);
            this.Controls.Add(this.checkBoxIdleShapes);
            this.Controls.Add(this.textBoxCoords);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textTime);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "autoclicker";
            ((System.ComponentModel.ISupportInitialize)(this.nudShapes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Timer timerClick;
        private System.Windows.Forms.TextBox textTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBoxCoords;
        private System.Windows.Forms.CheckBox checkBoxIdleShapes;
        private System.Windows.Forms.NumericUpDown nudShapes;
    }
}

