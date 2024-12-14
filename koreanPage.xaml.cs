namespace IvanRecipeApp;

public partial class koreanPage : ContentPage
{
	public koreanPage()
	{
		InitializeComponent();
	}

    private async void kimchiBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new kimchiPage());
    }

    private async void bibimbapBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new bibimbapPage());
    }

    private async void tteokbokkiBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new tteokbokkiPage());
    }

    private async void backBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}