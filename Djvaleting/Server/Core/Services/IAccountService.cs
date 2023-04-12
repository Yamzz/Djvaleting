using Djvaleting.Client.Pages;
using Djvaleting.Shared.ViewModels;

namespace Djvaleting.Server.Core.Services
{
    public interface IAccountService
    {
        Task Login(AccountViewModel accountViewModel);
    }
}
