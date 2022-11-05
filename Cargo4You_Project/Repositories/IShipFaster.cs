using Cargo4You_Project.Models;

namespace Cargo4You_Project.Repositories
{
    public interface IShipFaster
    {
        public float calculatePriceByVolume(Parcel parcel, float parcelPriceByVolume);


        public float calculatePriceByWeight(Parcel parcel, float parcelPricebyWeight);

        public float calculateTotalPrice(Parcel parcel, float parcelPriceByVolume, float parcelPricebyWeight, float testTotalPrice);
    }
}



