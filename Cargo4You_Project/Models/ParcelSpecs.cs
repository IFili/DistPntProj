using System;
using Cargo4You_Project.Repositories;

namespace Cargo4You_Project.Models
{
    public class ParcelSpecs  
    {
        public int ParcelId { get; set; }

        //public string ParcelCourier { get; set; } = default!; //nz so e ova fix it
        // ParcelCourier not needed, as those valeus will be provided by interfaces

        public int ParcelWidth { get; set; }

        public int ParcelHeight { get; set; }

        public int ParcelDepth { get; set; }

        public float ParcelWeight { get; set; }



        
    

        
    }

    
}
