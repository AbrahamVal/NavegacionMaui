namespace NavegacionMaui.Views;

public partial class InformacionPage : ContentPage
{
	public InformacionPage()
	{
		InitializeComponent();
	}

    private async void OnRegresarCliked(object sender, EventArgs e)
    {
        // Dos puntos indica  que regrese a la pagina anterior
        await Shell.Current.GoToAsync("..");
    }
}