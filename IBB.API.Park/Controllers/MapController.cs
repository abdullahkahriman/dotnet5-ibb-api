using IBB.API.Park.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace IBB.API.Park.Controllers
{
    public class MapController : Controller
    {
        private static readonly HttpClient httpClient = new();
        private const string API_URL = "https://data.ibb.gov.tr/datastore/odata3.0/b81fa24f-3a96-4aa4-bc37-33d7a984c648?$format=json";

        //&$top=5

        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Get()
        {
            HttpResponseMessage response = await httpClient.GetAsync(API_URL);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            ParkBaseModel json = Newtonsoft.Json.JsonConvert.DeserializeObject<ParkBaseModel>(responseBody);
            return Ok(json.Park);
        }
    }
}