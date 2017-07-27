using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboticArm.Hardware
{
    interface IRoboticArmWith6DOF
    {
        List<byte> GetMotorIDs();

        void SetPosition(byte motorID, short position);
        short GetPosition(byte motorID);

        void SetVelocity(byte motorID, int velocity);
        int GetVelocity(byte motorID);

        void HomeAllAxis();
    }
}
