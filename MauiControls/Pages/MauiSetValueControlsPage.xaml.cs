using System.Globalization;

namespace MauiControls;

public partial class MauiSetValueControlsPage : ContentPage
{
	public MauiSetValueControlsPage()
	{
		InitializeComponent();
	}

    private async void CheckBox1_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		if (e.Value)
		{
			await DisplayAlert("CheckBox", "Marcado", "OK");
		}
		else
		{
            await DisplayAlert("CheckBox", "Desmarcado", "OK");
        }
    }

    private async void CheckBox2_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            await DisplayAlert("CheckBox", "Marcado", "OK");
        }
        else
        {
            await DisplayAlert("CheckBox", "Desmarcado", "OK");
        }

    }

    private async void CheckBox3_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            await DisplayAlert("CheckBox", "Marcado", "OK");
        }
        else
        {
            await DisplayAlert("CheckBox", "Desmarcado", "OK");
        }

    }

    private void Slider1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double valor = Math.Round(Slider1.Value, 2);
        lblSlider.Text = valor.ToString();
        
    }

    private void Stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;

        lblStepper.Text = string.Format($"Valor do Stepper {value}");
    }

    private async void Switch1_Toggled(object sender, ToggledEventArgs e)
    {
        if (e.Value)
        {
            await DisplayAlert("Switch", "On", "OK");
        }
        else
        {
            await DisplayAlert("Switch", "Off", "OK");
        }
    }

    private async void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        CultureInfo culture = new CultureInfo("pt-PT");
        var data = ((DatePicker)sender).Date;
        var dataSelect = data.ToString("d", culture);
        await DisplayAlert("Data Selecionada", dataSelect , "OK");
    }

    private async void Time1_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if(Time1 != null)
        {
            var hour = Time1.Time.ToString(@"hh\mm");
            await DisplayAlert("Hora Selecionada", hour, "OK");

        }
    }
}