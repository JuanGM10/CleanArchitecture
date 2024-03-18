using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using CleanArchitecture.Application.Models.Identity;
using CleanArchitecture.Application.Contracts.Identity;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;


namespace FunctionLogin
{
    public  class Login
    {
        private readonly IAuthService _authService;
        public Login(IAuthService authService)
        {
            _authService = authService;
        }


        [FunctionName("Login")]
        public  async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)] AuthRequest request,
            ILogger log)
        {
            var data = await _authService.Login(request);

            return new OkObjectResult(data);
        }
    }
}
