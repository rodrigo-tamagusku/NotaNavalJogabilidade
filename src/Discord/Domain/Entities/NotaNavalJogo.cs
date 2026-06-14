using NotaNaval.Domain.Enums;

namespace NotaNaval.Domain.Entities
{
    public class NotaNavalJogo
    {
        public required Participante Avaliador { get; set; }
        public required Interessancia Interessancia { get; set; }
        public required Qualidade Qualidade { get; set; }
        public required Videogame Jogo { get; set; }
        public DateTime? DataNota { get; set; }
    }
}
