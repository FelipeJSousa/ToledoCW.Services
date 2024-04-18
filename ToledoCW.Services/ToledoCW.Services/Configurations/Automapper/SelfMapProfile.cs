using AutoMapper;
using AutoMapper.Internal;
using ToledoCW.Services.Core.Extensions;
using ToledoCW.Services.Domain.Entities;

namespace ToledoCW.Services.Configurations.Automapper;

public class SelfMapProfile : Profile
{
    public SelfMapProfile() : base("SelfMapProfile")
    {
        AllowNullCollections = true;

        ((IProfileExpressionInternal) this).ForAllMaps((_, cnfg) =>
            cnfg.ForAllMembers(opts => opts.IgnoreSourceAndDefault()));
        ((IProfileExpressionInternal) this).ForAllMaps((_, e) =>
            e.AfterMap(MemberConfigurationExpressionExtensions.SetNullFromNullableDefault));

        CreateMap<Atendente, Atendente>();
    }
}