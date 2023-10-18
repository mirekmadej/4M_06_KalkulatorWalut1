using System.Net;
using System.Collections.Specialized;
using System.Text;
using System.Text.Json;

namespace _4M_06_KalkulatorWalut
{
    class Waluta
    {
        public string kodWaluty { get; private set; } = "eur";
        public string waluta { get; private set; }
        public string date { get; private set; } = "2023-10-11";
        public double skup { get; private set; }
        public double sprzedaz { get; private set; }
        public Waluta(string code = "eur") 
        {
            if (code.Length > 0)
            {
                kodWaluty = code;
            }
            pobierzDane();
        }
        private void pobierzDane()
        {
            string url = "http://api.nbp.pl/api/exchangerates/rates/c/" + kodWaluty + "/2023-10-11/?format=json";
            string wynik;
            using (var webClient = new WebClient())
            {
                wynik = webClient.DownloadString(url);
            }
            using JsonDocument j1 = JsonDocument.Parse(wynik);
            JsonElement json = j1.RootElement;
            waluta = json.GetProperty("currency").ToString();
            var rates = json.GetProperty("rates");
            var rate = rates[0];
            string bid = rate.GetProperty("bid").ToString();
            bid = bid.Replace('.', ',');
            skup = double.Parse(bid);
            string ask = rate.GetProperty("ask").ToString();
            ask = ask.Replace(".", ",");
            sprzedaz = double.Parse(ask);

        }


    }
    public partial class MainPage : ContentPage
    {
        Waluta waluta;
        public MainPage()
        {
            InitializeComponent();
            euro = new Waluta("eur");
            string s = euro.waluta + " skup: " + euro.skup.ToString() +
                " sprzedaż: " + euro.sprzedaz.ToString();
            lblWalutaInfo.Text = s;
            SemanticScreenReader.Announce(lblWalutaInfo.Text);
        }

        private void btnKupuje(object sender, EventArgs e)
        {
            string w = entKwota.Text.Replace(".",",");
            double kwotaZr;
            bool czyLiczba = double.TryParse(w, out kwotaZr);
            if (!czyLiczba)
            {
                lblWaluta.Text = "podaj liczbę";
            }
            else
            {
                double kwotaWy = kwotaZr * waluta.sprzedaz;
                if (kwotaWy >= 0)
                {
                    string s = "Potrzebujesz: ";
                    s += kwotaWy.ToString("0.00") + " PLN";
                    lblWaluta.Text = s;
                }
                else
                    lblWaluta.Text = "kwato do wymiany musi być 0 lub większa";
            }           
            SemanticScreenReader.Announce(lblWaluta.Text);
        }
        private void btnSprzedaje(object sender, EventArgs e)
        {
            string w = entKwota.Text.Replace(".", ",");
            double kwotaZr;
            bool czyLiczba = double.TryParse(w, out kwotaZr);
            if (!czyLiczba)
            {
                lblWaluta.Text = "podaj liczbę";
            }
            else
            {
                double kwotaWy = kwotaZr * waluta.skup;
                if (kwotaWy >= 0)
                {
                    string s = "otrzymasz: ";
                    s += kwotaWy.ToString("0.00") + " PLN";
                    lblWaluta.Text = s;
                }
                else
                    lblWaluta.Text = "kwato do wymiany musi być 0 lub większa";
            }
            SemanticScreenReader.Announce(lblWaluta.Text);

        }

    }
}