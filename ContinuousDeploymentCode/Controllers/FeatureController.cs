using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement;
using Microsoft.FeatureManagement.Mvc;

namespace ContinuousDeploymentCode.Controllers
{
    public class FeatureController : Controller
    {
        private readonly IFeatureManager _featureManager;

        public FeatureController(IFeatureManagerSnapshot featureManager)
        {
            this._featureManager = featureManager;
        }

        [FeatureGate(MyFeatureFlags.Beta)]
        public IActionResult Index()
        {
            return View();
        }
    }
}
