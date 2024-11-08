namespace MauiAppHotel.Models
{
    public class Quarto
    {
        public string Descricao { get; set; } = string.Empty; // Inicializado para evitar nulo
        public double ValorDiariaAdulto { get; set; }
        public double ValorDiariaCrianca { get; set; }
    }
}
