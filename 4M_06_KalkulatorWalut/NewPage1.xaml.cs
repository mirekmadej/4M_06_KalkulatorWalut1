namespace _4M_06_KalkulatorWalut;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}
	private void pckIndexChanged(object sender, EventArgs e)
	{
		lblWybranaWaluta.Text = pckWaluta.SelectedIndex.ToString();	

	}
}