using Microsoft.Maui.Controls;

namespace MauiAppHotel
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Registrando rotas para as páginas
            Routing.RegisterRoute("ContratacaoHospedagem", typeof(Views.ContratacaoHospedagem));
            Routing.RegisterRoute("Sobre", typeof(Views.Sobre));

            Routing.RegisterRoute("ResumoHospedagem", typeof(Views.ResumoHospedagem));

        }
    }
}
