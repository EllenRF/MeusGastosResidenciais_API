using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeusGastosResidenciais.Application.Pessoas.CreatePessoa.DTOs
{
    /// <summary>
    /// DTO usado para retornar dados de Pessoa para a API.
    /// </summary>
    public sealed record PessoaDto(int Id, string Nome, int Idade);

}