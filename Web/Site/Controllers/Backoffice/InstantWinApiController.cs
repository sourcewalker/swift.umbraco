using Models.DTO;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Threading.Tasks;
using System.Web.Mvc;
using Swift.Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using Umbraco.Web.WebApi;
using Swift.Umbraco.Business.Service.Interfaces;
using Umbraco.Web.Editors;
using System.Net.Http;
using System.Web.Http;
using System.Net;

namespace Swift.Umbraco.Web.Controllers.Backoffice
{
    [PluginController("Tools")]
    public class InstantWinController : UmbracoAuthorizedApiController
    {
        private IInstantWinService _instantWinService;

        public InstantWinController(IInstantWinService instantWinService)
        {
            _instantWinService = instantWinService;
        }

        [System.Web.Http.HttpGet]
        public async Task<IHttpActionResult> GetPrizes()
        {
            dynamic data = new ExpandoObject();
            try
            {
                var prizes = await _instantWinService.GetPrizes();
                data.Description = "Prize list returned successfully";
                data.Prizes = prizes;

                var response = new ApiResponse
                {
                    Success = true,
                    Message = "SUCCESS",
                    Data = data
                };
                return Ok(response);
            }
            catch (Exception e)
            {
                data.Description = e.Message;
                var apiResponse = new ApiResponse
                {
                    Success = false,
                    Message = "FAILED",
                    Data = data
                };
                return Content(HttpStatusCode.InternalServerError, apiResponse);
            }
        }

        [System.Web.Http.HttpGet]
        public async Task<IHttpActionResult> GetLimitOptions()
        {
            dynamic data = new ExpandoObject();
            try
            {
                var options = await _instantWinService.GetLimitOptions();
                data.Description = "Prize list returned successfully";
                data.LimitOptions = options;

                var response = new ApiResponse
                {
                    Success = true,
                    Message = "SUCCESS",
                    Data = data
                };
                return Ok(response);
            }
            catch (Exception e)
            {
                data.Description = e.Message;
                var apiResponse = new ApiResponse
                {
                    Success = false,
                    Message = "FAILED",
                    Data = data
                };
                return Content(HttpStatusCode.InternalServerError, apiResponse);
            }
        }

        [System.Web.Http.HttpPost]
        public async Task<IHttpActionResult> Generate(GeneratorConfig config, List<Allocable> allocable)
        {
            dynamic data = new ExpandoObject();
            try
            {
                var generationResponse = await _instantWinService.GenerateInstantWinMoments(config, allocable);
                data.GeneratedNumber = generationResponse.generatedNumber;

                var response = new ApiResponse
                {
                    Success = generationResponse.status,
                    Message = "SUCCESS",
                    Data = data
                };

                return Ok(response);
            }
            catch (Exception e)
            {
                data.Description = e.Message;
                var apiResponse = new ApiResponse
                {
                    Success = false,
                    Message = "FAILED",
                    Data = data
                };
                return Content(HttpStatusCode.InternalServerError, apiResponse);
            }
        }
    }
}