using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers
{
    public class ParcelController : Controller
    {

        [HttpGet("/parcels")]
        public ActionResult Index()
        {
            List<Parcel> allParcels = Parcel.GetAll();
            return View(allParcels);
        }


        [HttpGet("/parcels/new")]
        public ActionResult CreateForm()
        {
            return View();
        }
        [HttpPost("/parcels")]
        public ActionResult Create(string material, string height, string width, string weight, int cost)
        {
            Parcel myParcel = new Parcel(material, height, width, weight);
            myParcel.Save();
            return RedirectToAction("Index");
        }
    }
}