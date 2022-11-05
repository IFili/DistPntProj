using System;
using System.ComponentModel.DataAnnotations;
using Cargo4You_Project.Repositories;

namespace Cargo4You_Project.Models
{
    public class Parcel
    {
        public int ParcelId { get; set; }

        [Required]
        public string ParcelName { get; set; } // se misli koj supplier, fix it

        //public string ParcelCourier { get; set; } = default!; //nz so e ova fix it
        // ParcelCourier not needed, as those valeus will be provided by interfaces

        [Required]
        public int ParcelWidth { get; set; }

        [Required]
        public int ParcelHeight { get; set; }

        [Required]
        public int ParcelDepth { get; set; }

        [Required]
        public float ParcelWeight { get; set; }

        
        public enum CourierType
        {
            [Display(Name = "Cargo4You")]
            Cargo4You = 1,

            [Display(Name = "ShipFaster")]
            ShipFaster = 2,

            [Display(Name = "MaltaShip")]
            MaltaShip=3

        }

       
}
   


}
