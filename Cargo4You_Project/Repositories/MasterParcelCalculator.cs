using Cargo4You_Project.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cargo4You_Project.Repositories
{
    public class MasterParcelCalculator
    {

        partial class TestCargo4You
        {
            public float calculatePriceBylVolume(Parcel parcel, float parcelPriceByVolume)
            {

                float parcelVolume = parcel.ParcelHeight * parcel.ParcelWidth * parcel.ParcelDepth;



                if (parcelVolume <= 1000) { return parcelPriceByVolume = 10; }
                else if (parcelVolume > 1000 && parcelVolume <= 1700) { return parcelPriceByVolume = 20; }
                else { throw new ArgumentOutOfRangeException("{0}, Parcel volume exceeds maximum limits, please select another courier "); }

            }
            public float calculatePriceByWeight(Parcel parcel, float parcelPricebyWeight)
            {
                //float parcelPrice;

                if (parcel.ParcelWeight <= 2)
                {
                    parcelPricebyWeight = 15;
                }


                else if (parcel.ParcelWeight > 2 && parcel.ParcelWeight <= 15)
                {
                    parcelPricebyWeight = 18;
                }


                else if (parcel.ParcelWeight > 15 && parcel.ParcelWeight <= 20)
                {
                    parcelPricebyWeight = 35;
                }

                else { throw new ArgumentOutOfRangeException("{0}, Parcel weight exceeds maximum limits, please select another courier "); }

                return parcelPricebyWeight;

            }
            public float calculateTotalPrice(Parcel parcel, float parcelPriceByVolume, float parcelPricebyWeight, float testTotalPrice)
            {
                calculatePriceBylVolume(parcel, parcelPriceByVolume);
                calculatePriceByWeight(parcel, parcelPricebyWeight);


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

        partial class TestShipFaster
        {
            public float calculatePriceByVolume(Parcel parcel, float parcelPriceByVolume)
            {
                float parcelVolume = parcel.ParcelHeight * parcel.ParcelDepth * parcel.ParcelWidth;

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
            public float calculatePriceByWeight(Parcel parcel, float parcelPricebyWeight)
            {
                if (parcel.ParcelWeight > 10 && parcel.ParcelWeight <= 15)
                {
                    parcelPricebyWeight = 16.50F;
                }
                else if (parcel.ParcelWeight > 15 && parcel.ParcelWeight <= 25)
                {
                    parcelPricebyWeight = 36.50F;
                }
                else if (parcel.ParcelWeight > 25 && parcel.ParcelWeight <= 30) // validation for the maximum of 30kg needed
                {

                    float rate = 0.417F;
                    float basePrice = 40F;
                    int rateMultiplier = 1;
                    float totalPrice = 0F; // had to initiialize it with value, else it returned an error


                    while (parcel.ParcelWeight <= 30)
                    {
                        totalPrice = basePrice + (rateMultiplier * rate);
                        rateMultiplier++;
                        parcel.ParcelWeight++;
                        // this will list all of the values (prices) between 25 & 30 kg, i hope to add some logic where inputted value gets compared to listed values


                    }

                    parcelPricebyWeight = totalPrice;
                }
                else { throw new ArgumentOutOfRangeException("{0}, Parcel weight exceeds maximum limits, please select another courier "); }

                return parcelPricebyWeight;









            }

            public float calculateTotalPrice(Parcel parcel, float parcelPriceByVolume, float parcelPricebyWeight, float testTotalPrice)
            {
                calculatePriceByVolume(parcel, parcelPriceByVolume);
                calculatePriceByWeight(parcel, parcelPricebyWeight);

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
}
