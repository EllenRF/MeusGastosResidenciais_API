using FluentValidation;

namespace MeusGastosResidenciais.Application.Pessoas.CreatePessoa
{
    public class CreatePessoaValidator : AbstractValidator<CriarPessoaCommand>
    {
        /// <summary>
        /// Validações básicas de criação de Pessoa (formato/dados).
        /// </summary>
        public CreatePessoaValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("Nome é obrigatório.")
                .MaximumLength(200).WithMessage("Nome deve ter no máximo 200 caracteres.");

            RuleFor(x => x.Idade)
                .NotEmpty().WithMessage("Idade é obrigatória.")
                .GreaterThanOrEqualTo(0).WithMessage("Idade não pode ser negativa.");
        }
    }
}