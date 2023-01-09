using DA.Models;
using DA.Providers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Api_Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PerfilesController
    {
        [HttpGet("getPerfiles")]
        public async Task<string> getPerfiles()
        {
            TestProvider perfiles = new TestProvider();
            IEnumerable<UserProfile> resultado = await perfiles.LeerPerfiles();
            return JsonConvert.SerializeObject(resultado);
        }
    }
}
