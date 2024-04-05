using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class__Virtual__Override.Models
{
    internal abstract class Vehicle
    {
        private string _factoryName;
        private string _model;
        private string _color;
        private double _driveTime;
        private double _drivePath;

        public string FactoryName {  get { return _factoryName; } set {  _factoryName = value; } }
        public string Model { get { return _model; } set { _model = value; } }
        public string Color { get { return _color; } set { _color = value; } }

        public double DriveTime
        {
            get
            {
                return _driveTime;
            }
            set
            {
                if(value > 0)
                {
                    _driveTime = value;
                }
            }
        }

        public double DrivePath
        {
            get
            {
                return _drivePath;
            }
            set
            {
                if (value > 0)
                {
                    _drivePath = value;
                }
            }
        }

        protected Vehicle(string factoryName, string model, string color, double driveTime, double drivePath)
        {
            FactoryName = factoryName;
            Model = model;
            Color = color;
            DriveTime = driveTime;
            DrivePath = drivePath;
        }

       
        public void AverageSpeed()
        {
            double averageSpeed = DrivePath / DriveTime;
            Console.WriteLine(averageSpeed);
        }


        public virtual void  GetInfo()
        {
            Console.WriteLine($"{FactoryName} {Model} {Color} {DriveTime} {DrivePath}");
        }
        
        public  virtual void ToString()
        {
            Console.WriteLine($"{FactoryName} {Model}");
        }

        public abstract void DefineNatureHarmness();


    }
}
