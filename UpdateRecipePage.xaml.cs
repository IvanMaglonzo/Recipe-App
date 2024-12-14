namespace IvanRecipeApp;

public partial class UpdateRecipePage : ContentPage
{
    private Recipe _currentRecipe;
    public UpdateRecipePage(Recipe recipe)
	{
        InitializeComponent();
        _currentRecipe = recipe;

        TitleEntry.Text = recipe.Title;
        IngredientsEditor.Text = recipe.Ingredients;
        InstructionsEditor.Text = recipe.Instructions;
    }
    private async void OnSaveClicked(object sender, EventArgs e)
    {
        _currentRecipe.Title = TitleEntry.Text;
        _currentRecipe.Ingredients = IngredientsEditor.Text;
        _currentRecipe.Instructions = InstructionsEditor.Text;

        await App.Database.UpdateRecipeAsync(_currentRecipe);
        await DisplayAlert("Success", "Recipe updated successfully!", "OK");

        await Navigation.PopAsync();
    }

    private async void OnDeleteClicked(object sender, EventArgs e)
    {
        bool confirm = await DisplayAlert("Delete", "Are you sure you want to delete this recipe?", "Yes", "No");

        if (confirm)
        {

            await App.Database.DeleteRecipeAsync(_currentRecipe);
            await DisplayAlert("Deleted", "Recipe has been deleted.", "OK");

            await Navigation.PopAsync();
        }
    }
}