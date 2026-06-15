using NotaNaval.Application.UseCase;
using NotaNaval.Domain.Entities;
using NotaNaval.Domain.Enums;
using NotaNaval.Infrastructure.ModelBuilder;

namespace NotaNaval.Infrastructure.Repository
{
    internal class InMemoryRepository : INotaNavalRepository
    {
        public Task<List<NotaNavalJogo>> GetAllNotaNaval()
        {
            List<NotaNavalJogo> lista = new();
            lista.Add(new()
            {
                Avaliador = Participantes.Andre,
                DataNota = new DateTime(2026, 05, 26),
                Jogo = Videogames._007FirstLight,
                Interessancia = Interessancia._8,
                Qualidade = Qualidade.B,
                UrlEpisodio = "https://youtu.be/4LYnFOjKhV0?si=7atQhYSuj10YEJ9b&t=11173"
            });
            lista.Add(new()
            {
                Avaliador = Participantes.Sushi,
                DataNota = new DateTime(2026, 05, 26),
                Jogo = Videogames._007FirstLight,
                Interessancia = Interessancia._5,
                Qualidade = Qualidade.C,
                UrlEpisodio = "https://youtu.be/4LYnFOjKhV0?si=7atQhYSuj10YEJ9b&t=11173"
            });
            return Task.FromResult(lista);
        }
    }
}
