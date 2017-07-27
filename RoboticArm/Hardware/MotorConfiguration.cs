using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboticArm.Hardware
{
    public class MotorConfiguration
    {
        private Dictionary<string, string> configList;

        public MotorConfiguration()
        {
            configList =  new Dictionary<string, string>();
        }

        public void SetValue(string name, string value)
        {
            name = name.Trim();
            value = value.Trim();
            if (configList.ContainsKey(name))
            {
                configList[name] = value;
            } 
            else
            {
                configList.Add(name, value);
            }
        }

        public byte GetByteValue(string name)
        {
            string value = GetStringValue(name);
            if (!string.IsNullOrWhiteSpace(value))
            {
                return byte.Parse(value);
            }
            else
            {
                return 0;
            }
        }

        public short GetShortValue(string name)
        {
            string value = GetStringValue(name);
            if (!string.IsNullOrWhiteSpace(value))
            {
                return short.Parse(value);
            }
             else
            {
                return 0;
            }
        }

        public int GetIntValue(string name)
        {
            string value = GetStringValue(name);
            if (!string.IsNullOrWhiteSpace(value))
            {
                return int.Parse(value);
            }
            else
            {
                return 0;
            }
        }

        public string GetStringValue(string name)
        {
            if (configList.ContainsKey(name))
            {
                return configList[name];
            }
            else
            {
                return "";
            }
        }
    }
}
