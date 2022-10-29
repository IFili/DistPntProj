using Cargo4You_Project.Models;

namespace Cargo4You_Project.Repositories
{
    public interface IMaltaShip
    {

        public float calculatePriceByVolume(ParcelSpecs parcelSpecs, float parcelPriceByVolume);


        public float calculatePriceByWeight(ParcelSpecs parcelSpecs, float parcelPricebyWeight);

        public float calculateTotalPrice(ParcelSpecs parcelSpecs, float parcelPriceByVolume, float parcelPricebyWeight, float testTotalPrice);


    }
}
       
