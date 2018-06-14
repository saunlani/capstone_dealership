using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.IO;
using capstone_dealership.Models;
using Newtonsoft.Json.Linq;

namespace capstone_dealership.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Search()
        {
            ViewBag.Title = "Search Page";

            return View();
        }

        [HttpPost]
        public ActionResult GetCarsByID(int? id)
        {
            //makes a call to the API to get a list of cars
            HttpWebRequest WR = WebRequest.CreateHttp($"http://localhost:55458/api/car?id={id}");
            WR.UserAgent = ".NET Framework Test Client";

            //instantiating the HTTP web response
            HttpWebResponse Response;

            Response = (HttpWebResponse)WR.GetResponse();

            // if the response's HTTP status code is NOT ok, then return this error page


            //reads response
            StreamReader reader = new StreamReader(Response.GetResponseStream());
            string carsData = reader.ReadToEnd();
            List<Car> cars = new List<Car>();
            Car c = new Car();
            //parsing car list, print Car ID to a viewbag.
            if (id != null)
            {
                //the jarray that will contain search results when color is searched
                JArray JsonData = JArray.Parse(carsData);

                for (int i = 0; i < JsonData.Count; i++)
                {
                    c.ID = int.Parse((string)JsonData[i]["ID"]);
                    c.Make = (string)JsonData[i]["Make"];
                    c.Model = (string)JsonData[i]["Model"];
                    c.Year = int.Parse((string)JsonData[i]["Year"]);
                    c.Color = (string)JsonData[i]["Color"];
                    cars.Add(new Car() { ID = c.ID, Make = c.Make, Model = c.Model, Year = c.Year, Color = c.Color });
                }


            }

            return Json(cars);
        }

        [HttpPost]
        public ActionResult GetCarsByColor(string color)
        {
            //makes a call to the API to get a list of cars
            HttpWebRequest WR = WebRequest.CreateHttp($"http://localhost:55458/api/color?color={color}");
            WR.UserAgent = ".NET Framework Test Client";

            //instantiating the HTTP web response
            HttpWebResponse Response;

            Response = (HttpWebResponse)WR.GetResponse();

            // if the response's HTTP status code is NOT ok, then return this error page


            //reads response
            StreamReader reader = new StreamReader(Response.GetResponseStream());
            string carsData = reader.ReadToEnd();
            List <Car> cars = new List<Car>();
            Car c = new Car();
            //parsing car list, print Car ID to a viewbag.
            if (color != null)
            {
                //the jarray that will contain search results when color is searched
                JArray JsonData = JArray.Parse(carsData);

                for (int i = 0; i < JsonData.Count; i++)
                {
                    c.ID = int.Parse((string)JsonData[i]["ID"]);
                    c.Make = (string)JsonData[i]["Make"];
                    c.Model = (string)JsonData[i]["Model"];
                    c.Year = int.Parse((string)JsonData[i]["Year"]);
                    c.Color = (string)JsonData[i]["Color"];
                    cars.Add(new Car() { ID = c.ID, Make = c.Make, Model = c.Model, Year = c.Year, Color = c.Color });
                }


            }

            return Json(cars);
        }

        [HttpPost]
        public ActionResult GetCarsByMake(string make)
        {
            //makes a call to the API to get a list of cars
            HttpWebRequest WR = WebRequest.CreateHttp($"http://localhost:55458/api/make?make={make}");
            WR.UserAgent = ".NET Framework Test Client";

            //instantiating the HTTP web response
            HttpWebResponse Response;

            Response = (HttpWebResponse)WR.GetResponse();

            // if the response's HTTP status code is NOT ok, then return this error page


            //reads response
            StreamReader reader = new StreamReader(Response.GetResponseStream());
            string carsData = reader.ReadToEnd();
            List<Car> cars = new List<Car>();
            Car c = new Car();
            //parsing car list, print Car ID to a viewbag.
            if (make != null)
            {
                //the jarray that will contain search results when color is searched
                JArray JsonData = JArray.Parse(carsData);

                for (int i = 0; i < JsonData.Count; i++)
                {
                    c.ID = int.Parse((string)JsonData[i]["ID"]);
                    c.Make = (string)JsonData[i]["Make"];
                    c.Model = (string)JsonData[i]["Model"];
                    c.Year = int.Parse((string)JsonData[i]["Year"]);
                    c.Color = (string)JsonData[i]["Color"];
                    cars.Add(new Car() { ID = c.ID, Make = c.Make, Model = c.Model, Year = c.Year, Color = c.Color });
                }


            }

            return Json(cars);
        }


        [HttpPost]
        public ActionResult GetCarsByModel(string model)
        {
            //makes a call to the API to get a list of cars
            HttpWebRequest WR = WebRequest.CreateHttp($"http://localhost:55458/api/model?model={model}");
            WR.UserAgent = ".NET Framework Test Client";

            //instantiating the HTTP web response
            HttpWebResponse Response;

            Response = (HttpWebResponse)WR.GetResponse();

            // if the response's HTTP status code is NOT ok, then return this error page


            //reads response
            StreamReader reader = new StreamReader(Response.GetResponseStream());
            string carsData = reader.ReadToEnd();
            List<Car> cars = new List<Car>();
            Car c = new Car();
            //parsing car list, print Car ID to a viewbag.
            if (model != null)
            {
                //the jarray that will contain search results when color is searched
                JArray JsonData = JArray.Parse(carsData);

                for (int i = 0; i < JsonData.Count; i++)
                {
                    c.ID = int.Parse((string)JsonData[i]["ID"]);
                    c.Make = (string)JsonData[i]["Make"];
                    c.Model = (string)JsonData[i]["Model"];
                    c.Year = int.Parse((string)JsonData[i]["Year"]);
                    c.Color = (string)JsonData[i]["Color"];
                    cars.Add(new Car() { ID = c.ID, Make = c.Make, Model = c.Model, Year = c.Year, Color = c.Color });
                }


            }

            return Json(cars);
        }

        [HttpPost]
        public ActionResult GetCarsByYear(int? year)
        {
            //makes a call to the API to get a list of cars
            HttpWebRequest WR = WebRequest.CreateHttp($"http://localhost:55458/api/year?year={year}");
            WR.UserAgent = ".NET Framework Test Client";

            //instantiating the HTTP web response
            HttpWebResponse Response;

            Response = (HttpWebResponse)WR.GetResponse();

            //reads response
            StreamReader reader = new StreamReader(Response.GetResponseStream());
            string carsData = reader.ReadToEnd();
            List<Car> cars = new List<Car>();
            Car c = new Car();
            //parsing car list, print Car ID to a viewbag.
            if (year != null)
            {
                //the jarray that will contain search results when color is searched
                JArray JsonData = JArray.Parse(carsData);

                for (int i = 0; i < JsonData.Count; i++)
                {
                    c.ID = int.Parse((string)JsonData[i]["ID"]);
                    c.Make = (string)JsonData[i]["Make"];
                    c.Model = (string)JsonData[i]["Model"];
                    c.Year = int.Parse((string)JsonData[i]["Year"]);
                    c.Color = (string)JsonData[i]["Color"];
                    cars.Add(new Car() { ID = c.ID, Make = c.Make, Model = c.Model, Year = c.Year, Color = c.Color });
                }


            }

            return Json(cars);
        }
    }
}