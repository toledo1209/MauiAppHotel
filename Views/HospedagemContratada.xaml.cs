using MauiAppHotel.Models;

namespace MauiAppHotel.Views
{
    public partial class HospedagemContratada : ContentPage
    {
        public HospedagemContratada(HospedagemResumoModel resumo)
        {
            InitializeComponent();

            // Configura o BindingContext da página com os dados do resumo
            BindingContext = resumo;
        }
    }
}
