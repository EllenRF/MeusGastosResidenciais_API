using MediatR;
using MeusGastosResidenciais.Application.Pessoas.DTOs;

namespace MeusGastosResidenciais.Application.Pessoas.CreatePessoa
{
    /// <summary>
    /// Command responsável por criar uma nova Pessoa.
    /// </summary>
    public sealed record CriarPessoaCommand(string Nome, int Idade) : IRequest<PessoaDto>;

}