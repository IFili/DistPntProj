using Cargo4You_Project.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cargo4You_Project.Repositories
{
    public class MaltaShip : IMaltaShip
    {
        public float calculatePriceByVolume(ParcelSpecs parcelSpecs, float parcelPriceByVolume)
        {
            float parcelVolume = parcelSpecs.ParcelHeight & parcelSpecs.ParcelDepth * parcelSpecs.ParcelWidth;


            //should some validation for minimum of 500 be here or in front end?
            //if(parcelvolume < 500) {throw argument out of range exception

            if (parcelVolume < 1000) // this would be an else if

            {
                 parcelPriceByVolume = 9.50F;
            }
            else if (parcelVolume > 1000 && parcelVolume <= 2000)
            {
                 parcelPriceByVolume = 19.50F;


            }

            else if (parcelVolume > 2000 && parcelVolume <= 5000)
            {
                 parcelPriceByVolume = 48.50F;

            }

            else
            {
                 parcelPriceByVolume = 147.50F;
            }

            return parcelPriceByVolume;
           
        }

        public float calculatePriceByWeight(ParcelSpecs parcelSpecs, float parcelPricebyWeight)
        {

            //if(parcelspecs.parcelweight<10) {throw outofrangeexception)
            if(parcelSpecs.ParcelWeight>10 && parcelSpecs.ParcelWeight <=20)
            {
                parcelPricebyWeight = 16.50F;
            }

            else if(parcelSpecs.ParcelWeight > 20 && parcelSpecs.ParcelWeight <=30)
            {
                parcelPricebyWeight = 33.99F;
            }
            else if(parcelSpecs.ParcelWeight>30 )
            {

                float basePrice = 43.99F; // missing calculation of 0.41
                float rate = 0.41F;
                int rateMultiplier = 0; // if this is 0 it will calculate price for weights between >30 & <31 kg , where they  dont need to pay 0.41?
                float totalPrice = 0F;

                // some sort of for loop where any kilogram over 31 adds 0.41 to the sum of 43.99
                while (parcelSpecs.ParcelWeight <=55) // any parcel >30 over 25 kg , 30+25 = 55 
                {
                    totalPrice = basePrice + (rateMultiplier * rate);
                    rateMultiplier++;
                    parcelSpecs.ParcelWeight++;
                    // DP said parcel can weigh above 55kg , that in theory means this courier can ship to infinity?
                }
            }
            
            return parcelPricebyWeight; 
        }

        public float calculateTotalPrice(ParcelSpecs parcelSpecs, float parcelPriceByVolume, float parcelPricebyWeight, float testTotalPrice)
        {
            calculatePriceByVolume(parcelSpecs, parcelPriceByVolume);
            calculatePriceByWeight(parcelSpecs, parcelPricebyWeight);

            if (parcelPriceByVolume > parcelPricebyWeight)
            {
                 testTotalPrice = parcelPriceByVolume;
            }

            else
            {
                 testTotalPrice = parcelPricebyWeight;
            }
            return testTotalPrice;
        }
    }
}
