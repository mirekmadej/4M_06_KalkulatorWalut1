namespace _4M_06_KalkulatorWalut;

public partial class NewPage1 : ContentPage
{

	public NewPage1()
	{
		InitializeComponent();
		ustawDate();
	}

	private void ustawDate()
	{
		DateTime dzis = DateTime.Today;
		
		DateTime wczoraj = DateTime.Today.AddDays(-1);

        lblData.Text = dzis.ToString("yyyy-MM-dd")+ "\n"
			+wczoraj.ToString();

    }



}