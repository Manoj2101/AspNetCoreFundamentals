using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController
    {      
        public string Phone() => "555-555-5555";
        public string Country() => "USA";
    }
}
