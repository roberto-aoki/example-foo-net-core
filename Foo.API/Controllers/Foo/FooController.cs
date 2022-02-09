using Foo.Model;
using Foo.Service;
using Microsoft.AspNetCore.Mvc;

namespace Foo.API.Controllers.Foo
{
    [Route("api/[controller]")]
    [ApiController]
    public class FooController : ControllerBase
    {
        private readonly FooService _fooService;

        public FooController(FooService fooService)
        {
               _fooService = fooService;
        }

        [HttpGet]
        public async Task<IEnumerable<FooModel>> Get()
        {
            return await _fooService.GetAllAsync();
        }
    }
}
