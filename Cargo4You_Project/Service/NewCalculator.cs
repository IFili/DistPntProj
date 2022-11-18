using Cargo4You_Project.Models;
using Newtonsoft.Json;

namespace Cargo4You_Project.Service
{
    public class NewCalculator
    {
        private List<Courier> Couriers { get; set; }

        private Parcel CurrentParcel { get; set; }
        public List<Courier> myCouriers = new List<Courier>();
        public NewCalculator(Courier couriers, Parcel currentParcel)
        {
            var readJson = System.IO.File.ReadAllText(@"C:\Users\Korisnik\Desktop\Webdev\DistantPoint proekt\Cargo4You_Project\Cargo4You_Project\Service\CourierService.json");

            var courier = JsonConvert.DeserializeObject<Courier>(readJson);


            foreach (var item in myCouriers)
            {
                Courier courierObject = new Courier()
                {
                    MinimumVolume = item.MinimumVolume,
                    Volume2 = item.Volume2,
                    Volume3 = item.Volume3,
                    Volume4 = item.Volume4,
                    MaxVolume = item.MaxVolume,
                    VolumePrice1 = item.VolumePrice1,
                    VolumePrice2 = item.VolumePrice2,
                    VolumePrice3 = item.VolumePrice3,
                    VolumePrice4 = item.VolumePrice4,
                    MinimumWeight = item.MinimumWeight,
                    Weight2 = item.Weight2,
                    Weight3 = item.Weight3,
                    MaxWeight = item.MaxWeight,
                    WeightPrice1 = item.WeightPrice1,
                    WeightPrice2 = item.WeightPrice2,
                    WeightPrice3 = item.WeightPrice3,
                    ExcessWeightBase = item.ExcessWeightBase,
                    ExcessWeightRate = item.ExcessWeightRate,
                };
                myCouriers.Add(courierObject);


            }



        }

        public List<Parcel> calculatePriceByVolume(Parcel parcel) 
        {
            List<Parcel> myParcels = new List<Parcel>();
            int parcelVolume = (parcel.ParcelHeight * parcel.ParcelWidth * parcel.ParcelDepth);

          
            foreach (var courier in myCouriers)
            {
                Parcel _parcel = new Parcel();
                if (parcel.ParcelVolume <= courier.MinimumVolume)
                {
                    throw new ArgumentOutOfRangeException("{0}, insufficient volume");
                }
                else if (parcel.ParcelVolume >= courier.MinimumVolume && parcelVolume <= courier.Volume2)
                {
                    _parcel.ParcelPriceByVolume = courier.VolumePrice1;
                }
                else if (parcel.ParcelVolume >= courier.Volume3 && courier.Volume3 != 0)
                {
                    _parcel.ParcelPriceByVolume = (float)courier.VolumePrice2;
                }
                else if (parcel.ParcelVolume >= courier.Volume4 && courier.Volume4 != 0)
                {
                    _parcel.ParcelPriceByVolume = (float)courier.VolumePrice3;
                }
                else if (parcel.ParcelVolume >= courier.MaxVolume)
                {
                    _parcel.ParcelPriceByVolume = (float)courier.VolumePrice4;
                }
                else { throw new ArgumentOutOfRangeException("{0},volume above the max limits"); }

                myParcels.Add(_parcel);
            }

            return myParcels;





        }

        public List<Parcel> calculatePricebyWeight(Parcel parcel)
        {
            List<Parcel> myParcels = new List<Parcel>();

            foreach (var courier in myCouriers)
            {
                Parcel _parcel = new Parcel();

                if (parcel.ParcelWeight <= courier.MinimumWeight)
                {
                    throw new ArgumentOutOfRangeException("{0},weight beyond the minimum limits");
                }
                else if (parcel.ParcelWeight >= courier.MinimumWeight && _parcel.ParcelWeight <= courier.Weight2)
                {
                    _parcel.ParcelPriceByWeight = courier.WeightPrice1;
                }
                else if (parcel.ParcelWeight > courier.Weight2 && _parcel.ParcelWeight <= courier.Weight3)
                {
                    _parcel.ParcelPriceByWeight = courier.WeightPrice2;
                }

                else if (parcel.ParcelWeight > courier.Weight3)
                {
                    if (courier.WeightPrice3 != 0)
                    {
                        _parcel.ParcelPriceByWeight = courier.WeightPrice3;
                    }
                    else // i could use this without the IF loop above / if i didnt have to multiply by zero (Cargo4You case, where rate is zero)
                    {
                        courier.WeightPrice3 = (int)((_parcel.ParcelWeight - courier.ExcessWeightBase) * courier.ExcessWeightRate); //might have a mistake here

                        _parcel.ParcelPriceByWeight = courier.WeightPrice3;
                    }

                }
                myParcels.Add(_parcel);

            }
            return myParcels;
        }


        public List<Parcel> calculateFinalPrice(Parcel parcel)
        {
            List<Parcel> MyParcels = new List<Parcel>();


            foreach (var item in MyParcels)
            {
                Parcel _parcel = new Parcel();

                if (_parcel.ParcelPriceByVolume > _parcel.ParcelPriceByWeight)
                {
                    _parcel.ParcelPrice = _parcel.ParcelPriceByVolume;
                }

                else
                {
                    _parcel.ParcelPrice = _parcel.ParcelPriceByWeight;
                }
                MyParcels.Add(_parcel);
            }

            return MyParcels;


        }

    }
}


