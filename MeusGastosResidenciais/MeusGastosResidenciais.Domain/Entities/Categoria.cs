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
        public TipoCategoria TipoCategoria { get; set; }
        public ICollection<Transacao> Transacoes{ get; set; } = new List<Transacao>();
    }
}