namespace MeusGastosResidenciais.Domain.Entities
{
/// <summary>
/// Representa uma pessoa no sistema.
/// </summary>
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }
        public bool MenorIdade { get; set; }
        public ICollection<Transacao> Transacoes { get; set; } = new List<Transacao>();
    }
}