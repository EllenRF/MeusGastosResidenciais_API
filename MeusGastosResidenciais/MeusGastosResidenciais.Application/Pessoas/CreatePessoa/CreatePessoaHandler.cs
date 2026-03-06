using MediatR;
using MeusGastosResidenciais.Application.Pessoas.CreatePessoa.DTOs;
using MeusGastosResidenciais.Domain.Entities;
using MeusGastosResidenciais.Infrastructure.Data;

namespace MeusGastosResidenciais.Application.Pessoas.CreatePessoa;

public class CriarPessoaHandler : IRequestHandler<CriarPessoaCommand, PessoaDto>
{
    private readonly AppDbContext _db;

    public CriarPessoaHandler(AppDbContext db)
    {
        _db = db;
    }

    public async Task<PessoaDto> Handle(CriarPessoaCommand request, CancellationToken cancellationToken)
    {
        var pessoa = new Pessoa
        {
            Nome = request.Nome,
            Idade = request.Idade,
            MenorIdade = request.Idade < 18 ? true : false
        };

        _db.Pessoas.Add(pessoa);
        await _db.SaveChangesAsync(cancellationToken);

        return new PessoaDto
        (
            pessoa.Id,
            pessoa.Nome,
            pessoa.Idade
        );
    }
}