using Microsoft.AspNetCore.Mvc;
using S40_AspNetCore_DI.Models.LifeTimeDemo;

namespace S40_AspNetCore_DI.Controllers
{
    public class LifetimeController : Controller
    {
        private readonly ISingletonService _singletonService;
        private readonly IScopedService _scopedService;
        private readonly IScopedService _scopedService2;
        private readonly ITransientService _transientService;
        private readonly ITransientService _transientService2;

        public LifetimeController(
            ISingletonService singletonService,
            IScopedService scopedService,
            IScopedService scopedService2,
            ITransientService transientService,
            ITransientService transientService2
            )
        {
            _singletonService = singletonService;
            _scopedService = scopedService;
            _scopedService2 = scopedService2;
            _transientService = transientService;
            _transientService2 = transientService2;
        }
        public IActionResult Index()
        {
            var output =
                $"Singleton Service _Id : {_singletonService.GetId()} <br /><br />" +

                $"Scoped Service (1) _Id : {_scopedService.GetId()} <br />" +
                $"Scoped Service (2) _Id : {_scopedService2.GetId()} <br /><br />" +

                $"Transient Service (1) _Id : {_transientService.GetId()} <br />" +
                $"Transient Service (2) _Id : {_transientService2.GetId()} <br /><br />";


            return View("Index", output);
        }
    }
}
