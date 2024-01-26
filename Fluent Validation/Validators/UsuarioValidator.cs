using Fluent_Validation.Models;
using FluentValidation;

namespace Fluent_Validation.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(usuario => usuario.Nome)
                .NotEmpty().WithMessage("O nome e obrigatorio")
                .Length(2, 150).WithMessage("O nome dece ter entre 2 e 150 caracteres");

            RuleFor(usuario => usuario.Email)
                .NotEmpty().WithMessage("O email e Obrigatorio")
                .EmailAddress().WithMessage("O Email nao e Valido");

            RuleFor(usuario => usuario.Idade)
                .InclusiveBetween(18, 99).WithMessage("A Idade deve estar entre 18 e 99 Anos");
        }
    }
}
