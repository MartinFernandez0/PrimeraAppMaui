namespace PrimeraAppMaui.Pages;

public partial class InicioPage : ContentPage
{
	public InicioPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		//Metodo para llamar a otra pagina desde un boton
		Navigation.PushAsync(new LibrosPage());
    }
}