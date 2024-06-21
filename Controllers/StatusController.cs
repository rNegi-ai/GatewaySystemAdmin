using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SystemAdmin.Models;

namespace SystemAdmin.Controllers
{
    public class StatusController : Controller
    {       

        private readonly HttpClient _httpClient;

        public StatusController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetStringAsync("https://localhost:57519/api/Statuses/GetStatuses"); //63529
            var statuses = JsonConvert.DeserializeObject<List<StatusModel>>(response);

            //ViewBag.Statuses = statuses;
            return View(statuses);
        }        
    }
}

