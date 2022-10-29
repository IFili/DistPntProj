using Cargo4You_Project.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Cargo4You_Project.Repositories
{
    public   class Cargo4You: ICargo4You
    {
        //maybe needs to be virtual
        // input logic of methods here

        
        /* public  float calculateParcelVolume(float parcelVolume , ParcelSpecs parcelSpecs )
         {

         }*/

        public float calculatePriceBylVolume(ParcelSpecs parcelSpecs, float parcelPriceByVolume) //zapamti da vratis pricevolume  // shoult float parcelVolume be a ref? 
        {
           
            float parcelVolume = parcelSpecs.ParcelHeight * parcelSpecs.ParcelWidth * parcelSpecs.ParcelDepth;

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

        public float calculatePriceByWeight(ParcelSpecs parcelSpecs,float parcelPricebyWeight)
        {
            //float parcelPrice;

            if (parcelSpecs.ParcelWeight <= 2)
            {
                 parcelPricebyWeight = 15;
            }


            else if (parcelSpecs.ParcelWeight > 2 && parcelSpecs.ParcelWeight<=15) 
            { 
                 parcelPricebyWeight = 18; 
            }
           
            
              else if(parcelSpecs.ParcelWeight > 15 && parcelSpecs.ParcelWeight<=20)
            {
                 parcelPricebyWeight = 35; 
            }

            else { throw new ArgumentOutOfRangeException("{0}, Parcel weight exceeds maximum limits, please select another courier "); }

            return parcelPricebyWeight;


        }

        public float calculateTotalPrice(ParcelSpecs parcelSpecs, float parcelPriceByVolume, float parcelPricebyWeight, float testTotalPrice)
        {
            calculatePriceBylVolume(parcelSpecs, parcelPriceByVolume); 
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
