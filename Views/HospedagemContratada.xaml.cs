using MauiAppHotel.Models;

namespace MauiAppHotel.Views
{
    public partial class HospedagemContratada : ContentPage
    {
        public HospedagemContratada(HospedagemResumoModel resumo)
        {
            InitializeComponent();

            // Configura o BindingContext da p�gina com os dados do resumo
            BindingContext = resumo;
        }
    }
}
