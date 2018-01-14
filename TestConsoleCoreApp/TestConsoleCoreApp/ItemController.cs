using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestConsoleCoreApp
{
    public class ItemController : Controller
    {
        [Route("api/get")]
        [HttpGet]
        public String Get()
        {
            return "item exists";
        }

        [Route("api/getImage")]
        [HttpGet]
        public async Task<IActionResult> GetImage()
        {
            var image = System.IO.File.OpenRead(@"C:\Users\User\Desktop\rifat\imac.png");
            return File(image, "image/png");
        }

    }
}
