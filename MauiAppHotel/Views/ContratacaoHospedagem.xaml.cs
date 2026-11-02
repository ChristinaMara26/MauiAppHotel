namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ContratacaoHospedagem()
    {
        InitializeComponent();
    }

    private async void Button_Avancar_Clicked(object sender, EventArgs e)
    {
        try
        {
            // Código para avançar (pode deixar vazio ou com um aviso simples por enquanto)
            await DisplayAlert("Aviso", "Avançando...", "OK");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", ex.Message, "OK");
        }
    }

    private async void Button_Sobre_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SobrePage());
    }
}