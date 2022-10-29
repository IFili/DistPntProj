using System;
using Cargo4You_Project.Repositories;

namespace Cargo4You_Project.Models
{
    public class ParcelSpecs : ICargo4YouOneMethod , IShipFaster , IMaltaShip 
    {
        public int ParcelId { get; set; }

        //public string ParcelCourier { get; set; } = default!; //nz so e ova fix it
        // ParcelCourier not needed, as those valeus will be provided by interfaces

        public int ParcelWidth { get; set; }

        public int ParcelHeight { get; set; }

        public int ParcelDepth { get; set; }

        public float ParcelWeight { get; set; }

        public int ParcelVolume { get; set; }
        // napravi go ova da bide metod, 
        // ^- this is calculated by Width * Height * Depth  

        public float ParcelPrice { get; set; }
        // na ova ne mu e mestoto tuka, tuku vo interfejsot za kurirot
        //Weight is a float because i anticipate a user inputing values with decimals, which will can alter final price of costing
        // we will need to calculate volume based on Width,Height,Depth, in an int called ParcelVolume


        
    

        
    }

    
}
