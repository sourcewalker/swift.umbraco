using Swift.Umbraco.Business.Interfaces;
using Swift.Umbraco.Models.DTO;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using Swift.Umbraco.Web.Extensions.Storage;
using Swift.Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace Swift.Umbraco.Web.Controllers.Surface
{
    public class InstantWinController : SurfaceController
    {
        private readonly IParticipationService _participationService;
        private readonly IValidationService _validationService;
        private readonly IInstantWinService _instantWinService;

        public InstantWinController(
            IParticipationService participationService,
            IValidationService validationService,
            IInstantWinService instantWinService)
        {
            _participationService = participationService;
            _validationService = validationService;
            _instantWinService = instantWinService;
        }

        [System.Web.Mvc.HttpPost]
        public async Task<ActionResult> LogoAndWin([FromBody]LogoWinRequest model)
        {
            if (model.PhotoInput == null)
            {
                ViewBag.Error = "PICTURE_REQUIRED";
                return CurrentUmbracoPage();
            }
            if (model.ParticipationId == null || model.ParticipationId == default)
            {
                ViewBag.Error = "PARTICIPATION_ID_REQUIRED";
                return CurrentUmbracoPage();
            }
            if (model.ParticipantId == null || model.ParticipantId == default)
            {
                ViewBag.Error = "PARTICIPANT_ID_REQUIRED";
                return CurrentUmbracoPage();
            }

            var filePath = FileHelper.StoreFileTemporarily(model.PhotoInput);
            bool isLogoValid = await _validationService.CheckValidLogoAsync(filePath);
            FileHelper.RemoveTemporarilyStoredFile(filePath);

            if (!isLogoValid)
            {
                ViewBag.Error = "LOGO_INVALID";
                return CurrentUmbracoPage();
            }

            var participation = new ParticipationDto
            {
                Id = model.ParticipationId,
                ParticipantId = model.ParticipantId
            };

            await _participationService.UpdateLogoValidatedParticipationAsync(participation);

            var instantWinResult = await _participationService.UpdateInstantWinStatusAsync(participation);

            var congratsOrLosePageId = instantWinResult.winStatus ?
                                        _instantWinService.GetCongratulationPageId() :
                                        _instantWinService.GetLosePageId();

            return RedirectToUmbracoPage(congratsOrLosePageId);
        }
    }
}