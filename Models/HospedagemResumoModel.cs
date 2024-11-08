namespace MauiAppHotel.Models
{
    public class HospedagemResumoModel
    {
        public string Quarto { get; set; }     // Propriedade obrigatória
        public string Periodo { get; set; }    // Propriedade obrigatória
        public int Adultos { get; set; }       // Propriedade obrigatória
        public int Criancas { get; set; }      // Propriedade obrigatória
        public double Valor { get; set; }      // Propriedade obrigatória

        // Construtor para inicializar as propriedades
        public HospedagemResumoModel(string quarto, string periodo, int adultos, int criancas, double valor)
        {
            Quarto = quarto;
            Periodo = periodo;
            Adultos = adultos;
            Criancas = criancas;
            Valor = valor;
        }
    }
}
