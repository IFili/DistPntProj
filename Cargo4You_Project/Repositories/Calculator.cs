using Cargo4You_Project.Models;

namespace Cargo4You_Project.Repositories
{
    public class Calculator
    {
        private Parcel CurrentParcel { get; set; }

        public Calculator(Parcel currentParcel)
        {
            CurrentParcel = currentParcel;
        }

       public float CalculatePrice()
        {
            if(CurrentParcel.ParcelName=="Cargo4You")
            {
                Cargo4You cargo4You = new Cargo4You();
                return cargo4You.calculateTotalPrice(CurrentParcel);
            }
           
            /*if(CurrentParcel.ParcelName=="ShipFaster")
            {
                ShipFaster shipFaster = new ShipFaster();
                return shipFaster.calculateTotalPrice(CurrentParcel);
                    }*/
            
            if(CurrentParcel.ParcelName=="ShipFaster")
            {
                ShipFaster shipFaster = new ShipFaster();
                return shipFaster.calculateTotalPrice(CurrentParcel);
            }
            
            if(CurrentParcel.ParcelName=="MaltaShip")
            {
                MaltaShip maltaShip = new MaltaShip();
                return maltaShip.calculateTotalPrice(CurrentParcel);
            }    
            
            else
            {
                return 0;
            }    
        }
    }
}
