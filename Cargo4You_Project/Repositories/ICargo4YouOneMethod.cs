using System.Data;
using Cargo4You_Project.Models;



namespace Cargo4You_Project.Repositories
{
    public interface ICargo4YouOneMethod
    {
        public void getParcelVolume(ParcelSpecs parcelSpecs)
        {
            parcelSpecs.ParcelVolume = (parcelSpecs.ParcelWidth * parcelSpecs.ParcelHeight * parcelSpecs.ParcelDepth);
        }

        public int getParcelTotalCost(ParcelSpecs parcelSpecs)
        {

            //Total price shouldnt be calculated with only 1 method, seek further info
            // I want to assign a string value of which package the user is billed for, which will dynamically change in calculator. Useless feature?


            //price volume 1 cannot happen
            if (parcelSpecs.ParcelVolume <= 1000 && parcelSpecs.ParcelWeight <= 2)
            {
                //parcelvolume treba da bide metod
                //parcel price ne treba da e del od klasata parcelspecs, tuku treba da e metod
                //getParcelTotalCost treba da e overriden metod so ke nasleduva od interfesjot 
                // getParcelTotalCost treba da e definiran vo interfejsot (odnosno dobavuvacot)
                //vaka stedis na development time


                // parcelweight treba da e nested if , se sto e napisano dva pati isto treba da se najde nacin da se trgne
                // da se namali ili na parcel weight ili na parcel volume
                //gledaj da ne podavas 4 razlicni properties tuku 1 metod
                parcelSpecs.ParcelPrice = 15;
                //Price Package: Weight 1
                return 15;
            }
            else if (parcelSpecs.ParcelVolume <= 1000 && parcelSpecs.ParcelWeight <= 15)
            {
                parcelSpecs.ParcelPrice = 18;
                //Price Package: Weight 2
            }
            else if (parcelSpecs.ParcelVolume <= 2000 && parcelSpecs.ParcelWeight <= 15)
            {
                parcelSpecs.ParcelPrice = 20;
                //Price Package: Volume 2
            }
            else if (parcelSpecs.ParcelWidth <= 2000 && parcelSpecs.ParcelWeight > 15 && parcelSpecs.ParcelWeight <= 25)
            {
                parcelSpecs.ParcelPrice = 35;
                //Price Package: Weight 3
            }

            //Attempting to write errors if volume,weight or both are out of range
            // Consider this as placeholder, will need optimization or maybe its outright wrong
            // switch case maybe?
            //figgure out what to do for negative or null values


            else if (parcelSpecs.ParcelVolume > 2000)
            {
                throw new ArgumentOutOfRangeException(String.Format("{0} The parcel Volume is larger than what Cargo4You is able to ship," +
                    " please enter a Volume smaller than 2000cm3 or select a different supplier"));
            }

            else if (parcelSpecs.ParcelWeight > 25)
            {
                throw new ArgumentOutOfRangeException(String.Format("{0} The parcel Weight is larger than what Cargo4You is able to ship,"
                + "please enter a Weight smaller than 25kg or select a different supplier"));

            }

            else if (parcelSpecs.ParcelVolume > 2000 && parcelSpecs.ParcelWeight > 25)
            {
                throw new ArgumentOutOfRangeException(String.Format("{0},{1} Both the parcel Volume and Weight are larger than what Cargo4You is able to ship,"
                    + "please enter a Volume smaller than 2000cm3 as well as a Weight smaller than 25kg or select a different supplier ")); 
            }
        }
    }
}
