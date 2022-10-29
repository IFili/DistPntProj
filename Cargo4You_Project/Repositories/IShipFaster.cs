using Cargo4You_Project.Models;

namespace Cargo4You_Project.Repositories
{
    public interface IShipFaster
    {
        public void GetParcelVolume(ParcelSpecs parcelSpecs)
        {
            parcelSpecs.ParcelVolume = (parcelSpecs.ParcelWidth * parcelSpecs.ParcelHeight * parcelSpecs.ParcelDepth);
        }
        

        public float GetParcelTotalCost(ParcelSpecs parcelSpecs)
        {
            // ^- i think this shouldn`t be void

           // if (parcelSpecs.ParcelWeight<10) { throw new ArgumentOutOfRangeException("{0}, Parcel below the minimum weight shipped by ShipFaster, please enter a weight greater than 10kg or select a different supplier"); };
            if(parcelSpecs.ParcelVolume <= 1000 && parcelSpecs.ParcelWeight == 10)
            {
                parcelSpecs.ParcelPrice = 11.99F;
                //Price Package: Volume 1 
                return parcelSpecs.ParcelPrice;
            }
            else if( parcelSpecs.ParcelVolume <= 1000 && parcelSpecs.ParcelWeight>10 && parcelSpecs.ParcelWeight  <= 15)
            {
                parcelSpecs.ParcelPrice = 16.50F;
                //Price Package: Weight 1
                return parcelSpecs.ParcelPrice;
            }
            else if (parcelSpecs.ParcelVolume >1000 && parcelSpecs.ParcelVolume <=1700 && parcelSpecs.ParcelWeight <=15)
            {
                parcelSpecs.ParcelPrice = 21.99F;
                //Price Package: Volume 2
                return parcelSpecs.ParcelPrice;
            }
            else if (parcelSpecs.ParcelVolume <=1700 && parcelSpecs.ParcelWeight>15 && parcelSpecs.ParcelWeight<=25)
            {
                parcelSpecs.ParcelPrice = 36.50F;
                //Price Package: Weight 2
                return parcelSpecs.ParcelPrice;
            }

            else if(parcelSpecs.ParcelVolume<=1700 && parcelSpecs.ParcelWeight>25 && parcelSpecs.ParcelWeight<=30)
            {
                //needs to be done better.. put in place for presentational purposes only 
                //make some sort of range-algo??
                float  getPrice(float _parcelPrice)
                {
                    int baseCost = 40;
                    float priceRangeCalc = 0.417F;
                    

                    if (parcelSpecs.ParcelWeight > 25 && parcelSpecs.ParcelWeight < 26) { _parcelPrice = baseCost; } 
                    if (parcelSpecs.ParcelWeight >= 26 && parcelSpecs.ParcelWeight < 27) { _parcelPrice = priceRangeCalc + baseCost; }
                    if (parcelSpecs.ParcelWeight >= 27 && parcelSpecs.ParcelWeight < 28) { _parcelPrice = 2 * priceRangeCalc + baseCost; }
                    if (parcelSpecs.ParcelWeight >= 28 && parcelSpecs.ParcelWeight < 29) { _parcelPrice = 3 * priceRangeCalc + baseCost; }
                    if (parcelSpecs.ParcelWeight >= 29 && parcelSpecs.ParcelWeight <= 30) { _parcelPrice = 4 * priceRangeCalc + baseCost; }



                    parcelSpecs.ParcelPrice = _parcelPrice;
                    return getPrice(parcelSpecs.ParcelPrice);

                    



                }
                parcelSpecs.ParcelPrice=getPrice(parcelSpecs.ParcelPrice);
                
                return parcelSpecs.ParcelPrice;
                










            }
        }    
            
        }
    }

