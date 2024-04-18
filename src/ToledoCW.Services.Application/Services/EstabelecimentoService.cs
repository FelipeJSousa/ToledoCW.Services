using ToledoCW.Services.Application.Interfaces;
using ToledoCW.Services.Infraestructure.Entidades;

namespace ToledoCW.Services.Application.Services;

public class EstabelecimentoService : ServiceBase<Estabelecimento>, IEstabelecimentoService
{
    public EstabelecimentoService(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }
}