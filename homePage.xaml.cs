using System.Collections.ObjectModel;

namespace IvanRecipeApp;

public partial class homePage : ContentPage
{
    private ObservableCollection<Recipe> _recipes;
    public homePage()
	{
		InitializeComponent();
        _recipes = new ObservableCollection<Recipe>();
        RecipeListView.ItemsSource = _recipes;
    }

    private async void addRecipeBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new addrecipePage());
    }

    private async void backBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void categoriesBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new categoriesPage());
    }
    private async void OnRecipeSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Recipe selectedRecipe)
        {
            await Navigation.PushAsync(new UpdateRecipePage(selectedRecipe));
        }
    ((CollectionView)sender).SelectedItem = null;
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await LoadRecipes(); 
    }

    private async Task LoadRecipes()
    {
        var recipes = await App.Database.GetRecipesAsync(); 
        _recipes.Clear();
        foreach (var recipe in recipes)
        {
            _recipes.Add(recipe);
        }
    }
}