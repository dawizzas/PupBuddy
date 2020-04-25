using PupBuddy_CA2_OanaSorin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PupBuddy_CA2_OanaSorin.Controllers
{
    public class HomeController : Controller
    {
        

        public ActionResult ListPuppies()
        {
            List<PuppyModel> puppies = new List<PuppyModel>();

            puppies.Add(new PuppyModel { Id = 1, Breed = "GoldenRetriever", PupName = "Nibble", OwnerPhoneNumber = "092839"});
            puppies.Add(new PuppyModel { Id = 2, Breed = "GoldenRetriever", PupName = "Nibble", OwnerPhoneNumber = "098765" });
            puppies.Add(new PuppyModel { Id = 3, Breed = "GoldenRetriever", PupName = "Nibble", OwnerPhoneNumber = "098765" });

            return View();
        }
    }
}