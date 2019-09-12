using Abp.Application.Editions;
using Abp.Application.Features;
using Abp.Domain.Repositories;

namespace ThinkAcademy.ZapZap.Editions
{
    public class EditionManager : AbpEditionManager
    {
        public const string DefaultEditionName = "Standard";

        public EditionManager(
            IRepository<Edition> editionRepository, 
            IAbpZeroFeatureValueStore featureValueStore)
            : base(
                editionRepository,
                featureValueStore)
        {
        }
    }
}
