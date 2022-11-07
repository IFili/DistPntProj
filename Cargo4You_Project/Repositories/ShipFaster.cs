using Cargo4You_Project.Models;

namespace Cargo4You_Project.Repositories
{
    public class ShipFaster
    //at the moment float values trigger argument out of range, so front-end doesnt take floats
    {
        private float totalPrice;
        public float calculatePriceByVolume(float volume)
        {
          

            if (volume <= 1000F)
            {
                return  11.99F;
            }

            else //if (volume > 1000F && volume <= 1700F) // how do i validate this? do i do this for other couriers as well?
            {
                
                return 20F;
            }
          //  else { throw new ArgumentOutOfRangeException("{0}, Parcel volume exceeds maximum limits, please select another courier "); }

            
        }



        public float calculatePriceByWeight(float weight)
        {
            if (weight > 10 && weight <= 15)
            {
                return  16.50F;
            }
            else if (weight > 15 && weight <= 25)
            {
                return 36.50F;
            }
            /* else if (weight > 25 && weight <= 30) // validation for the maximum of 30kg needed
             {

                 float rate = 0.417F;
                 float basePrice = 40F;
                 int rateMultiplier = 1;
                 float totalPrice = 0F; // had to initiialize it with value, else it returned an error


                 while(weight <= 30)
                 {
                     totalPrice = basePrice + (rateMultiplier * rate);
                     rateMultiplier++;
                     weight++;
                     // this will list all of the values (prices) between 25 & 30 kg, i hope to add some logic where inputted value gets compared to listed values


                 }*/

            else if (weight > 25F && weight <= 30F)
            {
                float weightRate = (weight - 25F);
                float rate = 0.417F;
                float priceRate = 40F + (rate * weightRate);

                return priceRate;
            }

            else { throw new ArgumentOutOfRangeException("{0}, Parcel weight exceeds maximum limits, please select another courier "); 



        }











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

