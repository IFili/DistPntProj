using Cargo4You_Project.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Cargo4You_Project.Repositories
{
    public   class Cargo4You: ICargo4You
    {
       

        //maybe needs to be virtual
        // input logic of methods here
        //const int defaultVolumeValue = 1000;

        /* public  float calculateParcelVolume(float parcelVolume , ParcelSpecs parcelSpecs )
         {

         }*/
        //This is method for calculating price
        //Params: Parcel - this is the class that getthe courier details
        //Return type: float
        public float calculatePriceBylVolume(Parcel parcel, float parcelPriceByVolume) //zapamti da vratis pricevolume  // shoult float parcelVolume be a ref? 
        {
           
            float parcelVolume = parcel.ParcelHeight * parcel.ParcelWidth * parcel.ParcelDepth;

            //return parcelVolume
            
            if( parcelVolume<=1000) { return parcelPriceByVolume = 10; }
             else if(parcelVolume >1000 && parcelVolume<=1700) { return parcelPriceByVolume = 20; }
            else { throw new ArgumentOutOfRangeException("{0}, Parcel volume exceeds maximum limits, please select another courier "); } 
            


            // this is the same for all 3 suppliers, need to figgure out how not to have it in 3 different classes
        }

       
       

        /*public float calculatePriceByVolume(float price, float parcelVolume) 
        {
            parcelVolume.calculateParcelVolume();
           


        }*/

        public float calculatePriceByWeight(Parcel parcel, float parcelPricebyWeight)
        {
            //float parcelPrice;

            if (parcel.ParcelWeight <= 2)
            {
                 parcelPricebyWeight = 15;
            }


            else if (parcel.ParcelWeight > 2 && parcel.ParcelWeight<=15) 
            { 
                 parcelPricebyWeight = 18; 
            }
           
            
              else if(parcel.ParcelWeight > 15 && parcel.ParcelWeight<=20)
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
}
