using System.Threading.Tasks;
using Abp.Application.Services;
using ThinkAcademy.ZapZap.Sessions.Dto;

namespace ThinkAcademy.ZapZap.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
