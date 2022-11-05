using System;
using Cargo4You_Project.Models;


namespace Cargo4You_Project.Repositories
{
    public interface ICargo4You
    {
        // input empty methods here

        public float calculatePriceBylVolume(Parcel parcel, float parcelPriceByVolume);

       // public float calculatePriceByVolume();

        public float calculatePriceByWeight(Parcel parcel, float parcelPricebyWeight);

        //void calculateTotalPrice(ParcelSpecs parcelSpecs, int totalPrice);

        public float calculateTotalPrice(Parcel parcel, float parcelPriceByVolume, float parcelPricebyWeight, float testTotalPrice);
        //object calculateTotalPrice(); // is this the fix?



       
    
    }
}
