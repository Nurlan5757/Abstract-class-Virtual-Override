using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class__Virtual__Override.Models
{
    internal class Car : Vehicle
    {
        int _dorrCount;
        bool _isElctricCar;


        public int DorrCount
        {
            get { return _dorrCount; }
            set 
            { 
                if(value > 0 && value<6)
                {
                    _dorrCount=value;
                }
            }
        }
        public bool IsElctricCar
        {
            get { return _isElctricCar;}
            set { _isElctricCar=value; }
        }

        public Car (string factoryName, string model, string color, double driveTime, double drivePath) :base(factoryName, model, color, driveTime, drivePath)
        {
            
        }

        public override void DefineNatureHarmness()
        {
            if (IsElctricCar)
            {
                Console.WriteLine("low");
            }
            else 
            {
                Console.WriteLine("high");
            }
        }

        public override void GetInfo()
        {
            base.GetInfo();
        }

        public override void ToString()
        {
            base.ToString();
        }
    }
}
