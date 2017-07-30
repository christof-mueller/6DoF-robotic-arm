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
            this.positionInput_0 = new System.Windows.Forms.TrackBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.manualPage = new System.Windows.Forms.TabPage();
            this.positionOutput_5 = new System.Windows.Forms.TextBox();
            this.positionInput_5 = new System.Windows.Forms.TrackBar();
            this.joint6Label = new System.Windows.Forms.Label();
            this.positionOutput_4 = new System.Windows.Forms.TextBox();
            this.positionInput_4 = new System.Windows.Forms.TrackBar();
            this.joint5Label = new System.Windows.Forms.Label();
            this.positionOutput_3 = new System.Windows.Forms.TextBox();
            this.positionInput_3 = new System.Windows.Forms.TrackBar();
            this.joint4Label = new System.Windows.Forms.Label();
            this.positionOutput_2 = new System.Windows.Forms.TextBox();
            this.positionOutput_1 = new System.Windows.Forms.TextBox();
            this.positionOutput_0 = new System.Windows.Forms.TextBox();
            this.positionInput_1 = new System.Windows.Forms.TrackBar();
            this.joint2Label = new System.Windows.Forms.Label();
            this.positionInput_2 = new System.Windows.Forms.TrackBar();
            this.joint3Label = new System.Windows.Forms.Label();
            this.joint1Label = new System.Windows.Forms.Label();
            this.automaticPage = new System.Windows.Forms.TabPage();
            this.homeButton = new System.Windows.Forms.Button();
            this.settingsPage = new System.Windows.Forms.TabPage();
            this.HardwareSimulationModeInput = new System.Windows.Forms.CheckBox();
            this.velocityInput_5 = new System.Windows.Forms.NumericUpDown();
            this.joint6ServoSpeedLabel = new System.Windows.Forms.Label();
            this.velocityInput_4 = new System.Windows.Forms.NumericUpDown();
            this.joint5ServoSpeedLabel = new System.Windows.Forms.Label();
            this.velocityInput_3 = new System.Windows.Forms.NumericUpDown();
            this.joint4ServoSpeedLabel = new System.Windows.Forms.Label();
            this.velocityInput_2 = new System.Windows.Forms.NumericUpDown();
            this.joint3ServoSpeedLabel = new System.Windows.Forms.Label();
            this.velocityInput_1 = new System.Windows.Forms.NumericUpDown();
            this.joint2ServoSpeedLabel = new System.Windows.Forms.Label();
            this.velocityInput_0 = new System.Windows.Forms.NumericUpDown();
            this.joint1ServoSpeedLabel = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.RunInitInput = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.positionInput_0)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.manualPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionInput_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionInput_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionInput_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionInput_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionInput_2)).BeginInit();
            this.automaticPage.SuspendLayout();
            this.settingsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.velocityInput_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocityInput_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocityInput_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocityInput_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocityInput_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocityInput_0)).BeginInit();
            this.SuspendLayout();
            // 
            // positionInput_0
            // 
            this.positionInput_0.Location = new System.Drawing.Point(247, 19);
            this.positionInput_0.Maximum = 67;
            this.positionInput_0.Minimum = -67;
            this.positionInput_0.Name = "positionInput_0";
            this.positionInput_0.Size = new System.Drawing.Size(326, 45);
            this.positionInput_0.TabIndex = 1;
            this.positionInput_0.ValueChanged += new System.EventHandler(this.PositionInput_ValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.manualPage);
            this.tabControl1.Controls.Add(this.automaticPage);
            this.tabControl1.Controls.Add(this.settingsPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(637, 379);
            this.tabControl1.TabIndex = 2;
            // 
            // manualPage
            // 
            this.manualPage.Controls.Add(this.positionOutput_5);
            this.manualPage.Controls.Add(this.positionInput_5);
            this.manualPage.Controls.Add(this.joint6Label);
            this.manualPage.Controls.Add(this.positionOutput_4);
            this.manualPage.Controls.Add(this.positionInput_4);
            this.manualPage.Controls.Add(this.joint5Label);
            this.manualPage.Controls.Add(this.positionOutput_3);
            this.manualPage.Controls.Add(this.positionInput_3);
            this.manualPage.Controls.Add(this.joint4Label);
            this.manualPage.Controls.Add(this.positionOutput_2);
            this.manualPage.Controls.Add(this.positionOutput_1);
            this.manualPage.Controls.Add(this.positionOutput_0);
            this.manualPage.Controls.Add(this.positionInput_1);
            this.manualPage.Controls.Add(this.joint2Label);
            this.manualPage.Controls.Add(this.positionInput_2);
            this.manualPage.Controls.Add(this.joint3Label);
            this.manualPage.Controls.Add(this.joint1Label);
            this.manualPage.Controls.Add(this.positionInput_0);
            this.manualPage.Location = new System.Drawing.Point(4, 22);
            this.manualPage.Name = "manualPage";
            this.manualPage.Padding = new System.Windows.Forms.Padding(3);
            this.manualPage.Size = new System.Drawing.Size(629, 353);
            this.manualPage.TabIndex = 1;
            this.manualPage.Text = "Manual Mode";
            this.manualPage.UseVisualStyleBackColor = true;
            // 
            // positionOutput_5
            // 
            this.positionOutput_5.Location = new System.Drawing.Point(579, 308);
            this.positionOutput_5.Name = "positionOutput_5";
            this.positionOutput_5.Size = new System.Drawing.Size(41, 20);
            this.positionOutput_5.TabIndex = 18;
            // 
            // positionInput_5
            // 
            this.positionInput_5.Location = new System.Drawing.Point(247, 301);
            this.positionInput_5.Maximum = 67;
            this.positionInput_5.Minimum = -67;
            this.positionInput_5.Name = "positionInput_5";
            this.positionInput_5.Size = new System.Drawing.Size(326, 45);
            this.positionInput_5.TabIndex = 17;
            this.positionInput_5.ValueChanged += new System.EventHandler(this.PositionInput_ValueChanged);
            // 
            // joint6Label
            // 
            this.joint6Label.AutoSize = true;
            this.joint6Label.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joint6Label.Location = new System.Drawing.Point(15, 301);
            this.joint6Label.Name = "joint6Label";
            this.joint6Label.Size = new System.Drawing.Size(109, 25);
            this.joint6Label.TabIndex = 16;
            this.joint6Label.Text = "WJoint6";
            // 
            // positionOutput_4
            // 
            this.positionOutput_4.Location = new System.Drawing.Point(579, 257);
            this.positionOutput_4.Name = "positionOutput_4";
            this.positionOutput_4.Size = new System.Drawing.Size(41, 20);
            this.positionOutput_4.TabIndex = 15;
            // 
            // positionInput_4
            // 
            this.positionInput_4.Location = new System.Drawing.Point(247, 250);
            this.positionInput_4.Maximum = 67;
            this.positionInput_4.Minimum = -67;
            this.positionInput_4.Name = "positionInput_4";
            this.positionInput_4.Size = new System.Drawing.Size(326, 45);
            this.positionInput_4.TabIndex = 14;
            this.positionInput_4.ValueChanged += new System.EventHandler(this.PositionInput_ValueChanged);
            // 
            // joint5Label
            // 
            this.joint5Label.AutoSize = true;
            this.joint5Label.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joint5Label.Location = new System.Drawing.Point(15, 250);
            this.joint5Label.Name = "joint5Label";
            this.joint5Label.Size = new System.Drawing.Size(109, 25);
            this.joint5Label.TabIndex = 13;
            this.joint5Label.Text = "WJoint5";
            // 
            // positionOutput_3
            // 
            this.positionOutput_3.Location = new System.Drawing.Point(579, 203);
            this.positionOutput_3.Name = "positionOutput_3";
            this.positionOutput_3.Size = new System.Drawing.Size(41, 20);
            this.positionOutput_3.TabIndex = 12;
            // 
            // positionInput_3
            // 
            this.positionInput_3.Location = new System.Drawing.Point(247, 196);
            this.positionInput_3.Maximum = 67;
            this.positionInput_3.Minimum = -67;
            this.positionInput_3.Name = "positionInput_3";
            this.positionInput_3.Size = new System.Drawing.Size(326, 45);
            this.positionInput_3.TabIndex = 11;
            this.positionInput_3.ValueChanged += new System.EventHandler(this.PositionInput_ValueChanged);
            // 
            // joint4Label
            // 
            this.joint4Label.AutoSize = true;
            this.joint4Label.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joint4Label.Location = new System.Drawing.Point(15, 196);
            this.joint4Label.Name = "joint4Label";
            this.joint4Label.Size = new System.Drawing.Size(109, 25);
            this.joint4Label.TabIndex = 10;
            this.joint4Label.Text = "WJoint4";
            // 
            // positionOutput_2
            // 
            this.positionOutput_2.Location = new System.Drawing.Point(579, 134);
            this.positionOutput_2.Name = "positionOutput_2";
            this.positionOutput_2.Size = new System.Drawing.Size(41, 20);
            this.positionOutput_2.TabIndex = 9;
            // 
            // positionOutput_1
            // 
            this.positionOutput_1.Location = new System.Drawing.Point(579, 80);
            this.positionOutput_1.Name = "positionOutput_1";
            this.positionOutput_1.Size = new System.Drawing.Size(41, 20);
            this.positionOutput_1.TabIndex = 8;
            // 
            // positionOutput_0
            // 
            this.positionOutput_0.Location = new System.Drawing.Point(579, 26);
            this.positionOutput_0.Name = "positionOutput_0";
            this.positionOutput_0.Size = new System.Drawing.Size(41, 20);
            this.positionOutput_0.TabIndex = 7;
            // 
            // positionInput_1
            // 
            this.positionInput_1.Location = new System.Drawing.Point(247, 73);
            this.positionInput_1.Maximum = 67;
            this.positionInput_1.Minimum = -67;
            this.positionInput_1.Name = "positionInput_1";
            this.positionInput_1.Size = new System.Drawing.Size(326, 45);
            this.positionInput_1.TabIndex = 4;
            this.positionInput_1.ValueChanged += new System.EventHandler(this.PositionInput_ValueChanged);
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
            // positionInput_2
            // 
            this.positionInput_2.Location = new System.Drawing.Point(247, 127);
            this.positionInput_2.Maximum = 67;
            this.positionInput_2.Minimum = -67;
            this.positionInput_2.Name = "positionInput_2";
            this.positionInput_2.Size = new System.Drawing.Size(326, 45);
            this.positionInput_2.TabIndex = 6;
            this.positionInput_2.ValueChanged += new System.EventHandler(this.PositionInput_ValueChanged);
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
            // automaticPage
            // 
            this.automaticPage.Controls.Add(this.homeButton);
            this.automaticPage.Location = new System.Drawing.Point(4, 22);
            this.automaticPage.Name = "automaticPage";
            this.automaticPage.Size = new System.Drawing.Size(629, 353);
            this.automaticPage.TabIndex = 2;
            this.automaticPage.Text = "Automatic Mode";
            this.automaticPage.UseVisualStyleBackColor = true;
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(13, 14);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(98, 23);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // settingsPage
            // 
            this.settingsPage.Controls.Add(this.HardwareSimulationModeInput);
            this.settingsPage.Controls.Add(this.velocityInput_5);
            this.settingsPage.Controls.Add(this.joint6ServoSpeedLabel);
            this.settingsPage.Controls.Add(this.velocityInput_4);
            this.settingsPage.Controls.Add(this.joint5ServoSpeedLabel);
            this.settingsPage.Controls.Add(this.velocityInput_3);
            this.settingsPage.Controls.Add(this.joint4ServoSpeedLabel);
            this.settingsPage.Controls.Add(this.velocityInput_2);
            this.settingsPage.Controls.Add(this.joint3ServoSpeedLabel);
            this.settingsPage.Controls.Add(this.velocityInput_1);
            this.settingsPage.Controls.Add(this.joint2ServoSpeedLabel);
            this.settingsPage.Controls.Add(this.velocityInput_0);
            this.settingsPage.Controls.Add(this.joint1ServoSpeedLabel);
            this.settingsPage.Location = new System.Drawing.Point(4, 22);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Size = new System.Drawing.Size(629, 353);
            this.settingsPage.TabIndex = 3;
            this.settingsPage.Text = "Settings";
            this.settingsPage.UseVisualStyleBackColor = true;
            // 
            // HardwareSimulationModeInput
            // 
            this.HardwareSimulationModeInput.AutoSize = true;
            this.HardwareSimulationModeInput.Location = new System.Drawing.Point(17, 323);
            this.HardwareSimulationModeInput.Name = "HardwareSimulationModeInput";
            this.HardwareSimulationModeInput.Size = new System.Drawing.Size(115, 17);
            this.HardwareSimulationModeInput.TabIndex = 15;
            this.HardwareSimulationModeInput.Text = "Simulate Hardware";
            this.HardwareSimulationModeInput.UseVisualStyleBackColor = true;
            this.HardwareSimulationModeInput.CheckedChanged += new System.EventHandler(this.HardwareSimulationModeInput_CheckedChanged);
            // 
            // velocityInput_5
            // 
            this.velocityInput_5.Location = new System.Drawing.Point(280, 200);
            this.velocityInput_5.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.velocityInput_5.Name = "velocityInput_5";
            this.velocityInput_5.Size = new System.Drawing.Size(58, 20);
            this.velocityInput_5.TabIndex = 14;
            this.velocityInput_5.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.velocityInput_5.ValueChanged += new System.EventHandler(this.VelocityInput_ValueChanged);
            // 
            // joint6ServoSpeedLabel
            // 
            this.joint6ServoSpeedLabel.AutoSize = true;
            this.joint6ServoSpeedLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joint6ServoSpeedLabel.Location = new System.Drawing.Point(12, 195);
            this.joint6ServoSpeedLabel.Name = "joint6ServoSpeedLabel";
            this.joint6ServoSpeedLabel.Size = new System.Drawing.Size(246, 25);
            this.joint6ServoSpeedLabel.TabIndex = 13;
            this.joint6ServoSpeedLabel.Text = "Joint 6 Servo Speed";
            // 
            // velocityInput_4
            // 
            this.velocityInput_4.Location = new System.Drawing.Point(280, 166);
            this.velocityInput_4.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.velocityInput_4.Name = "velocityInput_4";
            this.velocityInput_4.Size = new System.Drawing.Size(58, 20);
            this.velocityInput_4.TabIndex = 12;
            this.velocityInput_4.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.velocityInput_4.ValueChanged += new System.EventHandler(this.VelocityInput_ValueChanged);
            // 
            // joint5ServoSpeedLabel
            // 
            this.joint5ServoSpeedLabel.AutoSize = true;
            this.joint5ServoSpeedLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joint5ServoSpeedLabel.Location = new System.Drawing.Point(12, 161);
            this.joint5ServoSpeedLabel.Name = "joint5ServoSpeedLabel";
            this.joint5ServoSpeedLabel.Size = new System.Drawing.Size(246, 25);
            this.joint5ServoSpeedLabel.TabIndex = 11;
            this.joint5ServoSpeedLabel.Text = "Joint 5 Servo Speed";
            // 
            // velocityInput_3
            // 
            this.velocityInput_3.Location = new System.Drawing.Point(280, 131);
            this.velocityInput_3.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.velocityInput_3.Name = "velocityInput_3";
            this.velocityInput_3.Size = new System.Drawing.Size(58, 20);
            this.velocityInput_3.TabIndex = 10;
            this.velocityInput_3.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.velocityInput_3.ValueChanged += new System.EventHandler(this.VelocityInput_ValueChanged);
            // 
            // joint4ServoSpeedLabel
            // 
            this.joint4ServoSpeedLabel.AutoSize = true;
            this.joint4ServoSpeedLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joint4ServoSpeedLabel.Location = new System.Drawing.Point(12, 126);
            this.joint4ServoSpeedLabel.Name = "joint4ServoSpeedLabel";
            this.joint4ServoSpeedLabel.Size = new System.Drawing.Size(246, 25);
            this.joint4ServoSpeedLabel.TabIndex = 9;
            this.joint4ServoSpeedLabel.Text = "Joint 4 Servo Speed";
            // 
            // velocityInput_2
            // 
            this.velocityInput_2.Location = new System.Drawing.Point(280, 88);
            this.velocityInput_2.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.velocityInput_2.Name = "velocityInput_2";
            this.velocityInput_2.Size = new System.Drawing.Size(58, 20);
            this.velocityInput_2.TabIndex = 8;
            this.velocityInput_2.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.velocityInput_2.ValueChanged += new System.EventHandler(this.VelocityInput_ValueChanged);
            // 
            // joint3ServoSpeedLabel
            // 
            this.joint3ServoSpeedLabel.AutoSize = true;
            this.joint3ServoSpeedLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joint3ServoSpeedLabel.Location = new System.Drawing.Point(12, 83);
            this.joint3ServoSpeedLabel.Name = "joint3ServoSpeedLabel";
            this.joint3ServoSpeedLabel.Size = new System.Drawing.Size(246, 25);
            this.joint3ServoSpeedLabel.TabIndex = 7;
            this.joint3ServoSpeedLabel.Text = "Joint 3 Servo Speed";
            // 
            // velocityInput_1
            // 
            this.velocityInput_1.Location = new System.Drawing.Point(280, 54);
            this.velocityInput_1.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.velocityInput_1.Name = "velocityInput_1";
            this.velocityInput_1.Size = new System.Drawing.Size(58, 20);
            this.velocityInput_1.TabIndex = 6;
            this.velocityInput_1.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.velocityInput_1.ValueChanged += new System.EventHandler(this.VelocityInput_ValueChanged);
            // 
            // joint2ServoSpeedLabel
            // 
            this.joint2ServoSpeedLabel.AutoSize = true;
            this.joint2ServoSpeedLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joint2ServoSpeedLabel.Location = new System.Drawing.Point(12, 49);
            this.joint2ServoSpeedLabel.Name = "joint2ServoSpeedLabel";
            this.joint2ServoSpeedLabel.Size = new System.Drawing.Size(246, 25);
            this.joint2ServoSpeedLabel.TabIndex = 5;
            this.joint2ServoSpeedLabel.Text = "Joint 2 Servo Speed";
            // 
            // velocityInput_0
            // 
            this.velocityInput_0.Location = new System.Drawing.Point(280, 19);
            this.velocityInput_0.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.velocityInput_0.Name = "velocityInput_0";
            this.velocityInput_0.Size = new System.Drawing.Size(58, 20);
            this.velocityInput_0.TabIndex = 4;
            this.velocityInput_0.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.velocityInput_0.ValueChanged += new System.EventHandler(this.VelocityInput_ValueChanged);
            // 
            // joint1ServoSpeedLabel
            // 
            this.joint1ServoSpeedLabel.AutoSize = true;
            this.joint1ServoSpeedLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joint1ServoSpeedLabel.Location = new System.Drawing.Point(12, 14);
            this.joint1ServoSpeedLabel.Name = "joint1ServoSpeedLabel";
            this.joint1ServoSpeedLabel.Size = new System.Drawing.Size(246, 25);
            this.joint1ServoSpeedLabel.TabIndex = 3;
            this.joint1ServoSpeedLabel.Text = "Joint 1 Servo Speed";
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
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // RunInitInput
            // 
            this.RunInitInput.Location = new System.Drawing.Point(651, 34);
            this.RunInitInput.Name = "RunInitInput";
            this.RunInitInput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RunInitInput.Size = new System.Drawing.Size(59, 31);
            this.RunInitInput.TabIndex = 5;
            this.RunInitInput.Text = "I N I T";
            this.RunInitInput.UseVisualStyleBackColor = true;
            this.RunInitInput.Click += new System.EventHandler(this.RunInitInput_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 504);
            this.Controls.Add(this.RunInitInput);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "RoboticArm";
            ((System.ComponentModel.ISupportInitialize)(this.positionInput_0)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.manualPage.ResumeLayout(false);
            this.manualPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionInput_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionInput_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionInput_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionInput_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionInput_2)).EndInit();
            this.automaticPage.ResumeLayout(false);
            this.settingsPage.ResumeLayout(false);
            this.settingsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.velocityInput_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocityInput_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocityInput_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocityInput_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocityInput_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocityInput_0)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TrackBar positionInput_0;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage manualPage;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label joint1Label;
        private System.Windows.Forms.TrackBar positionInput_1;
        private System.Windows.Forms.Label joint2Label;
        private System.Windows.Forms.TrackBar positionInput_2;
        private System.Windows.Forms.Label joint3Label;
        private System.Windows.Forms.TextBox positionOutput_2;
        private System.Windows.Forms.TextBox positionOutput_1;
        private System.Windows.Forms.TextBox positionOutput_0;
        private System.Windows.Forms.TextBox positionOutput_5;
        private System.Windows.Forms.TrackBar positionInput_5;
        private System.Windows.Forms.Label joint6Label;
        private System.Windows.Forms.TextBox positionOutput_4;
        private System.Windows.Forms.TrackBar positionInput_4;
        private System.Windows.Forms.Label joint5Label;
        private System.Windows.Forms.TextBox positionOutput_3;
        private System.Windows.Forms.TrackBar positionInput_3;
        private System.Windows.Forms.Label joint4Label;
        private System.Windows.Forms.TabPage automaticPage;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.TabPage settingsPage;
        private System.Windows.Forms.NumericUpDown velocityInput_0;
        private System.Windows.Forms.Label joint1ServoSpeedLabel;
        private System.Windows.Forms.NumericUpDown velocityInput_5;
        private System.Windows.Forms.Label joint6ServoSpeedLabel;
        private System.Windows.Forms.NumericUpDown velocityInput_4;
        private System.Windows.Forms.Label joint5ServoSpeedLabel;
        private System.Windows.Forms.NumericUpDown velocityInput_3;
        private System.Windows.Forms.Label joint4ServoSpeedLabel;
        private System.Windows.Forms.NumericUpDown velocityInput_2;
        private System.Windows.Forms.Label joint3ServoSpeedLabel;
        private System.Windows.Forms.NumericUpDown velocityInput_1;
        private System.Windows.Forms.Label joint2ServoSpeedLabel;
        private System.Windows.Forms.CheckBox HardwareSimulationModeInput;
        private System.Windows.Forms.Button RunInitInput;
    }
}

