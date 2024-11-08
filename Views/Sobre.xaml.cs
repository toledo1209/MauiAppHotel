using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views
{
    public partial class Sobre : ContentPage
    {
        // Construtor da classe Sobre
        public Sobre()
        {
            InitializeComponent();
        }

        // Evento chamado quando o bot�o "Voltar" � clicado
        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(); // Navega para a p�gina anterior
        }
    }
}
