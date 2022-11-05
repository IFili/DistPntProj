using Cargo4You_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Cargo4You_Project.Repositories;
using Cargo4You_Project.Models;

namespace Cargo4You_Project.Controllers
{
    public class HomeController : Controller 
    {




        [HttpGet]
        public IActionResult Index()
        {
            var parcel = new Parcel(); // test izbrisi posle

            return View(parcel);
        }

        [HttpGet]
        public IActionResult GetParcelDetails()
        {
            var parcel = new Parcel();
            

            

            return View(parcel);

            
        }


        [HttpPost]
        public ActionResult SetParcelDetails(string ParcelName,float ParcelWidth, float ParcelHeight,float ParcelDepth, float ParcelWeight ) //calculate here
        {

            Parcel pObj = new Parcel();
           // pObj.ParcelId = ParcelId;
            pObj.ParcelName = ParcelName; //fix , treba da gi prikazuva options
            pObj.ParcelDepth = (int)ParcelDepth; //fix cast
            pObj.ParcelWidth = (int)ParcelWidth;//fix cast
            pObj.ParcelHeight = (int)ParcelHeight;//fix cast
            pObj.ParcelWeight = (int)ParcelWeight;//fix cast



            return View(pObj);
        }


        [HttpPost]
        public ActionResult Zojgene(string ParcelName, float ParcelWidth, float ParcelHeight, float ParcelDepth, float ParcelWeight)
        {
            Parcel zojgene = new Parcel();
            zojgene.ParcelName = ParcelName; //fix , treba da gi prikazuva options
            zojgene.ParcelDepth = (int)ParcelDepth; //fix cast
            zojgene.ParcelWidth = (int)ParcelWidth;//fix cast
            zojgene.ParcelHeight = (int)ParcelHeight;//fix cast
            zojgene.ParcelWeight = (int)ParcelWeight;//fix cast

            return View(zojgene);
        }
       
    }
}