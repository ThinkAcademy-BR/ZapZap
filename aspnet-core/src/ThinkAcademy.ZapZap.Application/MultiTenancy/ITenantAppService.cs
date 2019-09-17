using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ThinkAcademy.ZapZap.MultiTenancy.Dto;

namespace ThinkAcademy.ZapZap.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

