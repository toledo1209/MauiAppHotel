using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views
{
    public partial class ContratacaoHospedagem : ContentPage
    {
        public ContratacaoHospedagem()
        {
            InitializeComponent();
        }

        private async void OnSobreClicked(object sender, EventArgs e)
        {
            // Navega para a p�gina "Sobre" quando o bot�o "Sobre" � clicado
            await Shell.Current.GoToAsync("Sobre");
        }
    }
}
