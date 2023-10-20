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
        DateTime dDzis = DateTime.Today;
        DateTime dWczoraj = DateTime.Today.AddDays(-1);
        string dzis = dDzis.ToString("yyyy-MM-dd");
        string wczoraj = dWczoraj.ToString("yyyy-MM-dd");
        
        Waluta eDzis = new Waluta("eur", dzis);
		Waluta eWczoraj = new Waluta("eur", wczoraj);
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
        DateTime dDzis = DateTime.Today;
        DateTime dWczoraj = DateTime.Today.AddDays(-1);
        string dzis = dDzis.ToString("yyyy-MM-dd");
        string wczoraj = dWczoraj.ToString("yyyy-MM-dd"); 
        Waluta eDzis = new Waluta("usd", dzis);
        Waluta eWczoraj = new Waluta("usd", wczoraj);
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