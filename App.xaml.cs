namespace IvanRecipeApp
{
    public partial class App : Application
    {
        public static Database Database { get; private set; }
        public App()
        {
            InitializeComponent();

            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "recipes.db3");
            Database = new Database(dbPath);

            MainPage = new AppShell();
            MainPage =new NavigationPage(new MainPage());
        }
    }
}
