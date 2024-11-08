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
            // Navega para a página "Sobre" quando o botão "Sobre" é clicado
            await Shell.Current.GoToAsync("Sobre");
        }
    }
}
