namespace NotaNaval.Domain.Entities
{
    public record Participante
    {
        public required string Nome { get; set; }
        public string? IconeUrl { get; set; }
        public List<string> RedesSociais { get; set; } = new List<string>();
    }
}
