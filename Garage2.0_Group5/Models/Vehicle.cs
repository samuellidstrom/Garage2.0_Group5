﻿namespace Garage2._0_Group5.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string LicenseNumber { get; set; }
        public string Color { get; set; }
        public string Brand{ get; set; }
        public string Model { get; set; }
        public string NoOfWheels { get; set; }
        public DateTime? TimeOfRegistration { get; set;  }

        public Vehicle()
        {
            TimeOfRegistration = DateTime.Now;
        }



        private DateTime timer;

        //public DateTime Timer
        //{
        //    get { return timer; }
        //    set {
        //        value = DateTime.Now - TimeOfRegistration;
        //        DateTime timer = value;                         
        //    }
        //}


    }

}
