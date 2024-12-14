using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanRecipeApp
{
    public class Recipe
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Ingredients { get; set; }
        public string? Instructions { get; set; }
    }
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Recipe>().Wait();
        }

        // Add a new recipe
        public Task<int> AddRecipeAsync(Recipe recipe)
        {
            return _database.InsertAsync(recipe);
        }

        // Retrieve all recipes
        public Task<List<Recipe>> GetRecipesAsync()
        {
            return _database.Table<Recipe>().ToListAsync();
        }

        // Delete a recipe
        public Task<int> DeleteRecipeAsync(Recipe recipe)
        {
            return _database.DeleteAsync(recipe);
        }
        public Task<int> UpdateRecipeAsync(Recipe recipe)
        {
            return _database.UpdateAsync(recipe);
        }
    }
}
