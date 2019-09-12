using Abp.Application.Services.Dto;

namespace ThinkAcademy.ZapZap.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

