using Djvaleting.Server.Core.Services;
using Djvaleting.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Djvaleting.Server.Controllers
{

    [ApiController]
    [Route("api/account")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        // POST: api/account
        [HttpPost]
        public IActionResult Post([FromBody] AccountViewModel accountViewModel)
        {
            // Verify User and password in database
            return Ok(accountViewModel.Id);
        }

    }
}
