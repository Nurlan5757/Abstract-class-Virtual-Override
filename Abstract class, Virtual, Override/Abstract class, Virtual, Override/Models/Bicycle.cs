using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class__Virtual__Override.Models
{
    internal class Bicycle:Vehicle
    {
        private string _type;


        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }


        public Bicycle (string factoryName, string model, string color, double driveTime, double drivePath) : base(factoryName, model, color, driveTime, drivePath)
        {

        }

        public override void DefineNatureHarmness()
        {
            Console.WriteLine("none");
        }

        public override void GetInfo()
        {
            base.GetInfo();
        }

        public override void ToString()
        {
           base .ToString();
        }
        
    }
}
