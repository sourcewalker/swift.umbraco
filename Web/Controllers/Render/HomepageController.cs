using Business.Interfaces;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using Umbraco.Web.Models;

namespace Trebor.Cash.In.Flash.Controllers.Render
{
    public class HomepageController : BaseController
    {
        private readonly IValidationService _validationService;

        public HomepageController(
            IConfigurationService configurationService,
            IValidationService validationService)
            : base(configurationService)
        {
            _validationService = validationService;
        }

        public async Task<ActionResult> Homepage(RenderModel model)
        {
            ViewBag.IsOpenHour = await _validationService.IsOpenHoursForParticipationAsync();
            return base.Index(model);
        }
    }
}