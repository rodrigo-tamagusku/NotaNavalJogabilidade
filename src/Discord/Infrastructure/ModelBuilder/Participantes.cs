using NotaNaval.Domain.Entities;

namespace NotaNaval.Infrastructure.ModelBuilder
{
    public static class Participantes
    {
        public static Participante Tengu => GetTengu();
        public static Participante Andre => GetAndre();
        public static Participante Rafa => GetAndre();
        public static Participante Sushi => GetSushi();

        private static Participante GetTengu()
        {
            return new()
            {
                Nome = "Tengu",
                IconeUrl = "https://cdn.bsky.app/img/avatar/plain/did:plc:37kr5gaisbe7ozb5raorpp27/bafkreiblmvsvizjh54hv7ozu4zxcbf3ma6gpah7en6tswfrqn2iixovsci",
                RedesSociais = new()
                {
                    "https://bsky.app/profile/tengumaru.jogabilida.de"
                }
            };
        }
        private static Participante GetAndre()
        {
            return new()
            {
                Nome = "André Campos",
                IconeUrl = "https://cdn.bsky.app/img/avatar/plain/did:plc:pwaza4bodg6jvwmwg57lyobf/bafkreib4cs3om64tz3tqr3s5hzbbxf4xonddn5gfzdu2z4v4gzozj4cqhq",
                RedesSociais = new()
                {
                    "https://bsky.app/profile/majin.jogabilida.de"
                }
            };
        }
        private static Participante GetSushi()
        {
            return new()
            {
                Nome = "Sushi",
                IconeUrl = "https://cdn.bsky.app/img/avatar/plain/did:plc:wp66526esbi4oat2hwkpnvct/bafkreig4a7h2f3gak4bgnjmicd6gl5xxxspmjsdosh2n6sl3aqtdp4teoa",
                RedesSociais = new()
                {
                    "https://bsky.app/profile/sushi.jogabilida.de"
                }
            };
        }
    }
}
