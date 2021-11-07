using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial2_Parqueadero.Models
{
    public class ParkingSpot
    {
        private Vehicle vehicle;
        private Driver driver;
        private DateTime arriveTime;
        private DateTime leaveTime;
        private Boolean isOccupied;

        public ParkingSpot(Vehicle vehicle, Driver driver, DateTime arriveTime, DateTime leaveTime, Boolean isOccupied)
        {
            this.Vehicle = vehicle;
            this.Driver = driver;
            this.ArriveTime = arriveTime;
            this.LeaveTime = leaveTime;
            this.IsOccupied = isOccupied;
        }

        public Vehicle Vehicle { get => vehicle; set => vehicle = value; }
        public Driver Driver { get => driver; set => driver = value; }
        public DateTime ArriveTime { get => arriveTime; set => arriveTime = value; }
        public DateTime LeaveTime { get => leaveTime; set => leaveTime = value; }
        public bool IsOccupied { get => isOccupied; set => isOccupied = value; }
    }
}