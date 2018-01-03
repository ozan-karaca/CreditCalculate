using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CreditCalculate.DAL.Concrete.EntityFramework.Context;
using CreditCalculate.Model.Models.Entity;

namespace CreditCalculate.Controllers
{
    public class UserController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/user/5
        public HttpResponseMessage Get(int age)
        {
            if (age > 0 && age <= 10)
            {
                age = 10;
            }
            else if (age > 10 && age <= 15)
            {
                age = 15;
            }
            else if (age > 15 && age <= 20)
            {
                age = 20;
            }
            else if (age > 20 && age <= 25)
            {
                age = 25;
            }
            else if (age > 25 && age <= 30)
            {
                age = 30;
            }
            else if (age > 30 && age <= 35)
            {
                age = 35;
            }
            else if (age > 35 && age <= 40)
            {
                age = 40;
            }
            else if (age > 40 && age <= 45)
            {
                age = 45;
            }
            else if (age > 45 && age <= 50)
            {
                age = 50;
            }
            else if (age > 50 && age <= 55)
            {
                age = 55;
            }
            else if (age > 55 && age <= 60)
            {
                age = 60;
            }
            else if (age > 60 && age <= 65)
            {
                age = 65;
            }
            else if (age > 65 && age <= 70)
            {
                age = 70;
            }
            else if (age > 70 && age <= 75)
            {
                age = 75;
            }
            else if (age > 75 && age <= 80)
            {
                age = 80;
            }
            else if (age > 80 && age <= 85)
            {
                age = 85;
            }
            else if (age > 85 && age <= 90)
            {
                age = 90;
            }
            else if (age > 90 && age <= 95)
            {
                age = 95;
            }
            else if (age > 95 && age <= 100)
            {
                age = 100;
            }
            else
            {
                age = 0;
               
            }


            //veritabanı çek

            CreditCalculateDBContext ct = new CreditCalculateDBContext();

            var collection = new Dictionary<string, object>();
            if (age != 0)
            {
                Credit c = ct.Credit.FirstOrDefault((x => x.age == age));
                collection.Add("value", c.credit);

            }
            else
            {
                collection.Add("value","Lütfen 0 ile 100 arasında bir deger giriniz!");

            }


            return Request.CreateResponse(HttpStatusCode.OK, collection, "application/json");
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}