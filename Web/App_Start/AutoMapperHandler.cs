using AutoMapper;
using Models.Mapping;
using Umbraco.Core;
using Umbraco.Core.Models.Mapping;

namespace Trebor.Cash.In.Flash
{
    public class AutoMapperHandler : MapperConfiguration
    {
        public override void ConfigureMappings(IConfiguration config, ApplicationContext applicationContext)
        {
            config.AddProfile<DomainMapperProfile>();
            config.AddProfile(new DomainMapperProfile());
        }
    }
}