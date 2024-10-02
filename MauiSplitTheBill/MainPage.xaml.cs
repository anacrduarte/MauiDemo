namespace MauiSplitTheBill
{
    public partial class MainPage : ContentPage
    {
        decimal bill;
        int tip;
        int numberPeople = 1;

        public MainPage()
        {
            InitializeComponent();
        }

      

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                var btn = (Button)sender;
                var percentage =
                     int.Parse(btn.Text.Replace("%", ""));
                sldTip.Value = percentage;
            }
        }

        private void btnLess_Clicked(object sender, EventArgs e)
        {
            if (numberPeople > 1)
            {
                numberPeople--;
            }
            lblNoPeople.Text = numberPeople.ToString();
            CalculateTotal();

        }

        private void CalculateTotal()
        {
            
            var totaltip =
                 (bill * tip) / 100;


            var tipPorPeople = (totaltip / numberPeople);
            lblTipPeople.Text = $"{tipPorPeople:C}";

           
            var subtotal = (bill / numberPeople);
            lblSubtotal.Text = $"{subtotal:C}";

            
            var totalPorPeople =
                 (bill + totaltip) / numberPeople;
            lblTotal.Text = $"{totalPorPeople:C}";
        }

        private void btnPlus_Clicked(object sender, EventArgs e)
        {
            numberPeople++;
            lblNoPeople.Text = numberPeople.ToString();
            CalculateTotal();

        }

        private void btnStart_Clicked(object sender, EventArgs e)
        {
            bill = 0.00m;
            tip = 0;
            txtBill.Text = "";
            sldTip.Value = 0;
            lblNoPeople.Text = "1";
            numberPeople = 1;
            CalculateTotal();

        }

        private void txtBill_Completed(object sender, EventArgs e)
        {
            bill = decimal.Parse(txtBill.Text);
            CalculateTotal();
        }

        private void sldTip_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            tip = (int)sldTip.Value;
            lblTip.Text = $"Gorjeta: {tip}%";
            CalculateTotal();

        }
    }

}
