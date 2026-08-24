var cookiesRecipresApp = new CookiesRecipesApp(
    new RecipesRepository(),
    new RecipresConsoleUserInteraction());
cookieRecipresApp.Run();

public class CookiesRecipesApp
{
    private readonly IRecipesRepository _recipesRepository = new (); 
    private readonly IRecipesUserInteraction _recipesUserInteraction ;

    public CookiesRecipesApp(
        IRecipesRepository recipesRepository,
        RecipresConsoleUserInteraction recipesUserInteraction)
    {
        _recipesRepository = recipesRepository;
        _recipesUserInteraction = recipesUserInteraction;
    }


    public void Run()
    {
        var allRecipes = _recipesRepository.Read(filePath);
        _recipesConsoleUserInteraction.PrintExistingRecipes(allRecipes);

        _recipesConsoleUserInteraction.PromtToCreateRecipe();

        var ingredients = _recipesConsoleUserInteraction.ReadIngredientsFromUser();
        if(ingredienets.Count > 0)
        {
            var recipes = new Recipe(ingredients);
            allRecipes.Add(recipe);
            _recipesRepository.Write(filePath, allRecipes);

            _recipesConsoleUserInteraction.ShowMessage("Recipe added: ");
            _recipesConsoleUserInteraction.ShowMessage(recipes.ToString());



        }
        else
        {
            _recipesConsoleUserInteraction.ShowMessage(
                "No ingredients have been selected. " +
                "Recipe will not be saved. ");
        }
        _recipesConsoleUserInteraction.Exit();
    }
}

public interface IRecipesUserInteraction
{
    void ShowMessage(string message);
    void Exit();
}

public class RecipresConsoleUserInteraction : IRecipesUserInteraction
{
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
    public void Exit()
    {
        Console.WriteLine("Press any key to close.");
        Console.ReadKey();
    }
}

public interface IRecipesRepository
{
    
}
public class RecipesRepository : IRecipesRepository
{
    
}
