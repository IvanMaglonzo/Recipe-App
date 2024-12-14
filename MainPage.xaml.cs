namespace IvanRecipeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void getstartBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new homePage());
        }
    }
}
