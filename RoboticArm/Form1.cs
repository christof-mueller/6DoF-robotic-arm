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

        private const byte JOINT1_SERVO = 0;
        private const byte JOINT2_SERVO = 1;
        private const byte JOINT3_SERVO = 2;
        private const byte JOINT4_SERVO = 3;
        private const byte JOINT5_SERVO = 4;
        private const byte JOINT6_SERVO = 5;

        private const byte SERVO_COUNT = 6;

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
            servo.SetDegree(JOINT1_SERVO, -6700, 6700);
            servo.SetPulseWidth(JOINT1_SERVO, 800, 2700);
            servo.SetPeriod(JOINT1_SERVO, 19500);
            servo.SetAcceleration(JOINT1_SERVO, 65535); // Full Accel
            servo.SetVelocity(JOINT1_SERVO, 65535); // Full speed

            // servo1 = Join2 (Shoulder)
            servo.SetDegree(JOINT2_SERVO, -6700, 6700);
            servo.SetPulseWidth(JOINT2_SERVO, 800, 2700);
            servo.SetPeriod(JOINT2_SERVO, 19500);
            servo.SetAcceleration(JOINT2_SERVO, 65535); // Full Accel
            servo.SetVelocity(JOINT2_SERVO, 65535); // Full speed

            // servo2 = Join3 (Elbow)
            servo.SetDegree(JOINT3_SERVO, -6700, 6700);
            servo.SetPulseWidth(JOINT3_SERVO, 800, 2100);
            servo.SetPeriod(JOINT3_SERVO, 19500);
            servo.SetAcceleration(JOINT3_SERVO, 65535); // Full Accel
            servo.SetVelocity(JOINT3_SERVO, 65535); // Full speed

            // servo3 = Join4 (Wrist)
            servo.SetDegree(JOINT4_SERVO, -6700, 6700);
            servo.SetPulseWidth(JOINT4_SERVO, 800, 2100);
            servo.SetPeriod(JOINT4_SERVO, 19500);
            servo.SetAcceleration(JOINT4_SERVO, 65535); // Full Accel
            servo.SetVelocity(JOINT4_SERVO, 65535); // Full speed

            // servo4 = Join5 (Wrist)
            servo.SetDegree(JOINT5_SERVO, -6700, 6700);
            servo.SetPulseWidth(JOINT5_SERVO, 800, 2100);
            servo.SetPeriod(JOINT5_SERVO, 19500);
            servo.SetAcceleration(JOINT5_SERVO, 65535); // Full Accel
            servo.SetVelocity(JOINT5_SERVO, 65535); // Full speed

            // servo5 = Join6 (Wrist)
            servo.SetDegree(JOINT6_SERVO, -6700, 6700);
            servo.SetPulseWidth(JOINT6_SERVO, 800, 2100);
            servo.SetPeriod(JOINT6_SERVO, 19500);
            servo.SetAcceleration(JOINT6_SERVO, 65535); // Full Accel
            servo.SetVelocity(JOINT6_SERVO, 65535); // Full speed

            SetPowerState(true);
        }


        private void SetPowerState(bool state)
        {
            for(byte i=0; i<SERVO_COUNT; i++)
            {
                servo.Enable(i);
            }
        }

        private void HomeAllAxis()
        {
            for (byte i=0; i<SERVO_COUNT; i++)
            {
                // Decoupling homeing request with 500ms sleep between each.
                if (i > 0) // don't wait before first axis homeing
                {
                    System.Threading.Thread.Sleep(500);
                }
                servo.SetPosition(i, 0);
            }
        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            logBox.Clear();
        }

        private void Log(string message)
        {
            logBox.AppendText(message + Environment.NewLine);
        }

        private void HandleServoSliderChange(byte servoId, TrackBar jointSlider, TextBox jointPosition)
        {
            servo.SetPosition(servoId, (short)(jointSlider.Value * 100));
            jointPosition.Text = (servo.GetPosition(servoId) / 100).ToString();
        }


        private void Joint1Slider_ValueChanged(object sender, EventArgs e)
        {
            HandleServoSliderChange(JOINT1_SERVO, joint1Slider, joint1Position);
        }

        private void Joint2Slider_ValueChanged(object sender, EventArgs e)
        {
            HandleServoSliderChange(JOINT2_SERVO, joint2Slider, joint2Position);
        }

        private void Joint3Slider_ValueChanged(object sender, EventArgs e)
        {
            HandleServoSliderChange(JOINT3_SERVO, joint3Slider, joint3Position);
        }

        private void Joint4Slider_ValueChanged(object sender, EventArgs e)
        {
            HandleServoSliderChange(JOINT4_SERVO, joint4Slider, joint4Position);
        }

        private void Joint5Slider_ValueChanged(object sender, EventArgs e)
        {
            HandleServoSliderChange(JOINT5_SERVO, joint5Slider, joint5Position);
        }

        private void Joint6Slider_ValueChanged(object sender, EventArgs e)
        {
            HandleServoSliderChange(JOINT6_SERVO, joint6Slider, joint6Position);
        }



        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomeAllAxis();
        }
    }
}
