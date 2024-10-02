using MauiDemoDataBinding.Models;

namespace MauiDemoDataBinding.Pages;

public partial class NotifyBindingPage : ContentPage
{
	Product product = new Product();
	public NotifyBindingPage()
	{
		InitializeComponent();

        product = new Product
        {
            NameP = "iPhone 5",
            Price = 1000,
            Stock = 5,
        };
        BindingContext = product;
    }

    private async void BtnUpdate_Clicked(object sender, EventArgs e)
    {
        product.NameP = "Galaxy Samsung 10";
        product.Price = 3000;
        product.Stock = 55;

        await DisplayAlert("Produto actualizado", $"{product.NameP} - {product.Price} - {product.Stock}", "OK");
    }
}