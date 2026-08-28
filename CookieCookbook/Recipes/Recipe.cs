using System.Data.Common;

namespace CookieCookBook.Recipes
{
    public class Recipe
    {
        public IEnumerable<Ingredient> Ingredients { get;}

        public Recipe(IEnumerable<Ingredient> Ingredients )
        {
            Ingredients = ingredients;
        }
    }
}