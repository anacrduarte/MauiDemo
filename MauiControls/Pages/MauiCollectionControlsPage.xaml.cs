using MauiControls.Models;

namespace MauiControls.Pages;

public partial class MauiCollectionControlsPage : ContentPage
{
    public MauiCollectionControlsPage()
    {
        InitializeComponent();
        BindingContext = new FotoViewModel();
    }

    private async void CarouselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
    {
        if (e.CurrentItem != null && e.PreviousItem != null)
        {
            Foto previus = e.PreviousItem as Foto;
            Foto next = e.CurrentItem as Foto;

            await DisplayAlert("CarrouselView", $"Anterior = {previus.Name} \n\n Pr�ximo = {next.Name}", "OK");
        }

    }

    private void AlertaCinto_OnChanged(object sender, ToggledEventArgs e)
    {
        DisplayAlert("Alerta de Cinto de Seguran�a", $"Selecionou ou desselecionou esse acess�rio", "OK");
    }
}