using Cargo4You_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Cargo4You_Project.Repositories;
using Cargo4You_Project.Models;

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
        public ActionResult SetParcelDetails(string ParcelName,float ParcelWidth, float ParcelHeight,float ParcelDepth, float ParcelWeight) //calculate here
        {

            Parcel parcelObject = new Parcel();
           // pObj.ParcelId = ParcelId;
            parcelObject.ParcelName = ParcelName; //fix , needs to show options
            parcelObject.ParcelDepth = (int)ParcelDepth; //fix cast
            parcelObject.ParcelWidth = (int)ParcelWidth;//fix cast
            parcelObject.ParcelHeight = (int)ParcelHeight;//fix cast
            parcelObject.ParcelWeight = (int)ParcelWeight;//fix cast
            

            Calculator calculator = new Calculator(parcelObject);
            var a = calculator.CalculatePrice();

            parcelObject.ParcelPrice = a;


            return View(parcelObject);
        }


        
       
    }
}