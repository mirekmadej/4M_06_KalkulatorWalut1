namespace _4M_06_KalkulatorWalut;

public partial class ListaWalut : ContentPage
{
	public ListaWalut()
	{
		InitializeComponent();
		walutaEUR();
	}
	private void walutaEUR()
	{
		Waluta eDzis = new Waluta("eur", "2023-10-19");
		Waluta eWczoraj = new Waluta("eur", "2023-10-18");
		if (eDzis.skup > eWczoraj.skup)
			imgSkup1.Source = "zielona.png";
		else if (eDzis.skup < eWczoraj.skup)
			imgSkup1.Source = "czerwona.png";
		else
			imgSkup1.Source = "rowno.png";
		lblSkup1.Text = eDzis.skup.ToString();
        if (eDzis.sprzedaz > eWczoraj.sprzedaz)
            imgSprzedaz1.Source = "zielona.png";
        else if (eDzis.sprzedaz < eWczoraj.sprzedaz)
            imgSprzedaz1.Source = "czerwona.png";
        else
            imgSprzedaz1.Source = "rowno.png";
		lblSprzedaz1.Text = eDzis.sprzedaz.ToString();
    }
    private void walutaUSD()
    {
        Waluta eDzis = new Waluta("usd", "2023-10-19");
        Waluta eWczoraj = new Waluta("usd", "2023-10-18");
        if (eDzis.skup > eWczoraj.skup)
            imgSkup2.Source = "zielona.png";
        else if (eDzis.skup < eWczoraj.skup)
            imgSkup2.Source = "czerwona.png";
        else
            imgSkup2.Source = "rowno.png";
        lblSkup2.Text = eDzis.skup.ToString();
        if (eDzis.sprzedaz > eWczoraj.sprzedaz)
            imgSprzedaz2.Source = "zielona.png";
        else if (eDzis.sprzedaz < eWczoraj.sprzedaz)
            imgSprzedaz2.Source = "czerwona.png";
        else
            imgSprzedaz2.Source = "rowno.png";
        lblSprzedaz2.Text = eDzis.sprzedaz.ToString();
    }



}