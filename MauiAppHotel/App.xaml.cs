//using Microsoft.Extensions.DependencyInjection;
using MauiAppHotel.Views;

namespace MauiAppHotel;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        var window = new Window(new NavigationPage(new ContratacaoHospedagem()));
        window.Width = 400;
        window.Height = 600;
        return window;
    }
}