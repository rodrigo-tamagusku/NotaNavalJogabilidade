namespace NotaNaval.Domain.Enums
{
    /// <summary>
    /// Em letra, representa o quão bom ou ruim.
    /// A é bom, J é ruim.
    /// O número no enum representa sua coordenada no eixo vertical
    /// </summary>
    public enum Qualidade
    {
        A = 5, B = 4, C = 3, D = 2, E = 1,
        F = -1, G = -2, H = -3, I = -4, J = -5
    }
}
