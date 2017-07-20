using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tinkerforge;

namespace RoboticArm
{
    public partial class Form1 : Form
    {
        private static string HOST = "localhost";
        private static int PORT = 4223;
        private static string UID = "6wT1xU";

        private IPConnection ipcon;
        private BrickServo servo;

        public Form1()
        {
            InitializeComponent();
            InitHardware();
        }

        private void InitHardware()
        {
            // Connection to brickd
            ipcon = new IPConnection(); 
            servo = new BrickServo(UID, ipcon); 
            ipcon.Connect(HOST, PORT); 

            servo.SetOutputVoltage(5000); // 5V

            // servo0 = HIP-Joint
            servo.SetDegree(0, -6700, 6700);
            servo.SetPulseWidth(0, 800, 2700);
            servo.SetPeriod(0, 19500);
            servo.SetAcceleration(0, 65535); // Full Accel
            servo.SetVelocity(0, 65535); // Full speed
            servo.Enable(0);

            // servo1 = Join2 (Shoulder)
            servo.SetDegree(1, -6700, 6700);
            servo.SetPulseWidth(1, 800, 2700);
            servo.SetPeriod(1, 19500);
            servo.SetAcceleration(1, 65535); // Full Accel
            servo.SetVelocity(1, 65535); // Full speed
            servo.Enable(1);

            // servo2 = Join3 (Elbow)
            servo.SetDegree(2, -6700, 6700);
            servo.SetPulseWidth(2, 800, 2100);
            servo.SetPeriod(2, 19500);
            servo.SetAcceleration(2, 65535); // Full Accel
            servo.SetVelocity(2, 65535); // Full speed
            servo.Enable(2);

            // servo3 = Join4 (Wrist)
            servo.SetDegree(3, -6700, 6700);
            servo.SetPulseWidth(3, 800, 2100);
            servo.SetPeriod(3, 19500);
            servo.SetAcceleration(3, 65535); // Full Accel
            servo.SetVelocity(3, 65535); // Full speed
            servo.Enable(3);

            // servo4 = Join5 (Wrist)
            servo.SetDegree(4, -6700, 6700);
            servo.SetPulseWidth(4, 800, 2100);
            servo.SetPeriod(4, 19500);
            servo.SetAcceleration(4, 65535); // Full Accel
            servo.SetVelocity(4, 65535); // Full speed
            servo.Enable(4);

            // servo5 = Join6 (Wrist)
            servo.SetDegree(5, -6700, 6700);
            servo.SetPulseWidth(5, 800, 2100);
            servo.SetPeriod(5, 19500);
            servo.SetAcceleration(5, 65535); // Full Accel
            servo.SetVelocity(5, 65535); // Full speed
            servo.Enable(5);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            logBox.Clear();
        }

        private void Log(string message)
        {
            logBox.AppendText(message + Environment.NewLine);
        }



        private void joint1Slider_ValueChanged(object sender, EventArgs e)
        {
            servo.SetPosition(0, (short)(joint1Slider.Value * 100));
            joint1Position.Text = (servo.GetPosition(0) / 100).ToString();
        }

        private void joint2Slider_ValueChanged(object sender, EventArgs e)
        {
            servo.SetPosition(1, (short)(joint2Slider.Value * 100));
            joint2Position.Text = (servo.GetPosition(1) / 100).ToString();
        }

        private void joint3Slider_ValueChanged(object sender, EventArgs e)
        {
            servo.SetPosition(2, (short)(joint3Slider.Value * 100));
            joint3Position.Text = (servo.GetPosition(2) / 100).ToString();
        }

        private void joint4Slider_ValueChanged(object sender, EventArgs e)
        {
            servo.SetPosition(3, (short)(joint4Slider.Value * 100));
            joint4Position.Text = (servo.GetPosition(3) / 100).ToString();
        }

        private void joint5Slider_ValueChanged(object sender, EventArgs e)
        {
            servo.SetPosition(4, (short)(joint5Slider.Value * 100));
            joint5Position.Text = (servo.GetPosition(4) / 100).ToString();
        }

        private void joint6Slider_ValueChanged(object sender, EventArgs e)
        {
            servo.SetPosition(5, (short)(joint6Slider.Value * 100));
            joint6Position.Text = (servo.GetPosition(5) / 100).ToString();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            for(int i=0; i<6; i++)
            {
                servo.SetPosition((byte)i, 0);
            }
            
        }
    }
}
