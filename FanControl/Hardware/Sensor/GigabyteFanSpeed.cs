﻿using Gigabyte.Engine.EnvironmentControl.CoolingDevice.Fan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanControl
{
    public class GigabyteFanSpeed : BaseSensor
    {
        private string mName;
        private int mIndex = -1;
        
        public GigabyteFanSpeed(string name, int index) : base(SENSOR_TYPE.TEMPERATURE)
        {
            mName = name;
            mIndex = index;
        }

        public override string getName()
        {
            return mName;
        }

        public override string getString()
        {
            var valueString = string.Format("{0:D4}", Value);
            return valueString + " RPM (" + this.getName() + ")";
        }

        public override void update()
        {
            float speed = HardwareManager.getInstance().GigabyteFanSpeedList[mIndex];
            Value = (int)Math.Round(speed);
        }
        
    }
}
