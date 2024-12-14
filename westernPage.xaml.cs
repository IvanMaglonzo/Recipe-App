namespace IvanRecipeApp;

public partial class westernPage : ContentPage
{
	public westernPage()
	{
		InitializeComponent();
	}

    private async void scrambledBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new scramblePage());
    }

    private async void pancakesBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new pancakesPage());
    }

    private async void avocadoBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new avocadoPage());
    }

    private async void backBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}