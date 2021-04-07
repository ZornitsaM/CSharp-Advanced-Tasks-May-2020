using System;
using System.Collections.Generic;
using System.Text;

namespace _7._Raw_Data___Second
{
    public class Engine
    {
        private int engineSpeed;
        private int enginPower;

        public Engine(int engineSpeed, int enginePower)
        {
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
        }

        public int EngineSpeed
        {
            get { return engineSpeed; }
            set { engineSpeed = value; }
        }

        public int EnginePower
        {
            get { return enginPower; }
            set { enginPower = value; }
        }
    }
}
