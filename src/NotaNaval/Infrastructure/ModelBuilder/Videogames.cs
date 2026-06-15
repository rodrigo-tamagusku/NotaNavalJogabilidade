using NotaNaval.Domain.Entities;

namespace NotaNaval.Infrastructure.ModelBuilder
{
    public static class Videogames
    {
        public static Videogame _007FirstLight => Get007FirstLight();
        private static Videogame Get007FirstLight()
        {
            return new()
            {
                Nome = "007 First Light",
                DisplayUrl = "https://images.igdb.com/igdb/image/upload/t_cover_big_2x/coaoiz.jpg"
            };
        }
    }
}
