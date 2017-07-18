namespace RoboticArm
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
            this.joint1Slider = new System.Windows.Forms.TrackBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.joint3Position = new System.Windows.Forms.TextBox();
            this.joint2Position = new System.Windows.Forms.TextBox();
            this.joint1Position = new System.Windows.Forms.TextBox();
            this.joint2Slider = new System.Windows.Forms.TrackBar();
            this.joint2Label = new System.Windows.Forms.Label();
            this.joint3Slider = new System.Windows.Forms.TrackBar();
            this.joint3Label = new System.Windows.Forms.Label();
            this.joint1Label = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.joint1Slider)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.joint2Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joint3Slider)).BeginInit();
            this.SuspendLayout();
            // 
            // joint1Slider
            // 
            this.joint1Slider.Location = new System.Drawing.Point(247, 19);
            this.joint1Slider.Maximum = 67;
            this.joint1Slider.Minimum = -67;
            this.joint1Slider.Name = "joint1Slider";
            this.joint1Slider.Size = new System.Drawing.Size(326, 45);
            this.joint1Slider.TabIndex = 1;
            this.joint1Slider.ValueChanged += new System.EventHandler(this.joint1Slider_ValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(641, 379);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.joint3Position);
            this.tabPage2.Controls.Add(this.joint2Position);
            this.tabPage2.Controls.Add(this.joint1Position);
            this.tabPage2.Controls.Add(this.joint2Slider);
            this.tabPage2.Controls.Add(this.joint2Label);
            this.tabPage2.Controls.Add(this.joint3Slider);
            this.tabPage2.Controls.Add(this.joint3Label);
            this.tabPage2.Controls.Add(this.joint1Label);
            this.tabPage2.Controls.Add(this.joint1Slider);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(633, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manual Mode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // joint3Position
            // 
            this.joint3Position.Location = new System.Drawing.Point(579, 134);
            this.joint3Position.Name = "joint3Position";
            this.joint3Position.Size = new System.Drawing.Size(41, 20);
            this.joint3Position.TabIndex = 9;
            // 
            // joint2Position
            // 
            this.joint2Position.Location = new System.Drawing.Point(579, 80);
            this.joint2Position.Name = "joint2Position";
            this.joint2Position.Size = new System.Drawing.Size(41, 20);
            this.joint2Position.TabIndex = 8;
            // 
            // joint1Position
            // 
            this.joint1Position.Location = new System.Drawing.Point(579, 26);
            this.joint1Position.Name = "joint1Position";
            this.joint1Position.Size = new System.Drawing.Size(41, 20);
            this.joint1Position.TabIndex = 7;
            // 
            // joint2Slider
            // 
            this.joint2Slider.Location = new System.Drawing.Point(247, 73);
            this.joint2Slider.Maximum = 67;
            this.joint2Slider.Minimum = -67;
            this.joint2Slider.Name = "joint2Slider";
            this.joint2Slider.Size = new System.Drawing.Size(326, 45);
            this.joint2Slider.TabIndex = 4;
            this.joint2Slider.ValueChanged += new System.EventHandler(this.joint2Slider_ValueChanged);
            // 
            // joint2Label
            // 
            this.joint2Label.AutoSize = true;
            this.joint2Label.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joint2Label.Location = new System.Drawing.Point(15, 73);
            this.joint2Label.Name = "joint2Label";
            this.joint2Label.Size = new System.Drawing.Size(226, 25);
            this.joint2Label.TabIndex = 3;
            this.joint2Label.Text = "Joint 2 (Shoulder)";
            // 
            // joint3Slider
            // 
            this.joint3Slider.Location = new System.Drawing.Point(247, 127);
            this.joint3Slider.Maximum = 67;
            this.joint3Slider.Minimum = -67;
            this.joint3Slider.Name = "joint3Slider";
            this.joint3Slider.Size = new System.Drawing.Size(326, 45);
            this.joint3Slider.TabIndex = 6;
            this.joint3Slider.ValueChanged += new System.EventHandler(this.joint3Slider_ValueChanged);
            // 
            // joint3Label
            // 
            this.joint3Label.AutoSize = true;
            this.joint3Label.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joint3Label.Location = new System.Drawing.Point(15, 127);
            this.joint3Label.Name = "joint3Label";
            this.joint3Label.Size = new System.Drawing.Size(185, 25);
            this.joint3Label.TabIndex = 5;
            this.joint3Label.Text = "Joint3 (Elbow)";
            // 
            // joint1Label
            // 
            this.joint1Label.AutoSize = true;
            this.joint1Label.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joint1Label.Location = new System.Drawing.Point(15, 19);
            this.joint1Label.Name = "joint1Label";
            this.joint1Label.Size = new System.Drawing.Size(177, 25);
            this.joint1Label.TabIndex = 2;
            this.joint1Label.Text = "Joint 1 (Base)";
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(12, 397);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(614, 96);
            this.logBox.TabIndex = 3;
            this.logBox.Text = "";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(624, 397);
            this.clearButton.Name = "clearButton";
            this.clearButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clearButton.Size = new System.Drawing.Size(25, 95);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "C L E A R";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 504);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "RobiticArm";
            ((System.ComponentModel.ISupportInitialize)(this.joint1Slider)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.joint2Slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joint3Slider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TrackBar joint1Slider;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label joint1Label;
        private System.Windows.Forms.TrackBar joint2Slider;
        private System.Windows.Forms.Label joint2Label;
        private System.Windows.Forms.TrackBar joint3Slider;
        private System.Windows.Forms.Label joint3Label;
        private System.Windows.Forms.TextBox joint3Position;
        private System.Windows.Forms.TextBox joint2Position;
        private System.Windows.Forms.TextBox joint1Position;
    }
}

