using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CarWebApp.Models
{
    public class CarDAL
    {
        public string GetCarsData()
        {
            string url = $@"https://localhost:44351/api/Car";

            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader rd = new StreamReader(response.GetResponseStream());
            string JSON = rd.ReadToEnd();
            return JSON;
        }
        public List<Car> allCars()
        {
            string json = GetCarsData();
            List<Car> cars = JsonConvert.DeserializeObject<List<Car>>(json);
            return cars;
        }

        public string GetData(string category, string search)
        {
            
            string url = $"https://localhost:44351/api/Car/{category}/{search}";

           
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = null;

            response = (HttpWebResponse)request.GetResponse();
            StreamReader rd = new StreamReader(response.GetResponseStream());
            string json = rd.ReadToEnd();
            return json;

        }

        public List<Car> GetCars(string category, string search)
        {
            string json = GetData(category, search);

            List<Car> c = JsonConvert.DeserializeObject<List<Car>>(json);
            return c;
        }
    }
}
