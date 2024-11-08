namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    App? PropriedadesApp; // Definido como anulável

    public ContratacaoHospedagem()
    {
        InitializeComponent();

        PropriedadesApp = Application.Current as App;

        if (PropriedadesApp?.lista_quartos != null)
        {
            pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;
        }

        dtpck_checkin.MinimumDate = DateTime.Now;
        dtpck_checkin.MaximumDate = DateTime.Now.AddMonths(1);

        dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new HospedagemContratada());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_checkin = elemento?.Date ?? DateTime.Now;

        dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);
    }
}
