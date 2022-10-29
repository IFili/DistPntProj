using Cargo4You_Project.Models;

namespace Cargo4You_Project.Repositories
{
    public interface IMaltaShip
    {
        public void GetParcelVolume(ParcelSpecs parcelSpecs)
        {
            parcelSpecs.ParcelVolume = (parcelSpecs.ParcelWidth * parcelSpecs.ParcelHeight * parcelSpecs.ParcelDepth);
        }

        public void GetParcelTotalCost(ParcelSpecs parcelSpecs)
        {
            //minimum volume of 500cm3 not implemented atm
            //minimum weight of 10kg not implemented atm

            if (parcelSpecs.ParcelVolume <= 500 && parcelSpecs.ParcelVolume <= 1000 && parcelSpecs.ParcelWeight == 10)
            {
                parcelSpecs.ParcelPrice = 9.50F;
                //Price package: volume 1
            }

            else if (parcelSpecs.ParcelVolume <= 500 && parcelSpecs.ParcelVolume <= 1000 && parcelSpecs.ParcelWeight > 10 && parcelSpecs.ParcelWeight <= 20)
            {
                parcelSpecs.ParcelPrice = 16.99F;
                //Price package: weight 1
            }

            else if (parcelSpecs.ParcelVolume > 1000 && parcelSpecs.ParcelVolume <= 2000 && parcelSpecs.ParcelWeight > 20 && parcelSpecs.ParcelWeight <= 30)
            {
                parcelSpecs.ParcelPrice = 33.99F;
                //Price package: weight 2




            }
            else if (parcelSpecs.ParcelVolume <= 2000 && parcelSpecs.ParcelWeight > 30 && parcelSpecs.ParcelWeight <= 43)
            {
                //Package price: weight 3, range of 30kg till 43kg , this range is the point of costing less than Volume3 where it makes sense to exist

                float getPrice(float _parcelPrice)
                {
                    float baseCost = 43.99F;
                    float priceRangeCalc = 0.41F;
                    // needs fixing, cant be like this / too long

                    if (parcelSpecs.ParcelWeight > 30 && parcelSpecs.ParcelWeight < 31) { _parcelPrice = baseCost; }
                    if (parcelSpecs.ParcelWeight >= 31 && parcelSpecs.ParcelWeight < 32) { _parcelPrice = priceRangeCalc + baseCost; }
                    if (parcelSpecs.ParcelWeight >= 32 && parcelSpecs.ParcelWeight < 33) { _parcelPrice = 2 * priceRangeCalc + baseCost; }
                    if (parcelSpecs.ParcelWeight >= 33 && parcelSpecs.ParcelWeight < 34) { _parcelPrice = 3 * priceRangeCalc + baseCost; }
                    if (parcelSpecs.ParcelWeight >= 34 && parcelSpecs.ParcelWeight < 35) { _parcelPrice = 4 * priceRangeCalc + baseCost; }
                    if (parcelSpecs.ParcelWeight >= 35 && parcelSpecs.ParcelWeight < 36) { _parcelPrice = 5 * priceRangeCalc + baseCost; }
                    if (parcelSpecs.ParcelWeight >= 36 && parcelSpecs.ParcelWeight < 37) { _parcelPrice = 6 * priceRangeCalc + baseCost; }
                    if (parcelSpecs.ParcelWeight >= 37 && parcelSpecs.ParcelWeight < 38) { _parcelPrice = 7 * priceRangeCalc + baseCost; }
                    if (parcelSpecs.ParcelWeight >= 38 && parcelSpecs.ParcelWeight < 39) { _parcelPrice = 8 * priceRangeCalc + baseCost; }
                    if (parcelSpecs.ParcelWeight >= 39 && parcelSpecs.ParcelWeight < 40) { _parcelPrice = 9 * priceRangeCalc + baseCost; }
                    if (parcelSpecs.ParcelWeight >= 40 && parcelSpecs.ParcelWeight < 41) { _parcelPrice = 10 * priceRangeCalc + baseCost; }
                    if (parcelSpecs.ParcelWeight >= 41 && parcelSpecs.ParcelWeight < 42) { _parcelPrice = 11 * priceRangeCalc + baseCost; }
                    if (parcelSpecs.ParcelWeight >= 42 && parcelSpecs.ParcelWeight <= 43) { _parcelPrice = 12 * priceRangeCalc + baseCost; }


                    parcelSpecs.ParcelPrice = _parcelPrice;
                    return getPrice(parcelSpecs.ParcelPrice);

                }
            }

            else if (parcelSpecs.ParcelVolume > 2000 && parcelSpecs.ParcelVolume <= 5000 && parcelSpecs.ParcelWeight == 44)
            {
                // Calculation is based off of Volume 3 which costs 48,50 
                // as well as Weight 3 which costs 43.33 (for 30kg) and 0.41 for every kg till infinity (confirmed on meeting)
                // 44 kg is the calculation where cost of volume & cost of weight meet.
                // Weight 3 will continue in the next else if , and start from >44


                parcelSpecs.ParcelPrice = 48.50F;
            }    


        }





    }
}
