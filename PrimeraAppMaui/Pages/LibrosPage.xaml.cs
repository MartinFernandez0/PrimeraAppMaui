namespace PrimeraAppMaui.Pages;

public partial class LibrosPage : ContentPage
{
	public LibrosPage()
	{
		InitializeComponent();
	}
    private void btnVolver_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}