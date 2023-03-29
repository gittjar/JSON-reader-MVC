using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Json_Reader.Models;
using Newtonsoft.Json;
using System.Web;


namespace MVC_Json_Reader.Controllers;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        List<CountryCode> items = new List<CountryCode>();
        using (StreamReader r = new StreamReader("Content/countrycodes.json"))
        {
            string json = r.ReadToEnd();
            items = JsonConvert.DeserializeObject<List<CountryCode>>(json);
        }
        return View(items);
    }
}

