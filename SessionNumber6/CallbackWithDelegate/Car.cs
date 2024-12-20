using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackWithDelegate 
{
    
    internal class Car
    {
        public string DriverName { get; set; }
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }

        private bool _CarExploaded = false;

        public EventHandler<CarEventArgs> CarExpoloded;

        //public void Add_CarExploded(NotifyDriverDelegate notifyDriver)
        //{

        //    CarExpoloded += notifyDriver;
        //    //CarExpoloded = Delegate.Combine(CarExpoloded, notifyDriver) as NotifyDriverDelegate;
        //}

        //public void Remove_CarExploded(NotifyDriverDelegate notifyDriver)
        //{
        //    CarExpoloded -= notifyDriver;
        //    //CarExpoloded = Delegate.Remove(CarExpoloded, notifyDriver) as NotifyDriverDelegate;
        //}


        public EventHandler<CarEventArgs> CarAboutToExplode;
        //public void RegisterCarAboutToExplode(NotifyDriverDelegate notifyDriver)
        //{
        //    CarAboutToExplode += notifyDriver;
        //}
        //public void UnRegisterCarAboutToExplode(NotifyDriverDelegate notifyDriver)
        //{
        //    CarAboutToExplode -= notifyDriver;
        //}
        public Car(string driverName, int currentSpeed, int maxSpeed)
        {
            DriverName = driverName;
            CurrentSpeed = currentSpeed;
            MaxSpeed = maxSpeed;
        }

        public void Accelerate(int speed)
        {
            if (_CarExploaded)
            {
                CarExpoloded?.Invoke(this, new CarEventArgs("The car Expoloded"));
            }

            if (MaxSpeed - CurrentSpeed == 10)
            {
                CarAboutToExplode?.Invoke(this,new CarEventArgs("The car is about to explod !!!"));    
            }
            CurrentSpeed += speed;
            if (CurrentSpeed > MaxSpeed)
            {
                _CarExploaded = true;
            }
            else
            {
                Console.WriteLine($"The current Car speed is {CurrentSpeed}");
            }
        }
    }
}
