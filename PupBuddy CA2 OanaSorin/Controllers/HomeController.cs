using PupBuddy_CA2_OanaSorin.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PupBuddy_CA2_OanaSorin.Controllers
{
    public class HomeController : Controller
    {
       

       

        public ActionResult ListPuppies()
        {
            SqlConnection emailsqlConec = new SqlConnection(connectionString: "Data Source=pupbuddyserver.database.windows.net,1433;Initial Catalog=PupBuddyDB; Password = Sorincelmare2017; Connection Timeout=30; ".ToString());
            SqlConnection connecstr = new SqlConnection(connectionString: "Data Source=pupbuddyserver.database.windows.net,1433;Initial Catalog=PupBuddyDB;Persist Security Info=False;User ID=PupAdmin;Password=Sorincelmare2017;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;".ToString());

            string connetstr = @"select * from CloudStore.dbo.Mail where Recipient like '%testUseraksdj%' order by DateInserted desc";

            //Server=tcp:pupbuddyserver.database.windows.net,1433;Initial Catalog=PupBuddyDB;Persist Security Info=False;User ID=PupAdmin;Password=Sorincelmare2017;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;
            Console.WriteLine(connecstr);

            Console.WriteLine(emailsqlConec);

            List<PuppyModel> puppies = new List<PuppyModel>();

           // puppies.Add(new PuppyModel { Id=1, OwnerPhoneNumber = "092839", Breed = "GoldenRetriever", PupName = "Nibble",  PupSize = "tiny", PupAge = 1, });
          //  puppies.Add(new PuppyModel { Id=2, OwnerPhoneNumber = "092839", Breed = "GoldenRetriever", PupName = "Nibble", PupSize = "tiny", PupAge = 1, });
            puppies.Add(new PuppyModel { PuppyID =3,  Breed = "GoldenRetriever", PupName = "Nibble", PupSize = "tiny", });

            return View(puppies);
        }

       /* public ViewResult Error()
        {

            return View("Error");
        }

        public HttpStatusCodeResult Index()
        {

            return new HttpStatusCodeResult(404, "Sorry buddy, pup not found");
        }
*/

    }
}