using NotaNaval.Domain.Entities;

namespace NotaNaval.Application.UseCase
{
    public interface INotaNavalRepository
    {
        public Task<List<NotaNavalJogo>> GetAllNotaNaval();
    }
}
