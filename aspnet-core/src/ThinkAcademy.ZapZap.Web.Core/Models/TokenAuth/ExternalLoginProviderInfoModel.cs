using Abp.AutoMapper;
using ThinkAcademy.ZapZap.Authentication.External;

namespace ThinkAcademy.ZapZap.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
