using FluentValidation;
using ToledoCW.Services.Domain.Entities;

namespace ToledoCW.Services.Domain.Validators;

public class AtendenteValidator : AbstractValidator<Atendente>
{
    public AtendenteValidator()
    {
        RuleFor(x => x.Nome).NotEmpty().WithMessage("Nome é obrigatório");
        RuleFor(x => x.Nome).MaximumLength(100).WithMessage("Nome deve ter no máximo 100 caracteres");
        RuleFor(x => x.Estabelecimento).NotEmpty().WithMessage("Estabelecimento é obrigatório");
    }
}