using Microsoft.AspNetCore.Mvc;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace SvgDrawingApp.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class SvgController : ControllerBase {

        [HttpGet]
        public ActionResult GetDimensions() {
            var json = System.IO.File.ReadAllText("dimensions.json");
            return Ok(json);
        }

        [HttpPost]
        public IActionResult SaveDimensions([FromBody] RectangleDimensions dimensions) {
            var json = JsonConvert.SerializeObject(dimensions);
            System.IO.File.WriteAllText("dimensions.json", json);
            return Ok();
        }
    }

    public class RectangleDimensions {
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
