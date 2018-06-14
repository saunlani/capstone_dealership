using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using capstone_dealership.Models;

namespace capstone_dealership.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        [HttpGet]
        [Route("{api}/Car")]
        public List<Car> Car(int? id)
        {
            DealershipEntities db = new DealershipEntities();

            List<Car> CarIDList = new List<Car>();
            try
            {
                List<Car> Cars = db.Cars.ToList();
                CarIDList = (from p in db.Cars
                             where p.ID == id
                             select p).ToList();
            }
            catch
            {
                Exception e;
            }

            return CarIDList;
        }

        [HttpGet]
        [Route("{api}/CarsCount")]
        public int CarsCount()
        {
            DealershipEntities db = new DealershipEntities();
            List<Car> Cars = db.Cars.ToList();
            int carcount = Cars.Count();
            return carcount;
        }

        [HttpGet]
        [Route("{api}/Color")]
        public List<Car> Color(string color)
        {
            DealershipEntities db = new DealershipEntities();
            List<Car> Cars = db.Cars.ToList();
            List<Car> CarWColorList = (from p in db.Cars
                                       where p.Color.Contains(color)
                                       select p).ToList();
            return CarWColorList;
        }
        [HttpGet]
        [Route("{api}/Make")]
        public List<Car> Make(string make)
        {
            DealershipEntities db = new DealershipEntities();
            List<Car> Cars = db.Cars.ToList();
            List<Car> CarMakeList = (from p in db.Cars
                                     where p.Make.Contains(make)
                                     select p).ToList();
            return CarMakeList;
        }

        [HttpGet]
        [Route("{api}/Model")]
        public List<Car> Model(string model)
        {
            DealershipEntities db = new DealershipEntities();
            List<Car> Cars = db.Cars.ToList();
            List<Car> CarModelList = (from p in db.Cars
                                      where p.Make.Contains(model)
                                      select p).ToList();
            return CarModelList;
        }

        [HttpGet]
        [Route("{api}/Year")]
        public List<Car> Year(int? year)
        {
            DealershipEntities db = new DealershipEntities();
            List<Car> Cars = db.Cars.ToList();
            List<Car> CarYearList = (from p in db.Cars
                                     where p.Year == year
                                     select p).ToList();
            return CarYearList;
        }
    }
}