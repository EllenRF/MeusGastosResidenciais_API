using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MeusGastosResidenciais.Application.Pessoas.DTOs;

namespace MeusGastosResidenciais.Application.Pessoas.UpdatePessoa
{
    /// <summary>
    /// Command responsável por atualizar uma Pessoa existente.
    /// </summary>
    public sealed record UpdatePessoaCommand(string Nome, int Idade) : IRequest<PessoaDto>;
}