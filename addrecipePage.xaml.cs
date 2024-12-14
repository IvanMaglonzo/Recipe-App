namespace IvanRecipeApp;

public partial class addrecipePage : ContentPage
{
	public addrecipePage()
	{
		InitializeComponent();
	}
    private async void OnSaveRecipeClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TitleEntry.Text) ||
            string.IsNullOrWhiteSpace(IngredientsEditor.Text) ||
            string.IsNullOrWhiteSpace(InstructionsEditor.Text))
        {
            await DisplayAlert("Error", "Please fill in all fields.", "OK");
            return;
        }
        var newRecipe = new Recipe
        {
            Title = TitleEntry.Text,
            Ingredients = IngredientsEditor.Text,
            Instructions = InstructionsEditor.Text
        };
        await App.Database.AddRecipeAsync(newRecipe);
        await DisplayAlert("Success", "Recipe saved successfully!", "OK");

        await Navigation.PopAsync();
    }
}