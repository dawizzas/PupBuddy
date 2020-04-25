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

            puppies.Add(new PuppyModel { Id=1, OwnerPhoneNumber = "092839", Breed = "GoldenRetriever", PupName = "Nibble",  PupSize = "tiny", PupAge = 1, });
            puppies.Add(new PuppyModel { Id=2, OwnerPhoneNumber = "092839", Breed = "GoldenRetriever", PupName = "Nibble", PupSize = "tiny", PupAge = 1, });
            puppies.Add(new PuppyModel { Id =3, OwnerPhoneNumber = "092839", Breed = "GoldenRetriever", PupName = "Nibble", PupSize = "tiny", PupAge = 1, });

            return View(puppies);
        }
    }
}