using Cargo4You_Project.Models;

namespace Cargo4You_Project.Repositories
{
    public interface ICargo4YouMultipleMethods
    {
        public void GetParcelVolume(ParcelSpecs parcelSpecs)
        //are we sure it has to be void?
        //figure out if we want to return
        {
            parcelSpecs.ParcelVolume = (parcelSpecs.ParcelWidth * parcelSpecs.ParcelHeight * parcelSpecs.ParcelDepth);
        }

        public void CalculateParcelPriceByVolume(ParcelSpecs parcelSpecs)
        {
            if (parcelSpecs.ParcelVolume <= 1000)
            {
                parcelSpecs.ParcelPrice = 10;
            }
            else if (parcelSpecs.ParcelVolume > 1000 && parcelSpecs.ParcelVolume <= 2000)
            {
                parcelSpecs.ParcelPrice = 20;

            }
            else
            {
                throw new ArgumentOutOfRangeException(String.Format("{0} The parcel Volume is larger than what Cargo4You is able to ship," +
                  " please enter a Volume smaller than 2000cm3 or select a different supplier"));

                //figgure out what to do for negative or null values
            }
        }

          public void CalculateParcelPriceByWeight (ParcelSpecs parcelSpecs)
        {
            if(parcelSpecs.ParcelWeight <=2)
            { parcelSpecs.ParcelPrice = 15; }

            else if (parcelSpecs.ParcelWeight>2 && parcelSpecs.ParcelWeight<=15)
            { parcelSpecs.ParcelPrice = 18; }

            else if (parcelSpecs.ParcelWeight >15 && parcelSpecs.ParcelWeight<=20)
            {
                parcelSpecs.ParcelPrice = 35;
            }

            else
            {
                throw new ArgumentOutOfRangeException(String.Format("{0} The parcel Weight is larger than what Cargo4You is able to ship,"
                + "please enter a Weight smaller than 25kg or select a different supplier"));
            }
        }


       // some sort of method that checks  weight & volume (provided by user) against  values of interface
        


       

    }
}
