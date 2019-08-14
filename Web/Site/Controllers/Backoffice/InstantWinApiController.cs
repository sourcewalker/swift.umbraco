using Models.DTO;
using Swift.Umbraco.Business.Service.Interfaces;
using Swift.Umbraco.Web.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Threading.Tasks;
using System.Web.Mvc;
using Umbraco.Web.WebApi;

namespace Swift.Umbraco.Web.Controllers.Backoffice
{
    public class InstantWinApiController : UmbracoAuthorizedApiController
    {
        private IInstantWinService _instantWinService;

        public InstantWinApiController(IInstantWinService instantWinService)
        {
            _instantWinService = instantWinService;
        }

        [HttpPost]
        public async Task<ApiResponse> Generate(GeneratorConfig config, List<Allocable> allocable)
        {
            try
            {

                var generationResponse = _instantWinService.GenerateInstantWinMoments(config, allocable);

                var response = new ApiResponse
                {
                    Success = generationResponse.status,
                    Message = $"{generationResponse.generatedNumber} instant moments have been generated"
                };
                return response;
            }
            catch (Exception e)
            {
                dynamic data = new ExpandoObject();
                data.Description = e.Message;
                return new ApiResponse
                {
                    Success = false,
                    Message = "FAILED",
                    Data = data
                };
            }
        }
    }
}