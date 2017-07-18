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
            servo.SetDegree(0, -9000, 9000);
            servo.SetPulseWidth(0, 1000, 2000);
            servo.SetPeriod(0, 19500);
            servo.SetAcceleration(0, 65535); // Full Accel
            servo.SetVelocity(0, 65535); // Full speed
        }

   

        private void baseSlider_ValueChanged(object sender, EventArgs e)
        {
            servo.SetPosition(0, (short)(baseSlider.Value * 100)); // Set to most right position
            servo.Enable(0);

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            logBox.Clear();
        }

        private void Log(string message)
        {
            logBox.AppendText(message + Environment.NewLine);
        }
            
    }
}
