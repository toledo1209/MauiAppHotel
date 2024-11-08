using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views
{
    public partial class ResumoHospedagem : ContentPage
    {
        // Construtor que recebe os dados
        public ResumoHospedagem(int adultos, int criancas, string quarto, string periodo, decimal valor)
        {
            InitializeComponent();

            // Preenchendo as informa��es recebidas nos controles
            lblAdultos.Text = $"Adultos: {adultos}";
            lblCriancas.Text = $"Crian�as: {criancas}";
            lblQuarto.Text = $"Quarto: {quarto}";
            lblPeriodo.Text = $"Per�odo: {periodo}";
            lblValor.Text = $"Valor Total: R$ {valor:F2}";
        }

        // Evento de clique para finalizar a reserva
        private async void OnFinalizarClicked(object sender, EventArgs e)
        {
            // Exibe uma mensagem de confirma��o
            await DisplayAlert("Reserva Finalizada", "Sua reserva foi realizada com sucesso!", "OK");

            // Navega para a p�gina anterior ou outra p�gina, se necess�rio
            await Navigation.PopAsync();
        }
    }
}
