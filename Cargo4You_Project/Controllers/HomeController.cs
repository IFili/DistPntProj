using Cargo4You_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Cargo4You_Project.Service;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Cargo4You_Project.Service;





namespace Cargo4You_Project.Controllers
{
    public class HomeController : Controller
    {
        public int ParcelPrice { get; private set; }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetParcelDetails()
        {
            var parcel = new Parcel();




            return View(parcel);


        }



        [HttpPost]
        public ActionResult SetParcelDetails(float ParcelWidth, float ParcelHeight, float ParcelDepth, float ParcelWeight, float ParcelPriceByVolume, float ParcelPriceByWeight, float ParcelPrice) //calculate here
        {
            

            Parcel parcelObject = new Parcel();
            


            parcelObject.ParcelDepth = (int)ParcelDepth;
            parcelObject.ParcelWidth = (int)ParcelWidth;
            parcelObject.ParcelHeight = (int)ParcelHeight;
            parcelObject.ParcelWeight = (int)ParcelWeight;
            parcelObject.ParcelPriceByVolume = ParcelPriceByVolume;
            parcelObject.ParcelPriceByWeight = ParcelPriceByWeight;
            parcelObject.ParcelPrice = ParcelPrice;


            //reading from json

            var readJson = System.IO.File.ReadAllText(@"C:\Users\Korisnik\Desktop\Webdev\DistantPoint proekt\Cargo4You_Project\Cargo4You_Project\Service\CourierService.json");

            var courier = JsonConvert.DeserializeObject<Courier>(readJson);

            List<Courier> myCouriers = new List<Courier>();

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
            // create calculator as an object
            // NewCalculator calc = new NewCalculator(parcelObject, couriers);
            // I want to perform the 3 methods from NewCalculator to parcelObject
            // store the results of method calculateFinalPrice in a list which will be passed back to view (instaed of the object)


            return View(parcelObject);
        }
    }

         
}

   
   
 

