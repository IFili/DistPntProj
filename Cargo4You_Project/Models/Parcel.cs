using System;
using System.ComponentModel.DataAnnotations;
using Cargo4You_Project.Service;


namespace Cargo4You_Project.Models
{
    public class Parcel
    {
        public int ParcelId { get; set; }

        [Required(ErrorMessage ="Please select a courier")]
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
        public int ParcelWeight { get; set; }

        public float ParcelPrice { get; set; }

        public int ParcelVolume { get; set; } //in this version i had to store the volume

        public float ParcelPriceByVolume { get; set; } //in this version i had to store the price by volume
        public float ParcelPriceByWeight { get; set; } //in this version i had to store the price by volume








    }
   


}
