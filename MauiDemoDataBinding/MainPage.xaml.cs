using MauiDemoDataBinding.Models;
using System.Net.Http.Headers;

namespace MauiDemoDataBinding
{
    public partial class MainPage : ContentPage
    {
        //int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        //private void OnCounterClicked(object sender, EventArgs e)
        //{
        //    var product = new Product
        //    {
        //        NameP = "iPhone 5",
        //        Price = 1000,
        //        Stock = 5,

        //    };
        //    //Binding productBinding = new Binding();

        //    //productBinding.Source = product;

        //    //productBinding.Path = "NameP";

        //    //lblName.SetBinding(Label.TextProperty, productBinding);

        //    Binding nameBinding = new Binding
        //    {
        //        Source = product,
        //        Path = "NameP",
        //        StringFormat = "Produto: {0}",

        //    };
        //    lblName.SetBinding(Label.TextProperty, nameBinding);
        //    Binding priceBinding = new Binding
        //    {
        //        Source = product,
        //        Path = "Price",
        //        StringFormat = "Preço: {0}",

        //    };
        //    lblPrice.SetBinding(Label.TextProperty, priceBinding);
        //    Binding stockBinding = new Binding
        //    {
        //        Source = product,
        //        Path = "Stock",
        //        StringFormat = "Stock: {0}",

        //    };
        //    lblStock.SetBinding(Label.TextProperty, stockBinding);
        //}
    }

}
