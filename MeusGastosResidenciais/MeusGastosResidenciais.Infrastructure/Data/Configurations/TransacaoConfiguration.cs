using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MeusGastosResidenciais.Domain.Entities;

namespace MeusGastosResidenciais.Infrastructure.Data.Configurations;

/// <summary>
/// Mapeamento de Transacao.
/// </summary>
public class TransacaoConfiguration : IEntityTypeConfiguration<Transacao>
{
    public void Configure(EntityTypeBuilder<Transacao> builder)
    {
        builder.ToTable("Transacoes");

        builder.HasKey(t => t.Id);

        builder.Property(t => t.Descricao)
            .IsRequired()
            .HasMaxLength(400);

        builder.Property(t => t.Valor)
            .IsRequired()
            .HasColumnType("decimal(18,2)");

        builder.Property(t => t.Tipo)
            .IsRequired();

        builder.Property(t => t.CriadoEm)
            .IsRequired()
            .HasColumnType("datetime2");

        builder.HasOne(t => t.Pessoa)
            .WithMany(p => p.Transacoes)
            .HasForeignKey(t => t.PessoaId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(t => t.Categoria)
            .WithMany(c => c.Transacoes)
            .HasForeignKey(t => t.CategoriaId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}