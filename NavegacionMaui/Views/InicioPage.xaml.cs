namespace NavegacionMaui.Views;

public partial class InicioPage : ContentPage
{
	public InicioPage()
	{
        // crea los controles que escribimos en el archivo .xaml
        InitializeComponent();
	}

    private async void OnVerInformacionClicked(object sender, EventArgs e)
    {
        // abra la navegacion asosiada a la pagina 
        await Shell.Current.GoToAsync("InformacionPage");
    }
}