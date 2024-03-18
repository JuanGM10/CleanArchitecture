using CleanArchitecture.Application.Contracts.Identity;
using CleanArchitecture.Application.Models.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace FunctionAccount
{
    public  class FunctionRegister
    {
        private readonly IAuthService _authService;
        public FunctionRegister(IAuthService authService)
        {
            _authService = authService;
        }

        [FunctionName("FunctionRegister")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous,  "post", Route = null)] RegistrationRequest req,
            ILogger log)
        {
            var response = await _authService.Register(req);
            return new OkObjectResult(response);
        }
    }
}
