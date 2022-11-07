using Cargo4You_Project.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cargo4You_Project.Repositories
{
    public class MaltaShip
    {
        private float totalPrice;

        public float calculatePriceByVolume(float volume)
        {

            //at the moment float values trigger argument out of range, so front-end doesnt take floats

            //should some validation for minimum of 500 be here or in front end?
            if (volume < 500) { throw new ArgumentOutOfRangeException("{0}, Parcel volume below minimum limits, please select another courier "); }
            else if (volume < 1000) // this would be an else if

            {
                return 9.50F;
            }
            else if (volume > 1000 && volume <= 2000)
            {
                return 19.50F;


            }

            else if (volume > 2000 && volume <= 5000)
            {
                return 48.50F;

            }

            else
            {
                return 147.50F;
            }

           

        }

        public float calculatePriceByWeight(float weight)
        {

            if (weight < 10) { throw new ArgumentOutOfRangeException("{0}, Parcel weight below minimum limits, please select another courier "); } //validation

            else if (weight > 10 && weight <= 20)
            {
                return 16.50F;
            }

            else if (weight > 20 && weight <= 30)
            {
                return 33.99F;
            }
            /* else if (parcel.ParcelWeight > 30)
             {

                 float basePrice = 43.99F; // missing calculation of 0.41
                 float rate = 0.41F;
                 int rateMultiplier = 0; // if this is 0 it will calculate price for weights between >30 & <31 kg , where they  dont need to pay 0.41?
                 float totalPrice = 0F;

                 // some sort of for loop where any kilogram over 31 adds 0.41 to the sum of 43.99
                 while (parcel.ParcelWeight <= 55) // any parcel >30 over 25 kg , 30+25 = 55 
                 {
                     totalPrice = basePrice + (rateMultiplier * rate);
                     rateMultiplier++;
                     parcel.ParcelWeight++;
                     // DP said parcel can weigh above 55kg , that in theory means this courier can ship to infinity?
                 }*/

            else if(weight>30)
            {
                float extraWeight = (weight - 30F);
                float rate = 0.41F;
                float basePrice=43.99F;

                float priceRate = basePrice + (rate * extraWeight);

                return priceRate;

            }

            else {  throw new ArgumentException("{0{, price rate not implemented yet"); } // delete this once ^- is fixed
        }
            
           
        

        public float calculateTotalPrice(Parcel parcel)
        {
        float ParcelVolumePrice = calculatePriceByVolume(parcel.ParcelHeight * parcel.ParcelWidth * parcel.ParcelDepth);
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
