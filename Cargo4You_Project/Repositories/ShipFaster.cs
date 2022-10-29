using Cargo4You_Project.Models;

namespace Cargo4You_Project.Repositories
{
    public class ShipFaster : IShipFaster
    {
        public float calculatePriceByVolume(ParcelSpecs parcelSpecs, float parcelPriceByVolume)
        {
            float parcelVolume = parcelSpecs.ParcelHeight * parcelSpecs.ParcelDepth * parcelSpecs.ParcelWidth;

            if (parcelVolume <= 1000)
            {
                parcelPriceByVolume = 11.99F;
            }

            else if (parcelVolume > 1000 && parcelVolume <= 1700) // how do i validate this? do i do this for other couriers as well?
            {
                parcelPriceByVolume = 20F;
            }
            else { throw new ArgumentOutOfRangeException("{0}, Parcel volume exceeds maximum limits, please select another courier "); }

            return parcelPriceByVolume;
        }



        public float calculatePriceByWeight(ParcelSpecs parcelSpecs, float parcelPricebyWeight)
        {
            if (parcelSpecs.ParcelWeight > 10 && parcelSpecs.ParcelWeight <= 15)
            {
                parcelPricebyWeight = 16.50F;
            }
            else if (parcelSpecs.ParcelWeight > 15 && parcelSpecs.ParcelWeight <= 25)
            {
                parcelPricebyWeight = 36.50F;
            }
            else if (parcelSpecs.ParcelWeight > 25 && parcelSpecs.ParcelWeight<=30) // validation for the maximum of 30kg needed
            {

                float rate = 0.417F;
                float basePrice = 40F;
                int rateMultiplier = 1;
                float totalPrice = 0F; // had to initiialize it with value, else it returned an error


                while(parcelSpecs.ParcelWeight <=30)
                {
                    totalPrice = basePrice + (rateMultiplier * rate);
                    rateMultiplier++;
                    parcelSpecs.ParcelWeight++;
                    // this will list all of the values (prices) between 25 & 30 kg, i hope to add some logic where inputted value gets compared to listed values

                    
                }

                parcelPricebyWeight = totalPrice;
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

