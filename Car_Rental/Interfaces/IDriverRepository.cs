using Car_Rental.Model.Write;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Rental.Interfaces
{
   public interface IDriverRepository
    {
        public void Add(Driver entity);
    }
}
