using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoboticArm.Hardware;


namespace RoboticArm
{
    public partial class Form1 : Form
    {
        private IRoboticArmWith6DOF arm;

        private Dictionary<byte, TextBox> positionOutputs;
        private Dictionary<byte, TrackBar> positionInputs;
        private Dictionary<byte, NumericUpDown> velocityInputs;

        public Form1()
        {
            InitializeComponent();
            arm = new TFRoboticArmWith6DOF();

            positionOutputs = new Dictionary<byte, TextBox>();
            positionOutputs.Add(0, this.positionOutput_0);
            positionOutputs.Add(1, this.positionOutput_1);
            positionOutputs.Add(2, this.positionOutput_2);
            positionOutputs.Add(3, this.positionOutput_3);
            positionOutputs.Add(4, this.positionOutput_4);
            positionOutputs.Add(5, this.positionOutput_5);

            positionInputs = new Dictionary<byte, TrackBar>();
            positionInputs.Add(0, this.positionInput_0);
            positionInputs.Add(1, this.positionInput_1);
            positionInputs.Add(2, this.positionInput_2);
            positionInputs.Add(3, this.positionInput_3);
            positionInputs.Add(4, this.positionInput_4);
            positionInputs.Add(5, this.positionInput_5);

            velocityInputs = new Dictionary<byte, NumericUpDown>();
            velocityInputs.Add(0, this.velocityInput_0);
            velocityInputs.Add(1, this.velocityInput_1);
            velocityInputs.Add(2, this.velocityInput_2);
            velocityInputs.Add(3, this.velocityInput_3);
            velocityInputs.Add(4, this.velocityInput_4);
            velocityInputs.Add(5, this.velocityInput_5);

            RefreshOutputElements();

            Log("Hardware init done!");
        }

        private void RefreshOutputElements()
        {
            // load the actual values for velocity
            foreach (byte motorID in velocityInputs.Keys)
            {
                velocityInputs[motorID].Value = arm.GetVelocity(motorID);
            }

            // load the actual values for position
            foreach (byte motorID in positionInputs.Keys)
            {
                positionInputs[motorID].Value = (arm.GetPosition(motorID) / 100);
                positionOutputs[motorID].Text = arm.GetPosition(motorID).ToString();
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

        private void PositionInput_ValueChanged(object sender, EventArgs e)
        {
            TrackBar input = (TrackBar)sender;
            byte motorID = byte.Parse(input.Name.Replace("positionInput_", ""));

            arm.SetPosition(motorID, (short)(input.Value * 100));
            positionOutputs[motorID].Text = (arm.GetPosition(motorID) / 100).ToString();
        }

        private void VelocityInput_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown input = (NumericUpDown)sender;
            byte motorID = byte.Parse(input.Name.Replace("velocityInput_", ""));

            arm.SetVelocity(motorID, (int)input.Value);
        }
       
        private void HomeButton_Click(object sender, EventArgs e)
        {
            arm.HomeAllAxis();
        }
    }
}
