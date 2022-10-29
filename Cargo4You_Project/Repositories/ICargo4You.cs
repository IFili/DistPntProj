using System;
using Cargo4You_Project.Models;


namespace Cargo4You_Project.Repositories
{
    public interface ICargo4You
    {
        // input empty methods here

        public float calculatePriceBylVolume(ParcelSpecs parcelSpecs,float parcelPriceByVolume);

       // public float calculatePriceByVolume();

        public float calculatePriceByWeight(ParcelSpecs parcelSpecs , float parcelPricebyWeight);

        //void calculateTotalPrice(ParcelSpecs parcelSpecs, int totalPrice);

        public float calculateTotalPrice(ParcelSpecs parcelSpecs, float parcelPriceByVolume, float parcelPricebyWeight, float testTotalPrice);
    }
}
