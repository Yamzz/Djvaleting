using Djvaleting.Shared.ViewModels;

namespace Djvaleting.Server.Core.Services
{
    public class AccountService : IAccountService
    {
        public AccountService()
        {

        }
       
        public Task Login(AccountViewModel accountViewModel)
        {
            // verify account user in database
            throw new NotImplementedException();
        }
    }
}
