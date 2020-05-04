using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using PupBuddy_CA2_OanaSorin.DAL;
using System.Web.Http;
using System.Security.Cryptography.X509Certificates;
using PupBuddy_CA2_OanaSorin.Models;

namespace PupBuddy_CA2_OanaSorin.API
{
    public class PuppyController : ApiController
    {
        private PuppyContext db = new PuppyContext();


        public PuppyController()
        {
            db.Configuration.ProxyCreationEnabled = false; 
            //avoiding seralization error
        }

        // GET: api/Puppy
        public IEnumerable<PuppyModel> Get()
        {
            return db.Puppy.ToList();
        }

        // GET: api/Puppy/5
        public string Get(int id)
        {
            PuppyModel puppyid = db.Puppy.Where(x => x.PuppyID == id).FirstOrDefault();
            // return db.Puppy.FirstOrDefault(x => x.PuppyID == id);
            return puppyid.ToString();
        }

        // POST: api/Puppy
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Puppy/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Puppy/5
        public void Delete(int id)
        {
        }
    }
}
