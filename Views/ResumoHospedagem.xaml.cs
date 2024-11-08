using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views
{
    public partial class ResumoHospedagem : ContentPage
    {
        // Construtor que recebe os dados
        public ResumoHospedagem(int adultos, int criancas, string quarto, string periodo, decimal valor)
        {
            InitializeComponent();

            // Preenchendo as informações recebidas nos controles
            lblAdultos.Text = $"Adultos: {adultos}";
            lblCriancas.Text = $"Crianças: {criancas}";
            lblQuarto.Text = $"Quarto: {quarto}";
            lblPeriodo.Text = $"Período: {periodo}";
            lblValor.Text = $"Valor Total: R$ {valor:F2}";
        }

        // Evento de clique para finalizar a reserva
        private async void OnFinalizarClicked(object sender, EventArgs e)
        {
            // Exibe uma mensagem de confirmação
            await DisplayAlert("Reserva Finalizada", "Sua reserva foi realizada com sucesso!", "OK");

            // Navega para a página anterior ou outra página, se necessário
            await Navigation.PopAsync();
        }
    }
}
