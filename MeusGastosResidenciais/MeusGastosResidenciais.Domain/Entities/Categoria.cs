using System.Reflection.Metadata;
using MeusGastosResidenciais.Domain.Enums;

namespace MeusGastosResidenciais.Domain.Entities
{
    /// <summary>
    /// Categoria usada para classificar transações.
    /// </summary>
    public class Categoria
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public FinalidadeCategoria FinalidadeCategoria { get; set; }

        // EntityFramework
        public ICollection<Transacao> Transacoes { get; set; } = new List<Transacao>();
    }
}