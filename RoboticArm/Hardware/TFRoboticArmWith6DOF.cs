using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tinkerforge;

namespace RoboticArm.Hardware
{
    class TFRoboticArmWith6DOF : IRoboticArmWith6DOF
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

        public TFRoboticArmWith6DOF()
        {
            // Connection to brickd
            ipcon = new IPConnection();
            servo = new BrickServo(UID, ipcon);
            ipcon.Connect(HOST, PORT);

            servo.SetOutputVoltage(5000); // 5V

            MotorConfiguration mcServoTypeA = new MotorConfiguration();
            mcServoTypeA.SetValue("Degree_Min", "-6700");
            mcServoTypeA.SetValue("Degree_Max", "6700");
            mcServoTypeA.SetValue("PulseWidth_Min", "800");
            mcServoTypeA.SetValue("PulseWidth_Max", "2700");
            mcServoTypeA.SetValue("Period", "19500");
            mcServoTypeA.SetValue("Acceleration", "65535");
            mcServoTypeA.SetValue("Velocity", "65535");
            mcServoTypeA.SetValue("Position", "0");

            MotorConfiguration mcServoTypeB = new MotorConfiguration();
            mcServoTypeB.SetValue("Degree_Min", "-6700");
            mcServoTypeB.SetValue("Degree_Max", "6700");
            mcServoTypeB.SetValue("PulseWidth_Min", "800");
            mcServoTypeB.SetValue("PulseWidth_Max", "2100");
            mcServoTypeB.SetValue("Period", "19500");
            mcServoTypeB.SetValue("Acceleration", "65535");
            mcServoTypeB.SetValue("Velocity", "65535");
            mcServoTypeB.SetValue("Position", "0");

            SetMotorConfiguration(JOINT1_SERVO, mcServoTypeA);
            SetMotorConfiguration(JOINT2_SERVO, mcServoTypeA);
            SetMotorConfiguration(JOINT3_SERVO, mcServoTypeB);
            SetMotorConfiguration(JOINT4_SERVO, mcServoTypeB);
            SetMotorConfiguration(JOINT5_SERVO, mcServoTypeB);
            SetMotorConfiguration(JOINT6_SERVO, mcServoTypeB);

        }

        private void SetMotorConfiguration(byte motorID, MotorConfiguration mc)
        {
            if (GetMotorIDs().Contains(motorID))
            {
                servo.SetDegree(motorID, mc.GetShortValue("Degree_Min"), mc.GetShortValue("Degree_Max"));
                servo.SetPulseWidth(motorID, mc.GetIntValue("PulseWidth_Min"), mc.GetIntValue("PulseWidth_Max"));
                servo.SetPeriod(motorID, mc.GetIntValue("Period"));
                servo.SetAcceleration(motorID, mc.GetIntValue("Acceleration"));
                servo.SetVelocity(motorID, mc.GetIntValue("Velocity"));
                servo.SetPosition(motorID, mc.GetShortValue("Position"));
                servo.Enable(motorID);
            }
            else
            {
                throw new Exception("Unkown motorID in SetMotorConfiguration: " + motorID);
            }
        }

        public List<byte> GetMotorIDs()
        {
            return new List<byte>() { JOINT1_SERVO, JOINT2_SERVO, JOINT3_SERVO, JOINT4_SERVO, JOINT5_SERVO, JOINT6_SERVO };
        }

        public void SetPosition(byte motorID, short position)
        {
            if (GetMotorIDs().Contains(motorID))
            {
                servo.SetPosition(motorID, position);
            }
            else
            {
                throw new Exception("Unkown motorID in SetPosition: " + motorID);
            }
        }

        public short GetPosition(byte motorID)
        {
            if (GetMotorIDs().Contains(motorID))
            {
                return servo.GetPosition(motorID);
            }
            else
            {
                throw new Exception("Unkown motorID in GetPosition: " + motorID);
            }
        }

        public void SetVelocity(byte motorID, int velocity)
        {
            if (GetMotorIDs().Contains(motorID))
            {
                servo.SetVelocity(motorID, velocity);
            }
            else
            {
                throw new Exception("Unkown motorID in SetVelocity: " + motorID);
            }
        }

        public int GetVelocity(byte motorID)
        {
            if (GetMotorIDs().Contains(motorID))
            {
                return servo.GetVelocity(motorID);
            }
            else
            {
                throw new Exception("Unkown motorID in GetVelocity: " + motorID);
            }
        }

        public void HomeAllAxis()
        {
            foreach(byte motorID in GetMotorIDs())
            {
                // Decoupling homeing request with 500ms sleep between each.
                if (motorID > 0) // don't wait before first axis homeing
                {
                    System.Threading.Thread.Sleep(500);
                }
                servo.SetPosition(motorID, 0);
            }
        }
    }
}
