﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace FanCtrl
{
    public class OptionManager
    {
        private string mOptionFileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\" + "Option.json";

        private static OptionManager sManager = new OptionManager();
        public static OptionManager getInstance() { return sManager; }

        private StartupControl mStartupControl = new StartupControl();

        private OptionManager()
        {
            this.reset();
        }
        
        public int Interval { get; set; }

        // Gigabyte
        public bool IsGigabyte { get; set; }
        public bool IsGigabyteMotherboard { get; set; }
        public bool IsGigabyteGpu { get; set; }

        // LibreHardwareMonitor
        public bool IsLHM { get; set; }
        public bool IsLHMCpu { get; set; }
        public bool IsLHMMotherboard { get; set; }
        public bool IsLHMGpu { get; set; }
        public bool IsLHMContolled { get; set; }
        public bool IsLHMStorage { get; set; }
        public bool IsLHMMemory { get; set; }

        // OpenHardwareMonitor
        public bool IsOHM { get; set; }
        public bool IsOHMCpu { get; set; }
        public bool IsOHMMotherboard { get; set; }
        public bool IsOHMGpu { get; set; }
        public bool IsOHMContolled { get; set; }
        public bool IsOHMStorage { get; set; }
        public bool IsOHMMemory { get; set; }

        // NvApiWrapper
        public bool IsNvAPIWrapper { get; set; }

        // Dimm
        public bool IsDimm { get; set; }

        // NZXT Kraken Z3
        public bool IsKrakenLCD { get; set; }

        // NZXT Kraken X2, X3
        public bool IsKraken { get; set; }

        // EVGA CLC
        public bool IsCLC { get; set; }

        // NZXT Fan&Contoller
        public bool IsRGBnFC { get; set; }

        // HWiNFO
        public bool IsHWInfo { get; set; }

        // Other options
        public bool IsAnimation { get; set; }

        public bool IsFahrenheit { get; set; }

        public bool IsMinimized { get; set; }

        public int DelayTime
        {
            get
            {
                return mStartupControl.DelayTime;
            }
            set
            {

                mStartupControl.DelayTime = value;
            }
        }

        public bool IsStartUp
        {
            get
            {
                return mStartupControl.Startup;
            }
            set
            {

                mStartupControl.Startup = value;
            }
        }

        public void reset()
        {
            Interval = 1000;

            IsGigabyte = false;
            IsGigabyteMotherboard = true;
            IsGigabyteGpu = true;

            IsLHM = true;
            IsLHMCpu = true;
            IsLHMMotherboard = true;
            IsLHMGpu = false;
            IsLHMContolled = true;
            IsLHMStorage = true;
            IsLHMMemory = true;

            IsOHM = false;
            IsOHMCpu = true;
            IsOHMMotherboard = true;
            IsOHMGpu = false;
            IsOHMContolled = false;
            IsOHMStorage = false;
            IsOHMMemory = false;

            IsNvAPIWrapper = true;
            IsDimm = true;
            IsKrakenLCD = true;
            IsKraken = true;
            IsCLC = true;
            IsRGBnFC = true;
            IsHWInfo = false;

            IsAnimation = true;
            IsFahrenheit = false;
            IsMinimized = false;
        }

        public bool read()
        {
            try 
            {
                var jsonString = File.ReadAllText(mOptionFileName);                
                var rootObject = JObject.Parse(jsonString);

                Interval = (rootObject.ContainsKey("Interval") == true) ? rootObject.Value<int>("Interval") : 1000;

                IsGigabyte = (rootObject.ContainsKey("IsGigabyte") == true) ? rootObject.Value<bool>("IsGigabyte") : false;
                IsGigabyteMotherboard = (rootObject.ContainsKey("IsGigabyteMotherboard") == true) ? rootObject.Value<bool>("IsGigabyteMotherboard") : true;
                IsGigabyteGpu = (rootObject.ContainsKey("IsGigabyteGpu") == true) ? rootObject.Value<bool>("IsGigabyteGpu") : true;

                IsLHM = (rootObject.ContainsKey("IsLHM") == true) ? rootObject.Value<bool>("IsLHM") : true;
                IsLHMCpu = (rootObject.ContainsKey("IsLHMCpu") == true) ? rootObject.Value<bool>("IsLHMCpu") : true;
                IsLHMMotherboard = (rootObject.ContainsKey("IsLHMMotherboard") == true) ? rootObject.Value<bool>("IsLHMMotherboard") : true;
                IsLHMGpu = (rootObject.ContainsKey("IsLHMGpu") == true) ? rootObject.Value<bool>("IsLHMGpu") : false;
                IsLHMContolled = (rootObject.ContainsKey("IsLHMContolled") == true) ? rootObject.Value<bool>("IsLHMContolled") : true;
                IsLHMStorage = (rootObject.ContainsKey("IsLHMStorage") == true) ? rootObject.Value<bool>("IsLHMStorage") : true;
                IsLHMMemory = (rootObject.ContainsKey("IsLHMMemory") == true) ? rootObject.Value<bool>("IsLHMMemory") : true;

                IsOHM = (rootObject.ContainsKey("IsOHM") == true) ? rootObject.Value<bool>("IsOHM") : false;
                IsOHMCpu = (rootObject.ContainsKey("IsOHMCpu") == true) ? rootObject.Value<bool>("IsOHMCpu") : true;
                IsOHMMotherboard = (rootObject.ContainsKey("IsOHMMotherboard") == true) ? rootObject.Value<bool>("IsOHMMotherboard") : true;
                IsOHMGpu = (rootObject.ContainsKey("IsOHMGpu") == true) ? rootObject.Value<bool>("IsOHMGpu") : false;
                IsOHMContolled = (rootObject.ContainsKey("IsOHMContolled") == true) ? rootObject.Value<bool>("IsOHMContolled") : false;
                IsOHMStorage = (rootObject.ContainsKey("IsOHMStorage") == true) ? rootObject.Value<bool>("IsOHMStorage") : false;
                IsOHMMemory = (rootObject.ContainsKey("IsOHMMemory") == true) ? rootObject.Value<bool>("IsOHMMemory") : false;

                IsNvAPIWrapper = (rootObject.ContainsKey("IsNvAPIWrapper") == true) ? rootObject.Value<bool>("IsNvAPIWrapper") : true;
                IsDimm = (rootObject.ContainsKey("IsDimm") == true) ? rootObject.Value<bool>("IsDimm") : false;
                IsKrakenLCD = (rootObject.ContainsKey("IsKrakenLCD") == true) ? rootObject.Value<bool>("IsKrakenLCD") : true;
                IsKraken = (rootObject.ContainsKey("IsKraken") == true) ? rootObject.Value<bool>("IsKraken") : true;
                IsCLC = (rootObject.ContainsKey("IsCLC") == true) ? rootObject.Value<bool>("IsCLC") : true;
                IsRGBnFC = (rootObject.ContainsKey("IsRGBnFC") == true) ? rootObject.Value<bool>("IsRGBnFC") : true;
                IsHWInfo = (rootObject.ContainsKey("IsHWInfo") == true) ? rootObject.Value<bool>("IsHWInfo") : false;

                IsAnimation = (rootObject.ContainsKey("IsAnimation") == true) ? rootObject.Value<bool>("IsAnimation") : true;
                IsFahrenheit = (rootObject.ContainsKey("IsFahrenheit") == true) ? rootObject.Value<bool>("IsFahrenheit") : false;
                IsMinimized = (rootObject.ContainsKey("IsMinimized") == true) ? rootObject.Value<bool>("IsMinimized") : false;

                DelayTime = (rootObject.ContainsKey("DelayTime") == true) ? rootObject.Value<int>("DelayTime") : 0;
            }
            catch
            {
                return false;
            }
            return true;
        }

        public void write()
        {
            try
            {
                var rootObject = new JObject();
                rootObject["Interval"] = Interval;
                
                rootObject["IsGigabyte"] = IsGigabyte;
                rootObject["IsGigabyteMotherboard"] = IsGigabyteMotherboard;
                rootObject["IsGigabyteGpu"] = IsGigabyteGpu;

                rootObject["IsLHM"] = IsLHM;
                rootObject["IsLHMCpu"] = IsLHMCpu;
                rootObject["IsLHMMotherboard"] = IsLHMMotherboard;
                rootObject["IsLHMGpu"] = IsLHMGpu;
                rootObject["IsLHMContolled"] = IsLHMContolled;
                rootObject["IsLHMStorage"] = IsLHMStorage;
                rootObject["IsLHMMemory"] = IsLHMMemory;

                rootObject["IsOHM"] = IsOHM;
                rootObject["IsOHMCpu"] = IsOHMCpu;
                rootObject["IsOHMMotherboard"] = IsOHMMotherboard;
                rootObject["IsOHMGpu"] = IsOHMGpu;
                rootObject["IsOHMContolled"] = IsOHMContolled;
                rootObject["IsOHMStorage"] = IsOHMStorage;
                rootObject["IsOHMMemory"] = IsOHMMemory;

                rootObject["IsNvAPIWrapper"] = IsNvAPIWrapper;
                rootObject["IsDimm"] = IsDimm;
                rootObject["IsKrakenLCD"] = IsKrakenLCD;
                rootObject["IsKraken"] = IsKraken;
                rootObject["IsCLC"] = IsCLC;
                rootObject["IsRGBnFC"] = IsRGBnFC;
                rootObject["IsHWInfo"] = IsHWInfo;

                rootObject["IsAnimation"] = IsAnimation;
                rootObject["IsFahrenheit"] = IsFahrenheit;
                rootObject["IsMinimized"] = IsMinimized;

                rootObject["DelayTime"] = DelayTime;

                File.WriteAllText(mOptionFileName, rootObject.ToString());
            }
            catch {}
        }

    }
}
