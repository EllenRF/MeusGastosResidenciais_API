
namespace MeusGastosResidenciais.Application.Pessoas.DTOs
{
    /// <summary>
    /// DTO usado para retornar dados de Pessoa para a API.
    /// </summary>
    public sealed record PessoaDto(int Id, string Nome, int Idade);

}