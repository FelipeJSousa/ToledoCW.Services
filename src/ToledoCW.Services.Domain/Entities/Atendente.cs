using ToledoCW.Services.Domain.Validators;
using ToledoCW.Services.Infraestructure.Entidades;

namespace ToledoCW.Services.Domain.Entities;

public class Atendente
{
    public long Id { get; set; }
    public string Nome { get; set; }

    public long? Estabelecimento { get; set; }
    
    public Estabelecimento EstabelecimentoObj { get; set; }

    public bool EhValido()
    {
        var _validator = new AtendenteValidator();
        var _result = _validator.Validate(this);
        return _result.IsValid;
    }

}