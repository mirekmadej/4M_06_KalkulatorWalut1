using System.Net;

namespace _4M_06_KalkulatorWalut
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        static double EUR = 4.55;
        private void btnPrzeliczClicked(object sender, EventArgs e)
        {
            double kwotaZr = double.Parse(entKwota.Text);
            double kwotaWy = 0;
            bool czyPLN = rbtnPLN.IsChecked;
            if (czyPLN)
                kwotaWy = kwotaZr / EUR;
            else
                kwotaWy = kwotaZr * EUR;
            lblOtrzyma.Text = " " + kwotaWy.ToString("0.00");
            if (czyPLN)
                lblWaluta.Text = "PLN";
            else
                lblWaluta.Text = "EUR";
            string json;
            using (var webClient = new WebClient())
            {
                json = webClient.DownloadString("http://api.nbp.pl/api/exchangerates/rates/c/eur/2022-10-10/?format=json");
            }
            //lblJson.Text = json;

        }


    }
}