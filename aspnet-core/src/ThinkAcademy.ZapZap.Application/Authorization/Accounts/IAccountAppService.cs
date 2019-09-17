using System.Threading.Tasks;
using Abp.Application.Services;
using ThinkAcademy.ZapZap.Authorization.Accounts.Dto;

namespace ThinkAcademy.ZapZap.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
