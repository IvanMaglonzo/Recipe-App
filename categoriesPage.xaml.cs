namespace IvanRecipeApp;

public partial class categoriesPage : ContentPage
{
	public categoriesPage()
	{
		InitializeComponent();
	}

    private async void backBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void filipinoBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new filipinoPage());
    }

    private async void westernBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new westernPage());
    }

    private async void koreanBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new koreanPage());
    }
}