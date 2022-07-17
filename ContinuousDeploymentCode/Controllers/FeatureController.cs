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

        [FeatureGate(MyFeatureFlags.staging)]
        public IActionResult Staging()
        {
            return View();
        }
        [FeatureGate(MyFeatureFlags.production)]
        public IActionResult Production()
        {
            return View();
        }
    }
}
