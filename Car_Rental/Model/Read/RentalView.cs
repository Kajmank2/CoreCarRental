using Car_Rental.Model.Write;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Car_Rental.Model.Read
{
  public  class RentalView
    {
        [Key]
        public Guid RentalId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime StopDateTime { get; set; }
        public decimal Total { get; set; }
        public Guid DriverId { get; set; }
        public Driver Driver { get; set; }
        public Car Car { get; set; }
        public Guid CarId { get; set; }
        public Status Status { get; set; }
        public string RegistrationNumber { get; set; }
        public double StartXPosition { get; set; }
        public double StartYPosition { get; set; }
        public double StopXPosition { get; set; }
        public double StopYPosition { get; set; }
    }
}
