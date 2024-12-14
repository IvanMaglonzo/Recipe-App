namespace IvanRecipeApp;

public partial class filipinoPage : ContentPage
{
	public filipinoPage()
	{
		InitializeComponent();
	}

    private async void adoboBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new adoboPage());
    }

    private async void shanghaiBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new shanghaiPage());
    }

    private async void nilagaBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new nilagaPage());
    }

    private async void backBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
