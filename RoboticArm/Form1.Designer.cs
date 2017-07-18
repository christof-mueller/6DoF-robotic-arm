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
            this.baseSlider = new System.Windows.Forms.TrackBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.baseLabel = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.joint1Label = new System.Windows.Forms.Label();
            this.joint1Slider = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.baseSlider)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.joint1Slider)).BeginInit();
            this.SuspendLayout();
            // 
            // baseSlider
            // 
            this.baseSlider.Location = new System.Drawing.Point(104, 19);
            this.baseSlider.Maximum = 90;
            this.baseSlider.Minimum = -90;
            this.baseSlider.Name = "baseSlider";
            this.baseSlider.Size = new System.Drawing.Size(506, 45);
            this.baseSlider.TabIndex = 1;
            this.baseSlider.ValueChanged += new System.EventHandler(this.baseSlider_ValueChanged);
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
            this.tabPage2.Controls.Add(this.joint1Slider);
            this.tabPage2.Controls.Add(this.joint1Label);
            this.tabPage2.Controls.Add(this.baseLabel);
            this.tabPage2.Controls.Add(this.baseSlider);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(633, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manual Mode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseLabel.Location = new System.Drawing.Point(15, 19);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(68, 25);
            this.baseLabel.TabIndex = 2;
            this.baseLabel.Text = "Base";
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
            // joint1Label
            // 
            this.joint1Label.AutoSize = true;
            this.joint1Label.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joint1Label.Location = new System.Drawing.Point(15, 73);
            this.joint1Label.Name = "joint1Label";
            this.joint1Label.Size = new System.Drawing.Size(85, 25);
            this.joint1Label.TabIndex = 3;
            this.joint1Label.Text = "Joint1";
            // 
            // joint1Slider
            // 
            this.joint1Slider.Location = new System.Drawing.Point(104, 73);
            this.joint1Slider.Maximum = 90;
            this.joint1Slider.Minimum = -90;
            this.joint1Slider.Name = "joint1Slider";
            this.joint1Slider.Size = new System.Drawing.Size(506, 45);
            this.joint1Slider.TabIndex = 4;
            this.joint1Slider.ValueChanged += new System.EventHandler(this.joint1Slider_ValueChanged);
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
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.baseSlider)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.joint1Slider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TrackBar baseSlider;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.TrackBar joint1Slider;
        private System.Windows.Forms.Label joint1Label;
    }
}

