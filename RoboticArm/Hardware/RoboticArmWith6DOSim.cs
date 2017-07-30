using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tinkerforge;

namespace RoboticArm.Hardware
{
    class RoboticArmWith6DOSim : IRoboticArmWith6DOF
    {
        private const byte JOINT1_SERVO = 0;
        private const byte JOINT2_SERVO = 1;
        private const byte JOINT3_SERVO = 2;
        private const byte JOINT4_SERVO = 3;
        private const byte JOINT5_SERVO = 4;
        private const byte JOINT6_SERVO = 5;

        private const byte SERVO_COUNT = 6;

        Dictionary<byte, short> positions;
        Dictionary<byte, int> velocities;


        public RoboticArmWith6DOSim()
        {
            // store internal data dyn.
            positions = new Dictionary<byte, short>();
            velocities = new Dictionary<byte, int>();
        }

        public List<byte> GetMotorIDs()
        {
            return new List<byte>() { JOINT1_SERVO, JOINT2_SERVO, JOINT3_SERVO, JOINT4_SERVO, JOINT5_SERVO, JOINT6_SERVO };
        }

        public void SetPosition(byte motorID, short position)
        {
            if (GetMotorIDs().Contains(motorID))
            {
                if (!positions.ContainsKey(motorID))
                {
                    positions.Add(motorID, position);
                }
                positions[motorID] = position;
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
                if (positions.ContainsKey(motorID))
                {
                    return positions[motorID];
                }
                else
                {
                    return 0;
                }    

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
                if (!positions.ContainsKey(motorID))
                {
                    velocities.Add(motorID, velocity);
                }
                velocities[motorID] = velocity;
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
                if (velocities.ContainsKey(motorID))
                {
                    return velocities[motorID];
                }
                else
                {
                    return 0;
                }
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
                SetPosition(motorID, 0);
            }
        }
    }
}
