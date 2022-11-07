using Cargo4You_Project.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Cargo4You_Project.Repositories
{
    public   class Cargo4You 
    {
        private float totalPrice; 


        public float calculatePriceBylVolume(float volume) 
        {
           
            if(volume <= 1000)
            {
                return 10;
            }
            else if(volume > 1000 && volume <=1700)
            {
                return 20;
            }

            else
            {
                { throw new ArgumentOutOfRangeException("{0}, Parcel volume exceeds maximum limits, please select another courier "); }
            }

        }






        public float calculatePriceByWeight(float weight)
        {


            if (weight <= 2)
            {
                return 15;
            }


            else if (weight > 2 && weight <= 15)
            {
                return 18;
            }


            else if (weight > 15 && weight <= 20)
            {
                return 35;
            }

            else { throw new ArgumentOutOfRangeException("{0}, Parcel weight exceeds maximum limits, please select another courier "); }
        }

        public float calculateTotalPrice(Parcel parcel)
        {

            float ParcelVolumePrice = calculatePriceBylVolume(parcel.ParcelHeight * parcel.ParcelWidth * parcel.ParcelDepth);
            float ParcelWeightPrice = calculatePriceByWeight(parcel.ParcelWeight);



            if (ParcelVolumePrice > ParcelWeightPrice)
            {
                totalPrice = ParcelVolumePrice;
            }

            else
            {
                totalPrice = ParcelWeightPrice;
            }

            return totalPrice;

        }


    }




}

